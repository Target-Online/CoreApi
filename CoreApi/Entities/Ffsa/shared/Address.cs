using System;
using System.Collections.Generic;

namespace CoreApi.Entities
{
    public partial class Address
    {
        public int Id { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public int? PostalCode { get; set; }
    }
}
