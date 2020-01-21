using System;
using System.Collections.Generic;

namespace CoreApi.Entities
{
    public class Application
    {
        public int Id { get; set; }
        public int? StudentDetailsId { get; set; }
        public int? MarketingId { get; set; }
        public int? CourseId { get; set; }
        public int? ParentOrGuardianDetailsId { get; set; }
        public int? AcademicHistoryId { get; set; }
        public int? DeclarationId { get; set; }
    }
}
