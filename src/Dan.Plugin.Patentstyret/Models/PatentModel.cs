
using System;
using System.Collections.Generic;


namespace Dan.Plugin.Patentstyret.Models
{

    public class PatentModel
    {
        public string partyIdentifier { get; set; }
        public string applicantName { get; set; }
        public int trademarkBagCount { get; set; }
        public int patentBagCount { get; set; }
        public int designBagCount { get; set; }
        public List<Trademarkbag> trademarkBag { get; set; }
        public List<Patentbag> patentBag { get; set; }
        public List<Designbag> designBag { get; set; }
    }

    public class Trademarkbag
    {
        public string registrationNumber { get; set; }
        public string markVerbalElementText { get; set; }
        public string applicationNumber { get; set; }
        public string image { get; set; }
        public string currentStatusNo { get; set; }
        public string currentStatusEn { get; set; }

        public DateTime currentStatusDate { get; set; }
        public List<GenericBag> applicantBag { get; set; }
        public List<GenericBag> ownerBag { get; set; }
        public string caseUrl { get; set; }
        public DateTime expiryDate { get; set; }
    }

    public class Patentbag
    {
        public string patentNumber { get; set; }
        public string inventionTitle { get; set; }
        public string applicationNumber { get; set; }
        public object image { get; set; }
        public string currentStatusNo { get; set; }

        public DateTime currentStatusDate { get; set; }

        public string currentStatusEn { get; set; }
        public List<GenericBag> applicantBag { get; set; }
        public List<GenericBag> ownerBag { get; set; }
        public string caseUrl { get; set; }
        public DateTime expiryDate { get; set; }
    }

    public class Designbag
    {
        public string registrationNumber { get; set; }
        public string[] designTitleText { get; set; }
        public string applicationNumber { get; set; }
        public string image { get; set; }
        public string currentStatusNo { get; set; }
        public string currentStatusEn { get; set; }

        public DateTime currentStatusDate { get; set; }
        public List<GenericBag> applicantBag { get; set; }
        public List<GenericBag> ownerBag { get; set; }
        public string caseUrl { get; set; }

        public DateTime expiryDate { get; set; }
    }

    public class GenericBag
    {
        public string name { get; set; }
        public string companyNumber { get; set; }
    }
}
