namespace CoreApi.Entities
{
    public partial class TertiaryStudyRecord
    {
        public int Id { get; set; }
        public int? TertiaryYear1RecordId { get; set; }
        public int? TertiaryYear2RecordId { get; set; }
        public int? TertiaryYear3RecordId { get; set; }
    }
}
