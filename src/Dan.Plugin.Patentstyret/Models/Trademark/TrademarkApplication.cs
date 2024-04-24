using System;

namespace Dan.Plugin.Patentstyret.Models.Trademark
{
    public class TrademarkApplication
    {
        public Trademarkapplication trademarkApplication { get; set; }
    }

    public class Trademarkapplication
    {
        public string st96Version { get; set; }
        public Trademarkbag trademarkBag { get; set; }
        public string extractedFromDatabaseDate { get; set; }
        public string caseUrl { get; set; }
    }

    public class Trademarkbag
    {
        public Trademark[] trademark { get; set; }
    }

    public class Trademark
    {
        public Trademarktypechoice1 trademarkTypeChoice1 { get; set; }
        public Trademarktypechoice2 trademarkTypeChoice2 { get; set; }
        public string registrationDate { get; set; }
        public DateTime expiryDate { get; set; }
        public string markCurrentStatusCode { get; set; }
        public DateTime markCurrentStatusDate { get; set; }
        public Markrepresentation markRepresentation { get; set; }
        public Markdisclaimerbag markDisclaimerBag { get; set; }
        public bool tradeDistinctivenessIndicator { get; set; }
        public Tradedistinctivenesstext tradeDistinctivenessText { get; set; }
        public Goodsservicesbag goodsServicesBag { get; set; }
        public Applicantbag applicantBag { get; set; }
        public Representativebag representativeBag { get; set; }
        public string markFeatureDescription { get; set; }
        public Nationalcaselocation nationalCaseLocation { get; set; }
    }

    public class Trademarktypechoice1
    {
        public Applicationnumber[] applicationNumber { get; set; }
        public string registrationNumber { get; set; }
    }

    public class Applicationnumber
    {
        public string ipOfficeCode { get; set; }
        public string applicationNumberText { get; set; }
    }

    public class Trademarktypechoice2
    {
        public string applicationDate { get; set; }
    }

    public class Markrepresentation
    {
        public Markreproduction markReproduction { get; set; }
        public Markdescriptionbag markDescriptionBag { get; set; }
    }

    public class Markreproduction
    {
        public Wordmarkspecification wordMarkSpecification { get; set; }
        public Markimagebag markImageBag { get; set; }
    }

    public class Wordmarkspecification
    {
        public Markverbalelementtext markVerbalElementText { get; set; }
        public Marksignificantverbalelementtext markSignificantVerbalElementText { get; set; }
    }

    public class Markverbalelementtext
    {
        public string _ { get; set; }
    }

    public class Marksignificantverbalelementtext
    {
        public string _ { get; set; }
    }

    public class Markimagebag
    {
        public Markimage[] markImage { get; set; }
    }

    public class Markimage
    {
        public string fileName { get; set; }
        public string colourModeCategory { get; set; }
    }

    public class Markdescriptionbag
    {
        public Markdescriptionbagtypechoicesequence markDescriptionBagTypeChoiceSequence { get; set; }
    }

    public class Markdescriptionbagtypechoicesequence
    {
        public Markdescriptiontext[] markDescriptionText { get; set; }
    }

    public class Markdescriptiontext
    {
    }

    public class Markdisclaimerbag
    {
        public Markdisclaimertext[] markDisclaimerText { get; set; }
    }

    public class Markdisclaimertext
    {
        public Localizedtexttype localizedTextType { get; set; }
    }

    public class Localizedtexttype
    {
    }

    public class Tradedistinctivenesstext
    {
    }

    public class Goodsservicesbag
    {
        public Goodsservice[] goodsServices { get; set; }
    }

    public class Goodsservice
    {
        public Goodsservicesclassificationbag goodsServicesClassificationBag { get; set; }
        public Classdescriptionbag classDescriptionBag { get; set; }
    }

    public class Goodsservicesclassificationbag
    {
        public Goodsservicesclassification[] goodsServicesClassification { get; set; }
    }

    public class Goodsservicesclassification
    {
        public string classificationKindCode { get; set; }
    }

    public class Classdescriptionbag
    {
        public Classdescription[] classDescription { get; set; }
    }

    public class Classdescription
    {
        public int classNumber { get; set; }
        public Goodsservicesdescriptiontext[] goodsServicesDescriptionText { get; set; }
    }

    public class Goodsservicesdescriptiontext
    {
        public Localizedtexttype1 localizedTextType { get; set; }
    }

    public class Localizedtexttype1
    {
        public string _ { get; set; }
    }

    public class Applicantbag
    {
        public Applicant[] applicant { get; set; }
    }

    public class Applicant
    {
        public Contact[] contact { get; set; }
    }

    public class Contact
    {
        public Contacttypechoicesequence contactTypeChoiceSequence { get; set; }
    }

    public class Contacttypechoicesequence
    {
        public Name name { get; set; }
        public Postaladdressbag postalAddressBag { get; set; }
    }

    public class Name
    {
        public Entityname[] entityName { get; set; }
    }

    public class Entityname
    {
        public string[] phraseType { get; set; }
    }

    public class Postaladdressbag
    {
        public Postaladdress[] postalAddress { get; set; }
    }

    public class Postaladdress
    {
        public Postalstructuredaddress postalStructuredAddress { get; set; }
    }

    public class Postalstructuredaddress
    {
        public Addresslinetext[] addressLineText { get; set; }
        public string cityName { get; set; }
        public string countryCode { get; set; }
        public string postalCode { get; set; }
    }

    public class Addresslinetext
    {
        public string sequenceNumber { get; set; }
    }

    public class Representativebag
    {
        public Representative[] representative { get; set; }
    }

    public class Representative
    {
        public Partyidentifier partyIdentifier { get; set; }
        public Contact1 contact { get; set; }
    }

    public class Partyidentifier
    {
        public string _ { get; set; }
    }

    public class Contact1
    {
        public Contacttypechoicesequence1 contactTypeChoiceSequence { get; set; }
    }

    public class Contacttypechoicesequence1
    {
        public Name1 name { get; set; }
        public Postaladdressbag1 postalAddressBag { get; set; }
    }

    public class Name1
    {
        public Entityname1[] entityName { get; set; }
    }

    public class Entityname1
    {
        public string[] phraseType { get; set; }
    }

    public class Postaladdressbag1
    {
        public Postaladdress1[] postalAddress { get; set; }
    }

    public class Postaladdress1
    {
        public Postalstructuredaddress1 postalStructuredAddress { get; set; }
    }

    public class Postalstructuredaddress1
    {
        public Addresslinetext1[] addressLineText { get; set; }
        public string cityName { get; set; }
        public string countryCode { get; set; }
        public string postalCode { get; set; }
    }

    public class Addresslinetext1
    {
        public string sequenceNumber { get; set; }
    }

    public class Nationalcaselocation
    {
        public string lawOfficeAssignedText { get; set; }
    }
}
