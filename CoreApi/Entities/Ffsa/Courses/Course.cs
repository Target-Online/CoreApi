using System;
using System.Collections.Generic;

namespace CoreApi.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CourseDurationTypeId { get; set; }
        public int? CertificateTypeId { get; set; }
        public int? CourseDurationId { get; set; }
        public int? FeesId { get; set; }
        public int? CourseScheduleId { get; set; }
        public int? CourseSyllabusId { get; set; }
        public int? CourseTechnicalSampleId { get; set; }
    }
}
