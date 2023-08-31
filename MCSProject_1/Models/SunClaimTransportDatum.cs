using System;
using System.Collections.Generic;

namespace MCSProject_1.Models
{
    public partial class SunClaimTransportDatum
    {
        public decimal? DecRetSystemId { get; set; }
        public string? ChClmImgHdRecLocator { get; set; }
        public decimal? DecClaimNumber { get; set; }
        public string? ChControlNumber { get; set; }
        public string? ChTrnspCode { get; set; }
        public string? ChTrnspEvent { get; set; }
        public string? ChTrnspPickOrDrop { get; set; }
        public DateTime? DtTrnspStartDate { get; set; }
        public string? ChTrnspStartTime { get; set; }
        public DateTime? DtTrnspEndDate { get; set; }
        public string? ChTrnspEndTime { get; set; }
        public decimal? DecTrnspDistance { get; set; }
        public string? ChTrnspDstMeasure { get; set; }
        public decimal? DecTrnspPntWeight { get; set; }
        public string? ChTrnspPntStatus { get; set; }
        public string? ChTrnspStateCode { get; set; }
        public string? ChTrnspServiceName { get; set; }
        public string? ChTrnspLicenseNumber { get; set; }
        public string? ChTrnspAddrLine1 { get; set; }
        public string? ChTrnspAddrLine2 { get; set; }
        public string? ChTrnspAddrLine3 { get; set; }
        public string? ChTrnspAddrCity { get; set; }
        public string? ChTrnspAddrState { get; set; }
        public string? ChTrnspAddrZip { get; set; }
        public string? ChTrnspNote { get; set; }
    }
}
