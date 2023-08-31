using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MCSProject_1.Models
{
    public partial class MCS_DEVContext : DbContext
    {
        public MCS_DEVContext()
        {
        }

        public MCS_DEVContext(DbContextOptions<MCS_DEVContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SunClaimAuthorizeDatum> SunClaimAuthorizeData { get; set; } = null!;
        public virtual DbSet<SunClaimDatesDatum> SunClaimDatesData { get; set; } = null!;
        public virtual DbSet<SunClaimDetailDatum> SunClaimDetailData { get; set; } = null!;
        public virtual DbSet<SunClaimEntityRef> SunClaimEntityRefs { get; set; } = null!;
        public virtual DbSet<SunClaimHeaderDatum> SunClaimHeaderData { get; set; } = null!;
        public virtual DbSet<SunClaimMedCodesDatum> SunClaimMedCodesData { get; set; } = null!;
        public virtual DbSet<SunClaimOtherInsurance> SunClaimOtherInsurances { get; set; } = null!;
        public virtual DbSet<SunClaimTransportDatum> SunClaimTransportData { get; set; } = null!;
        public virtual DbSet<SunSystemCodeDescription> SunSystemCodeDescriptions { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=MCSConString");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SunClaimAuthorizeDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sunClaimAuthorizeData");

                entity.Property(e => e.ChAuthDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chAuthDesc");

                entity.Property(e => e.ChAuthMatchLevel)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chAuthMatchLevel");

                entity.Property(e => e.ChAuthNotes)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chAuthNotes");

                entity.Property(e => e.ChAuthRequestId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chAuthRequestID");

                entity.Property(e => e.ChAuthSrvFacilId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chAuthSrvFacilID");

                entity.Property(e => e.ChAuthSrvFacility)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chAuthSrvFacility");

                entity.Property(e => e.ChAuthSrvProvId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chAuthSrvProvID");

                entity.Property(e => e.ChAuthSrvProvider)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chAuthSrvProvider");

                entity.Property(e => e.ChAuthStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chAuthStatus");

                entity.Property(e => e.ChAuthType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chAuthType");

                entity.Property(e => e.ChClmAuthRecLocator)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chClmAuthRecLocator");

                entity.Property(e => e.ChControlNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chControlNumber");

                entity.Property(e => e.DecClaimNumber)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("decClaimNumber");

                entity.Property(e => e.DecRetSystemId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("decRetSystemID");

                entity.Property(e => e.DtAuthCreateDate)
                    .HasColumnType("date")
                    .HasColumnName("dtAuthCreateDate");

                entity.Property(e => e.DtAuthEndDate)
                    .HasColumnType("date")
                    .HasColumnName("dtAuthEndDate");

                entity.Property(e => e.DtAuthModifyDate)
                    .HasColumnType("date")
                    .HasColumnName("dtAuthModifyDate");

                entity.Property(e => e.DtAuthStartDate)
                    .HasColumnType("date")
                    .HasColumnName("dtAuthStartDate");

                entity.Property(e => e.IntAuthLine).HasColumnName("intAuthLine");
            });

            modelBuilder.Entity<SunClaimDatesDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sunClaimDatesData");

                entity.Property(e => e.ChClmHdrRecLocator)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chClmHdrRecLocator");

                entity.Property(e => e.ChControlNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chControlNumber");

                entity.Property(e => e.ChDateEvent)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chDateEvent");

                entity.Property(e => e.ChDateTpye)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chDateTpye");

                entity.Property(e => e.ChDtEvntDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chDtEvntDesc");

                entity.Property(e => e.ChDtEvntNote)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chDtEvntNote");

                entity.Property(e => e.ChDtEvntUser)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chDtEvntUser");

                entity.Property(e => e.ChEndTime)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chEndTime");

                entity.Property(e => e.ChStartTime)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chStartTime");

                entity.Property(e => e.DecClaimNumber)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("decClaimNumber");

                entity.Property(e => e.DecRetSystemId)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("decRetSystemID");

                entity.Property(e => e.DtEndDate)
                    .HasColumnType("date")
                    .HasColumnName("dtEndDate");

                entity.Property(e => e.DtStartDate)
                    .HasColumnType("date")
                    .HasColumnName("dtStartDate");

                entity.Property(e => e.IntDateIndex).HasColumnName("intDateIndex");

                entity.Property(e => e.LogDateRange).HasColumnName("logDateRange");
            });

            modelBuilder.Entity<SunClaimDetailDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sunClaimDetailData");

                entity.Property(e => e.ChClmDtlRecLocator)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chClmDtlRecLocator");

                entity.Property(e => e.ChControlNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chControlNumber");

                entity.Property(e => e.DecClaimNumber)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("decClaimNumber");

                entity.Property(e => e.DecRetSystemId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("decRetSystemID");

                entity.Property(e => e.TtcField1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ttcField1");

                entity.Property(e => e.TtdField3)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ttdField3");

                entity.Property(e => e.TtdtField4)
                    .HasColumnType("date")
                    .HasColumnName("ttdtField4");

                entity.Property(e => e.TtiField2).HasColumnName("ttiField2");
            });

            modelBuilder.Entity<SunClaimEntityRef>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sunClaimEntityRef");

                entity.Property(e => e.ChClmHdrRecLocator)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chClmHdrRecLocator");

                entity.Property(e => e.ChControlNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chControlNumber");

                entity.Property(e => e.ChEntAddrCity)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chEntAddrCity");

                entity.Property(e => e.ChEntAddrLine1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chEntAddrLine1");

                entity.Property(e => e.ChEntAddrLine2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chEntAddrLine2");

                entity.Property(e => e.ChEntAddrLine3)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chEntAddrLine3");

                entity.Property(e => e.ChEntAddrPhone)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chEntAddrPhone");

                entity.Property(e => e.ChEntAddrState)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chEntAddrState");

                entity.Property(e => e.ChEntAddrZip)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chEntAddrZip");

                entity.Property(e => e.ChEntCellPhone)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chEntCellPhone");

                entity.Property(e => e.ChEntDisplayName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chEntDisplayName");

                entity.Property(e => e.ChEntEmailAdd)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chEntEmailAdd");

                entity.Property(e => e.ChEntExtraData1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chEntExtraData1");

                entity.Property(e => e.ChEntExtraData2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chEntExtraData2");

                entity.Property(e => e.ChEntFirstName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chEntFirstName");

                entity.Property(e => e.ChEntLastName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chEntLastName");

                entity.Property(e => e.ChEntMiddleName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chEntMiddleName");

                entity.Property(e => e.ChEntNotes)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chEntNotes");

                entity.Property(e => e.ChEntNpi)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chEntNPI");

                entity.Property(e => e.ChEntPrefix)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chEntPrefix");

                entity.Property(e => e.ChEntPrmKeyValue2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chEntPrmKeyValue2");

                entity.Property(e => e.ChEntRefRecLocator)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chEntRefRecLocator");

                entity.Property(e => e.ChEntSecKeyValue2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chEntSecKeyValue2");

                entity.Property(e => e.ChEntSuffix)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chEntSuffix");

                entity.Property(e => e.ChEntityType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chEntityType");

                entity.Property(e => e.ChFacilityType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chFacilityType");

                entity.Property(e => e.ChSunRefTable)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chSunRefTable");

                entity.Property(e => e.DecClaimNumber)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("decClaimNumber");

                entity.Property(e => e.DecRetSystemId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("decRetSystemID");

                entity.Property(e => e.IntEntSortOrder).HasColumnName("intEntSortOrder");

                entity.Property(e => e.LogEntAperson).HasColumnName("logEntAPerson");
            });

            modelBuilder.Entity<SunClaimHeaderDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sunClaimHeaderData");

                entity.Property(e => e.ChClaimBillType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chClaimBillType");

                entity.Property(e => e.ChClaimFormType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("chClaimFormType");

                entity.Property(e => e.ChClaimStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chClaimStatus");

                entity.Property(e => e.ChClaimType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chClaimType");

                entity.Property(e => e.ChClmHdrRecLocator)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chClmHdrRecLocator");

                entity.Property(e => e.ChControlNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chControlNumber");

                entity.Property(e => e.ChEmploymentStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chEmploymentStatus");

                entity.Property(e => e.ChFedInsProgram)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("chFedInsProgram");

                entity.Property(e => e.ChMaritalStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chMaritalStatus");

                entity.Property(e => e.ChOnHoldCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chOnHoldCode");

                entity.Property(e => e.ChPatientId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chPatientID");

                entity.Property(e => e.ChPlanId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chPlanID");

                entity.Property(e => e.ChPrmSrvLoctionId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chPrmSrvLoctionID");

                entity.Property(e => e.ChPrmSrvProviderId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chPrmSrvProviderID");

                entity.Property(e => e.ChPrmVendLoctionId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chPrmVendLoctionID");

                entity.Property(e => e.ChPrmVendorId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chPrmVendorID");

                entity.Property(e => e.ChTaxId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chTaxID");

                entity.Property(e => e.DecAllowableAmount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("decAllowableAmount");

                entity.Property(e => e.DecClaimNumber)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("decClaimNumber");

                entity.Property(e => e.DecOtherInsPaid)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("decOtherInsPaid");

                entity.Property(e => e.DecPaidAmount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("decPaidAmount");

                entity.Property(e => e.DecRetSystemId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("decRetSystemID");

                entity.Property(e => e.DecTotalCharge)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("decTotalCharge");

                entity.Property(e => e.DtDateReceived)
                    .HasColumnType("date")
                    .HasColumnName("dtDateReceived");

                entity.Property(e => e.DtFirstTouchDate)
                    .HasColumnType("date")
                    .HasColumnName("dtFirstTouchDate");

                entity.Property(e => e.LogCondEmployment).HasColumnName("logCondEmployment");

                entity.Property(e => e.TtdField3)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ttdField3");

                entity.Property(e => e.TtdtField4)
                    .HasColumnType("date")
                    .HasColumnName("ttdtField4");

                entity.Property(e => e.TtiField2).HasColumnName("ttiField2");
            });

            modelBuilder.Entity<SunClaimMedCodesDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sunClaimMedCodesData");

                entity.Property(e => e.ChClmDtlRecLocator)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chClmDtlRecLocator");

                entity.Property(e => e.ChControlNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chControlNumber");

                entity.Property(e => e.ChMedCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chMedCode");

                entity.Property(e => e.ChMedCodeType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chMedCodeType");

                entity.Property(e => e.ChMedDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chMedDesc");

                entity.Property(e => e.ChMedPoa)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chMedPOA");

                entity.Property(e => e.ChMedQualifier)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chMedQualifier");

                entity.Property(e => e.DecClaimNumber)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("decClaimNumber");

                entity.Property(e => e.DecRetSystemId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("decRetSystemID");

                entity.Property(e => e.IntCodePos).HasColumnName("intCodePos");
            });

            modelBuilder.Entity<SunClaimOtherInsurance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sunClaimOtherInsurance");

                entity.Property(e => e.ChClmHdrlRecLocator)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chClmHdrlRecLocator");

                entity.Property(e => e.ChControlNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chControlNumber");

                entity.Property(e => e.ChOthrInsClaimType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chOthrInsClaimType");

                entity.Property(e => e.ChOthrInsDisplayName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chOthrInsDisplayName");

                entity.Property(e => e.ChOthrInsEmployer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chOthrInsEmployer");

                entity.Property(e => e.ChOthrInsFirstName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chOthrInsFirstName");

                entity.Property(e => e.ChOthrInsGender)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chOthrInsGender");

                entity.Property(e => e.ChOthrInsLastName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chOthrInsLastName");

                entity.Property(e => e.ChOthrInsMiddleName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chOthrInsMiddleName");

                entity.Property(e => e.ChOthrInsPlan)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chOthrInsPlan");

                entity.Property(e => e.ChOthrInsPolicy)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chOthrInsPolicy");

                entity.Property(e => e.DecClaimNumber)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("decClaimNumber");

                entity.Property(e => e.DecOthrInsAllowedAmt)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("decOthrInsAllowedAmt");

                entity.Property(e => e.DecOthrInsEstAmtDue)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("decOthrInsEstAmtDue");

                entity.Property(e => e.DecOthrInsMaximumAmt)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("decOthrInsMaximumAmt");

                entity.Property(e => e.DecOthrInsPaidAmt)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("decOthrInsPaidAmt");

                entity.Property(e => e.DecRetSystemId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("decRetSystemID");

                entity.Property(e => e.DtOthrInsDob)
                    .HasColumnType("date")
                    .HasColumnName("dtOthrInsDOB");

                entity.Property(e => e.IntOthrInsListPos).HasColumnName("intOthrInsListPos");
            });

            modelBuilder.Entity<SunClaimTransportDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sunClaimTransportData");

                entity.Property(e => e.ChClmImgHdRecLocator)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chClmImgHdRecLocator");

                entity.Property(e => e.ChControlNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chControlNumber");

                entity.Property(e => e.ChTrnspAddrCity)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chTrnspAddrCity");

                entity.Property(e => e.ChTrnspAddrLine1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chTrnspAddrLine1");

                entity.Property(e => e.ChTrnspAddrLine2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chTrnspAddrLine2");

                entity.Property(e => e.ChTrnspAddrLine3)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chTrnspAddrLine3");

                entity.Property(e => e.ChTrnspAddrState)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chTrnspAddrState");

                entity.Property(e => e.ChTrnspAddrZip)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chTrnspAddrZip");

                entity.Property(e => e.ChTrnspCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chTrnspCode");

                entity.Property(e => e.ChTrnspDstMeasure)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chTrnspDstMeasure");

                entity.Property(e => e.ChTrnspEndTime)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chTrnspEndTime");

                entity.Property(e => e.ChTrnspEvent)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chTrnspEvent");

                entity.Property(e => e.ChTrnspLicenseNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chTrnspLicenseNumber");

                entity.Property(e => e.ChTrnspNote)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chTrnspNote");

                entity.Property(e => e.ChTrnspPickOrDrop)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chTrnspPickOrDrop");

                entity.Property(e => e.ChTrnspPntStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chTrnspPntStatus");

                entity.Property(e => e.ChTrnspServiceName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chTrnspServiceName");

                entity.Property(e => e.ChTrnspStartTime)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chTrnspStartTime");

                entity.Property(e => e.ChTrnspStateCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chTrnspStateCode");

                entity.Property(e => e.DecClaimNumber)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("decClaimNumber");

                entity.Property(e => e.DecRetSystemId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("decRetSystemID");

                entity.Property(e => e.DecTrnspDistance)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("decTrnspDistance");

                entity.Property(e => e.DecTrnspPntWeight)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("decTrnspPntWeight");

                entity.Property(e => e.DtTrnspEndDate)
                    .HasColumnType("date")
                    .HasColumnName("dtTrnspEndDate");

                entity.Property(e => e.DtTrnspStartDate)
                    .HasColumnType("date")
                    .HasColumnName("dtTrnspStartDate");
            });

            modelBuilder.Entity<SunSystemCodeDescription>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sunSystemCodeDescriptions");

                entity.Property(e => e.ChCodeDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chCodeDescription");

                entity.Property(e => e.ChCodePurpose)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chCodePurpose");

                entity.Property(e => e.ChCodeType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chCodeType");

                entity.Property(e => e.ChCodeValue)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("chCodeValue");

                entity.Property(e => e.IntCodeOrder).HasColumnName("intCodeOrder");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
