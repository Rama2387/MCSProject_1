using System;
using System.Collections.Generic;

namespace MCSProject_1.Models
{
    public partial class SunClaimAuthorizeDatum
    {
        public decimal? DecRetSystemId { get; set; }
        public string? ChClmAuthRecLocator { get; set; }
        public decimal? DecClaimNumber { get; set; }
        public string? ChControlNumber { get; set; }
        public int? IntAuthLine { get; set; }
        public string? ChAuthRequestId { get; set; }
        public string? ChAuthType { get; set; }
        public string? ChAuthDesc { get; set; }
        public string? ChAuthStatus { get; set; }
        public string? ChAuthSrvProvId { get; set; }
        public string? ChAuthSrvProvider { get; set; }
        public string? ChAuthSrvFacilId { get; set; }
        public string? ChAuthSrvFacility { get; set; }
        public string? ChAuthMatchLevel { get; set; }
        public DateTime? DtAuthStartDate { get; set; }
        public DateTime? DtAuthEndDate { get; set; }
        public DateTime? DtAuthCreateDate { get; set; }
        public DateTime? DtAuthModifyDate { get; set; }
        public string? ChAuthNotes { get; set; }
    }
}
