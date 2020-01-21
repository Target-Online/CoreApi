using System;
using System.Collections.Generic;

namespace CoreApi.Entities
{
    public class HighSchoolRecord
    {
        public int Id { get; set; }
        public string LasHighSchoolAttended { get; set; }
        public int? Year { get; set; }
        public string Country { get; set; }
        public string Aggregate { get; set; }
        public int? HighSchoolSeniorCertificateId { get; set; }
    }
}
