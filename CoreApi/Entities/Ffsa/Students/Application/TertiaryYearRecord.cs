namespace CoreApi.Entities
{
    public class TertiaryYearRecord
    {
        public int Id { get; set; }
        public string QualificationDescription { get; set; }
        public string Institution { get; set; }
        public int? TotalCredits { get; set; }
        public int? YearsOfStudy { get; set; }
        public int? CompletedId { get; set; }
    }
}
