using System;
using System.Collections.Generic;

namespace CoreApi.Entities
{
    public class ApplicantDeclaration
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string IdorPassportNumber { get; set; }
        public int ApplicantSignatureId { get; set; }
        public int WitnessSignatureId { get; set; }
        public int ParentOrGuardianDetailsSignatureId { get; set; }
    }
}
