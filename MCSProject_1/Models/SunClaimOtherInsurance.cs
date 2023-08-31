using System;
using System.Collections.Generic;

namespace MCSProject_1.Models
{
    public partial class SunClaimOtherInsurance
    {
        public decimal? DecRetSystemId { get; set; }
        public string? ChClmHdrlRecLocator { get; set; }
        public decimal? DecClaimNumber { get; set; }
        public string? ChControlNumber { get; set; }
        public int? IntOthrInsListPos { get; set; }
        public string? ChOthrInsPlan { get; set; }
        public string? ChOthrInsPolicy { get; set; }
        public string? ChOthrInsEmployer { get; set; }
        public string? ChOthrInsLastName { get; set; }
        public string? ChOthrInsFirstName { get; set; }
        public string? ChOthrInsMiddleName { get; set; }
        public string? ChOthrInsDisplayName { get; set; }
        public DateTime? DtOthrInsDob { get; set; }
        public string? ChOthrInsGender { get; set; }
        public string? ChOthrInsClaimType { get; set; }
        public decimal? DecOthrInsPaidAmt { get; set; }
        public decimal? DecOthrInsEstAmtDue { get; set; }
        public decimal? DecOthrInsAllowedAmt { get; set; }
        public decimal? DecOthrInsMaximumAmt { get; set; }
    }
}
