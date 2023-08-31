using System;
using System.Collections.Generic;

namespace MCSProject_1.Models
{
    public partial class SunClaimMedCodesDatum
    {
        public decimal? DecRetSystemId { get; set; }
        public string? ChClmDtlRecLocator { get; set; }
        public decimal? DecClaimNumber { get; set; }
        public string? ChControlNumber { get; set; }
        public string? ChMedCodeType { get; set; }
        public int? IntCodePos { get; set; }
        public string? ChMedCode { get; set; }
        public string? ChMedDesc { get; set; }
        public string? ChMedQualifier { get; set; }
        public string? ChMedPoa { get; set; }
    }
}
