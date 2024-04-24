using System;

namespace Dan.Plugin.Patentstyret.Models.Patent
{
    public class PatentApplication
    {
        public Bibliographicdata bibliographicData { get; set; }
    }

    public class Bibliographicdata
    {
        public string st96Version { get; set; }
        public Applicationidentification applicationIdentification { get; set; }
        public Patentgrantidentification patentGrantIdentification { get; set; }
        public Priorityclaimbag priorityClaimBag { get; set; }
        public Patentclassificationbag patentClassificationBag { get; set; }
        public Inventiontitlebag inventionTitleBag { get; set; }
        public Partybag partyBag { get; set; }
        public DateTime maximumDurationDate { get; set; }
        public string extractedFromDatabaseDate { get; set; }
        public string caseUrl { get; set; }
    }

    public class Applicationidentification
    {
        public string ipOfficeCode { get; set; }
        public Applicationnumber applicationNumber { get; set; }
        public string applicationFilingCategory { get; set; }
        public string filingDate { get; set; }
    }

    public class Applicationnumber
    {
        public string applicationNumberText { get; set; }
    }

    public class Patentgrantidentification
    {
        public string ipOfficeCode { get; set; }
        public string patentNumber { get; set; }
        public string grantDate { get; set; }
    }

    public class Priorityclaimbag
    {
    }

    public class Patentclassificationbag
    {
        public Ipcrclassificationbag ipcrClassificationBag { get; set; }
    }

    public class Ipcrclassificationbag
    {
        public Ipcrclassification[] ipcrClassification { get; set; }
    }

    public class Ipcrclassification
    {
        public string patentClassificationText { get; set; }
    }

    public class Inventiontitlebag
    {
        public Inventiontitle[] inventionTitle { get; set; }
    }

    public class Inventiontitle
    {
        public Phrasetype phraseType { get; set; }
    }

    public class Phrasetype
    {
        public string _ { get; set; }
    }

    public class Partybag
    {
        public Applicantbag applicantBag { get; set; }
        public Inventorbag inventorBag { get; set; }
        public Ownerbag[] ownerBag { get; set; }
        public Registeredpractitionerbag registeredPractitionerBag { get; set; }
    }

    public class Applicantbag
    {
        public Applicant[] applicant { get; set; }
    }

    public class Applicant
    {
        public Partyidentifier partyIdentifier { get; set; }
        public Contact contact { get; set; }
    }

    public class Partyidentifier
    {
        public string _ { get; set; }
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
        public Entityname entityName { get; set; }
    }

    public class Entityname
    {
        public Phrasetype1 phraseType { get; set; }
    }

    public class Phrasetype1
    {
        public string _ { get; set; }
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

    public class Inventorbag
    {
        public Inventor[] inventor { get; set; }
    }

    public class Inventor
    {
        public Partyidentifier1 partyIdentifier { get; set; }
        public Contact1 contact { get; set; }
    }

    public class Partyidentifier1
    {
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
        public Phrasetype2 phraseType { get; set; }
    }

    public class Phrasetype2
    {
        public string _ { get; set; }
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

    public class Registeredpractitionerbag
    {
        public Registeredpractitioner[] registeredPractitioner { get; set; }
    }

    public class Registeredpractitioner
    {
        public string sequenceNumber { get; set; }
        public string registeredPractitionerCategory { get; set; }
        public Contact2 contact { get; set; }
    }

    public class Contact2
    {
        public Contacttypechoicesequence2 contactTypeChoiceSequence { get; set; }
    }

    public class Contacttypechoicesequence2
    {
        public Name2 name { get; set; }
        public Postaladdressbag2 postalAddressBag { get; set; }
    }

    public class Name2
    {
        public Entityname2 entityName { get; set; }
    }

    public class Entityname2
    {
        public Phrasetype3 phraseType { get; set; }
    }

    public class Phrasetype3
    {
        public string _ { get; set; }
    }

    public class Postaladdressbag2
    {
        public Postaladdress2[] postalAddress { get; set; }
    }

    public class Postaladdress2
    {
        public Postalstructuredaddress2 postalStructuredAddress { get; set; }
    }

    public class Postalstructuredaddress2
    {
        public Addresslinetext2[] addressLineText { get; set; }
        public string cityName { get; set; }
        public string countryCode { get; set; }
        public string postalCode { get; set; }
    }

    public class Addresslinetext2
    {
        public string sequenceNumber { get; set; }
    }

    public class Ownerbag
    {
        public Owner[] owner { get; set; }
    }

    public class Owner
    {
        public Partyidentifier2 partyIdentifier { get; set; }
        public Contact3 contact { get; set; }
    }

    public class Partyidentifier2
    {
        public string _ { get; set; }
    }

    public class Contact3
    {
        public Contacttypechoicesequence3 contactTypeChoiceSequence { get; set; }
    }

    public class Contacttypechoicesequence3
    {
        public Name3 name { get; set; }
        public Postaladdressbag3 postalAddressBag { get; set; }
    }

    public class Name3
    {
        public Entityname3 entityName { get; set; }
    }

    public class Entityname3
    {
        public Phrasetype4 phraseType { get; set; }
    }

    public class Phrasetype4
    {
        public string _ { get; set; }
    }

    public class Postaladdressbag3
    {
        public Postaladdress3[] postalAddress { get; set; }
    }

    public class Postaladdress3
    {
        public Postalstructuredaddress3 postalStructuredAddress { get; set; }
    }

    public class Postalstructuredaddress3
    {
        public Addresslinetext3[] addressLineText { get; set; }
        public string cityName { get; set; }
        public string countryCode { get; set; }
        public string postalCode { get; set; }
    }

    public class Addresslinetext3
    {
        public string sequenceNumber { get; set; }
    }
}
