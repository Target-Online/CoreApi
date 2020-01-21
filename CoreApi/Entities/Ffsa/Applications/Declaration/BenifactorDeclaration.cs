using System;
using System.Collections.Generic;

namespace CoreApi.Entities
{
    public class BenifactorDeclaration
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int SignatureId { get; set; }
        public string Idnumber { get; set; }
    }
}
