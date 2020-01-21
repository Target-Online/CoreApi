using System;
using System.Collections.Generic;

namespace CoreApi.Entities
{
    public class Marketing
    {
        public int Id { get; set; }
        public int MarketingMediaId { get; set; }
        public int? GuidanceConsellorId { get; set; }
    }
}
