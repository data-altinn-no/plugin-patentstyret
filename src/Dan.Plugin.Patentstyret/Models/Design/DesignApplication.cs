

using System;

namespace Dan.Plugin.Patentstyret.Models.Design
{
    public class DesignApplication
    {
        public Designapplication designApplication { get; set; }
    }

    public class Designapplication
    {
        public string st96Version { get; set; }
        public string registrationOfficeCode { get; set; }
        public Applicationnumber applicationNumber { get; set; }
        public Designbag designBag { get; set; }
        public Applicantbag1 applicantBag { get; set; }
        public Representativebag representativeBag { get; set; }
        public string applicationDate { get; set; }
        public string extractedFromDatabaseDate { get; set; }
        public string caseUrl { get; set; }
    }

    public class Applicationnumber
    {
        public string ipOfficeCode { get; set; }
        public string applicationNumberText { get; set; }
    }

    public class Designbag
    {
        public Design[] design { get; set; }
    }

    public class Design
    {
        public Designidentifier designIdentifier { get; set; }
        public string registrationNumber { get; set; }
        public string registrationDate { get; set; }
        public Designtitletext designTitleText { get; set; }
        public DateTime expiryDate { get; set; }
        public string designCurrentStatusCategory { get; set; }
        public DateTime designCurrentStatusDate { get; set; }
        public Designrepresentationbag designRepresentationBag { get; set; }
        public Designclassificationbag designClassificationBag { get; set; }
        public Prioritybag priorityBag { get; set; }
        public Applicantbag applicantBag { get; set; }
        public Designerbag designerBag { get; set; }
    }

    public class Designidentifier
    {
        public string _ { get; set; }
    }

    public class Designtitletext
    {
        public string _ { get; set; }
    }

    public class Designrepresentationbag
    {
        public Designrepresentation[] designRepresentation { get; set; }
    }

    public class Designrepresentation
    {
        public Viewbag viewBag { get; set; }
    }

    public class Viewbag
    {
        public View[] view { get; set; }
    }

    public class View
    {
        public string fileName { get; set; }
        public string thumbnailFileName { get; set; }
        public Viewidentifier viewIdentifier { get; set; }
        public string viewFileFormatCategory { get; set; }
    }

    public class Viewidentifier
    {
        public string _ { get; set; }
    }

    public class Designclassificationbag
    {
        public Locarnoclassificationbag[] locarnoClassificationBag { get; set; }
    }

    public class Locarnoclassificationbag
    {
        public string locarnoClassificationEdition { get; set; }
        public Locarnoclassification locarnoClassification { get; set; }
    }

    public class Locarnoclassification
    {
        public string locarnoClass { get; set; }
        public Locarnoclassdescriptiontext locarnoClassDescriptionText { get; set; }
    }

    public class Locarnoclassdescriptiontext
    {
        public Localizedtexttype localizedTextType { get; set; }
    }

    public class Localizedtexttype
    {
        public string _ { get; set; }
        public string languageCode { get; set; }
    }

    public class Prioritybag
    {
    }

    public class Applicantbag
    {
        public Applicant[] applicant { get; set; }
    }

    public class Applicant
    {
        public Partyidentifier partyIdentifier { get; set; }
    }

    public class Partyidentifier
    {
        public string _ { get; set; }
    }

    public class Designerbag
    {
        public Designer[] designer { get; set; }
    }

    public class Designer
    {
        public Partyidentifier1 partyIdentifier { get; set; }
    }

    public class Partyidentifier1
    {
        public string _ { get; set; }
    }

    public class Applicantbag1
    {
        public Applicant1[] applicant { get; set; }
    }

    public class Applicant1
    {
        public Partyidentifier2 partyIdentifier { get; set; }
    }

    public class Partyidentifier2
    {
        public string _ { get; set; }
    }

    public class Representativebag
    {
        public Representative[] representative { get; set; }
    }

    public class Representative
    {
        public Partyidentifier3 partyIdentifier { get; set; }
    }

    public class Partyidentifier3
    {
        public string _ { get; set; }
    }
}
