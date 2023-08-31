using System;
using System.Collections.Generic;

namespace MCSProject_1.Models
{
    public partial class SunClaimDatesDatum
    {
        public decimal DecRetSystemId { get; set; }
        public string? ChClmHdrRecLocator { get; set; }
        public decimal? DecClaimNumber { get; set; }
        public string? ChControlNumber { get; set; }
        public string? ChDateTpye { get; set; }
        public bool? LogDateRange { get; set; }
        public int? IntDateIndex { get; set; }
        public string? ChDateEvent { get; set; }
        public string? ChDtEvntDesc { get; set; }
        public DateTime? DtStartDate { get; set; }
        public string? ChStartTime { get; set; }
        public DateTime? DtEndDate { get; set; }
        public string? ChEndTime { get; set; }
        public string? ChDtEvntUser { get; set; }
        public string? ChDtEvntNote { get; set; }
    }
}
