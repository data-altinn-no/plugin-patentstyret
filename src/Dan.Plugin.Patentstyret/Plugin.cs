using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Dan.Common;
using Dan.Common.Exceptions;
using Dan.Common.Interfaces;
using Dan.Common.Models;
using Dan.Common.Util;
using Dan.Plugin.Patentstyret.Config;
using Dan.Plugin.Patentstyret.Models;
using Google.Protobuf;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace Dan.Plugin.Patentstyret;

public class Plugin
{
    private readonly IEvidenceSourceMetadata _evidenceSourceMetadata;
    private readonly ILogger _logger;
    private readonly HttpClient _client;
    private readonly ApplicationSettings _settings;

    // These are not mandatory, but there should be a distinct error code (any integer) for all types of errors that can occur. The error codes does not have to be globally
    // unique. These should be used within either transient or permanent exceptions, see Plugin.cs for examples.
    private const int ERROR_UPSTREAM_UNAVAILBLE = 1001;
    private const int ERROR_INVALID_INPUT = 1002;
    private const int ERROR_NOT_FOUND = 1003;
    private const int ERROR_UNABLE_TO_PARSE_RESPONSE = 1004;

    public Plugin(
        IHttpClientFactory httpClientFactory, ILoggerFactory loggerFactory, IOptions<ApplicationSettings> settings, IEvidenceSourceMetadata evidenceSourceMetadata)
    {
        _client = httpClientFactory.CreateClient(Constants.SafeHttpClient);
        _logger = loggerFactory.CreateLogger<Plugin>();
        _settings = settings.Value;
        _evidenceSourceMetadata = evidenceSourceMetadata;
    }

    [Function("Varemerker")]
    public async Task<HttpResponseData> Varemerker(
        [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequestData req,
        FunctionContext context)
    {
        var evidenceHarvesterRequest = await req.ReadFromJsonAsync<EvidenceHarvesterRequest>();

        return await EvidenceSourceResponse.CreateResponse(req, () => GetVaremerker(evidenceHarvesterRequest));
    }

    private async Task<List<EvidenceValue>> GetVaremerker(EvidenceHarvesterRequest evidenceHarvesterRequest)
    {
        var url = _settings.PatentUrl + "register/v1/IprCasesByCompany?companyNumber=" + evidenceHarvesterRequest.SubjectParty.NorwegianOrganizationNumber;

        var patentResponse = await MakeRequest<PatentModel>(url);

        //retrieve expiry dates for patents, trademarks and designs
        var result = await GetDetailedInfo(patentResponse);

        var ecb = new EvidenceBuilder(_evidenceSourceMetadata, "Varemerker");
        ecb.AddEvidenceValue("default", JsonConvert.SerializeObject(result), _evidenceSourceMetadata.GetEvidenceCodes().Where(x=>x.EvidenceCodeName == "Varemerker").First().EvidenceSource, false);
        return ecb.GetEvidenceValues();
    }

    private async Task<Patents> GetDetailedInfo(PatentModel patents)
    {
        var resultModel = new Patents()
        {
            PatentsList = new List<ExternalModel>(),
            PartyIdentifier = patents.partyIdentifier
        };

        foreach (var a in patents.designBag)
        {
           // var result = await MakeRequest<Dan.Plugin.Patentstyret.Models.Design.DesignApplication>(_settings.PatentUrl + $"register/Design/{a.applicationNumber}");

            var design = new ExternalModel()
                {
                  ApplicationNumber = a.applicationNumber,
                  CaseUrl = a.caseUrl,
                  CurrentStatus = a.currentStatusEn,
                  Type = PatentType.Design,
                  CurrentStatusChanged = a.currentStatusDate,
                  ExpirationDate = a.expiryDate,
                  PatentNumber = a.registrationNumber,
                  Description = string.Join(", ", a.designTitleText),
                  DesignImage = a.image
            };

            resultModel.PatentsList.Add(design);
            
        }

        foreach (var a in patents.trademarkBag)
        {
           // var result = await MakeRequest<Dan.Plugin.Patentstyret.Models.Trademark.TrademarkApplication>(_settings.PatentUrl + $"register/Trademark/{a.applicationNumber}");

            var tm = new ExternalModel()
                {
                    ApplicationNumber = a.applicationNumber,
                    CaseUrl = a.caseUrl,
                    CurrentStatus = a.currentStatusEn,
                    Type = PatentType.Trademark,
                    CurrentStatusChanged =a.currentStatusDate,
                    ExpirationDate = a.expiryDate,
                    PatentNumber = a.registrationNumber,
                    Description = a.markVerbalElementText,
                    DesignImage = null
                };

            resultModel.PatentsList.Add(tm);
            
        }

        foreach (var a in patents.patentBag)
        {
            //var result = await MakeRequest<Dan.Plugin.Patentstyret.Models.Patent.PatentApplication>(_settings.PatentUrl + $"register/Patent/{a.applicationNumber}");

            var tm = new ExternalModel()
            {
                ApplicationNumber = a.applicationNumber,
                CaseUrl = a.caseUrl,
                CurrentStatus = a.currentStatusEn,
                Type = PatentType.Patent,
                CurrentStatusChanged = a.currentStatusDate,
                ExpirationDate = a.expiryDate,
                PatentNumber = a.patentNumber,
                Description = a.inventionTitle,
                DesignImage = null
            };

            resultModel.PatentsList.Add(tm);
        }

        return resultModel;
    }

    private async Task<T> MakeRequest<T>(string target)
    {
        HttpResponseMessage result;
        try
        {
            var request = new HttpRequestMessage(HttpMethod.Get, target);
            request.Headers.TryAddWithoutValidation("ocp-apim-subscription-key", _settings.ApiKey);
            result = await _client.SendAsync(request);
        }
        catch (HttpRequestException ex)
        {
            _logger.LogError("Unable to parse data returned from upstream source ({target}: {exceptionType}: {exceptionMessage}", target, ex.GetType().Name, ex.Message);
            throw new EvidenceSourceTransientException(ERROR_UPSTREAM_UNAVAILBLE, "Error communicating with upstream source", ex);
        }

        if (!result.IsSuccessStatusCode)
        {
            _logger.LogError($"Patentstyret error getting uri {target}, resultcode {result.StatusCode}");
            throw result.StatusCode switch
            {
                HttpStatusCode.NotFound => new EvidenceSourcePermanentClientException(ERROR_NOT_FOUND, "Upstream source could not find the requested entity (404)"),
                HttpStatusCode.BadRequest => new EvidenceSourcePermanentClientException(ERROR_INVALID_INPUT,  "Upstream source indicated an invalid request (400)"),
                _ => new EvidenceSourceTransientException(ERROR_UPSTREAM_UNAVAILBLE, $"Upstream source retuned an HTTP error code ({(int)result.StatusCode})")
            };
        }

        try
        {
            var body = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(body);
        }
        catch (Exception ex)
        {
            _logger.LogError("Unable to parse data returned from upstream source: {exceptionType}: {exceptionMessage}", ex.GetType().Name, ex.Message);
            throw new EvidenceSourcePermanentServerException(ERROR_UNABLE_TO_PARSE_RESPONSE, "Could not parse the data model returned from upstream source", ex);
        }
    }
}
