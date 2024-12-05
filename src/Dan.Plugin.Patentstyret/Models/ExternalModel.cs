
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Dan.Plugin.Patentstyret.Models
{
    [JsonObject("patentstyret")]
    public class Patents
    {
        [JsonProperty("partyIdentifier")]
        public string PartyIdentifier { get; set; }

        [JsonProperty("immaterialRights")]
        public List<ExternalModel> PatentsList { get; set; }
    }



    [JsonObject("varemerke")]
    public class ExternalModel
    {
        [JsonProperty("immaterialRightType")]
        public PatentType Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("patentNumber")]
        public string PatentNumber { get; set; }

        [JsonProperty("applicationNumber")]
        public string ApplicationNumber { get; set; }

        [JsonProperty("designImage", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string DesignImage { get; set; }

        [JsonProperty("currentStatus")]
        public string CurrentStatus { get; set; }

        [JsonProperty("currentStatusChanged")]
        public DateTime CurrentStatusChanged { get; set; }

        [JsonProperty("expirationDate")]
        public DateTime ExpirationDate { get; set; }

        [JsonProperty("caseUrl")]
        public string CaseUrl { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PatentType
    {
        [EnumMember(Value = "design")]
        Design,
        [EnumMember(Value = "varemerke")]
        Trademark,
        [EnumMember(Value = "patent")]
        Patent
    }
}
