using System;
using System.Collections.Generic;

namespace CoreApi.Entities
{
    public class ParentOrGuardianDetails
    {
        public int Id { get; set; }
        public string Relationship { get; set; }
        public string Idnumber { get; set; }
        public int? ResidentialAddressId { get; set; }
        public int? PostalAddressId { get; set; }
        public string TelWork { get; set; }
        public string TelHome { get; set; }
        public string Cell { get; set; }
        public string Email { get; set; }
    }
}
