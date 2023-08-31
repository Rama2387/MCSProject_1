using System;
using System.Collections.Generic;

namespace MCSProject_1.Models
{
    public partial class SunClaimDetailDatum
    {
        public decimal? DecRetSystemId { get; set; }
        public string? ChClmDtlRecLocator { get; set; }
        public decimal? DecClaimNumber { get; set; }
        public string? ChControlNumber { get; set; }
        public string? TtcField1 { get; set; }
        public int? TtiField2 { get; set; }
        public decimal? TtdField3 { get; set; }
        public DateTime? TtdtField4 { get; set; }
    }
}
