
using System.Collections.Generic;


namespace Dan.Plugin.Patentstyret.Models
{
    public class ExternalModel
    {
        public object partyIdentifier { get; set; }
        public int trademarkBagCount { get; set; }
        public int patentBagCount { get; set; }
        public int designBagCount { get; set; }
        public List<TrademarkExternal> trademarkBag { get; set; }
        public List<PatentExternal> patentBag { get; set; }
        public List<DesignExternal> designBag { get; set; }
    }

    public class TrademarkExternal
    {
        public string registrationNumber { get; set; }
        public string markVerbalElementText { get; set; }
        public string applicationNumber { get; set; }
        //public string image { get; set; }
        /// public string currentStatusNo { get; set; }
        public string currentStatusEn { get; set; }
        public List<string> applicantBag { get; set; }
        public List<string> ownerBag { get; set; }
        public string caseUrl { get; set; }
    }

    public class PatentExternal
    {
        public string patentNumber { get; set; }
        public string inventionTitle { get; set; }
        public string applicationNumber { get; set; }
       // public object image { get; set; }
        //public string currentStatusNo { get; set; }
        public string currentStatusEn { get; set; }
        public List<string> applicantBag { get; set; }
        public List<string> ownerBag { get; set; }
        public string caseUrl { get; set; }
    }

    public class DesignExternal
    {
        public string registrationNumber { get; set; }
        public string[] designTitleText { get; set; }
        public string applicationNumber { get; set; }
        //public string image { get; set; }
        //public string currentStatusNo { get; set; }
        public string currentStatusEn { get; set; }
        public List<string> applicantBag { get; set; }
        public List<string> ownerBag { get; set; }
        public string caseUrl { get; set; }
    }
}
