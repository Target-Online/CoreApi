namespace CoreApi.Entities
{
    public class StudentDetails
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string FirstNames { get; set; }
        public string Idnumber { get; set; }
        public int? ResidentialAddressId { get; set; }
        public int? PostalAddressId { get; set; }
        public string TelWork { get; set; }
        public string TelHome { get; set; }
        public string Cell { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Race { get; set; }
        public string OtherRace { get; set; }
        public string Gander { get; set; }
        public string DisabilitiesOrMedicalConditionAffectStudies { get; set; }
        public string NatureOfDisabilityOrMedicalCondition { get; set; }
    }
}
