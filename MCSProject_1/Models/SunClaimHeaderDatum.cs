using System;
using System.Collections.Generic;

namespace MCSProject_1.Models
{
    public partial class SunClaimHeaderDatum
    {
        public decimal? DecRetSystemId { get; set; }
        public string? ChClmHdrRecLocator { get; set; }
        public decimal? DecClaimNumber { get; set; }
        public string? ChControlNumber { get; set; }
        public string? ChFedInsProgram { get; set; }
        public string? ChClaimFormType { get; set; }
        public string? ChClaimType { get; set; }
        public string? ChClaimBillType { get; set; }
        public DateTime? DtDateReceived { get; set; }
        public DateTime? DtFirstTouchDate { get; set; }
        public string? ChClaimStatus { get; set; }
        public string? ChOnHoldCode { get; set; }
        public string? ChTaxId { get; set; }
        public string? ChPlanId { get; set; }
        public string? ChPatientId { get; set; }
        public string? ChPrmSrvProviderId { get; set; }
        public string? ChPrmSrvLoctionId { get; set; }
        public string? ChPrmVendorId { get; set; }
        public string? ChPrmVendLoctionId { get; set; }
        public decimal? DecTotalCharge { get; set; }
        public decimal? DecPaidAmount { get; set; }
        public decimal? DecAllowableAmount { get; set; }
        public decimal? DecOtherInsPaid { get; set; }
        public string? ChMaritalStatus { get; set; }
        public string? ChEmploymentStatus { get; set; }
        public bool? LogCondEmployment { get; set; }
        public int? TtiField2 { get; set; }
        public decimal? TtdField3 { get; set; }
        public DateTime? TtdtField4 { get; set; }
    }
}
