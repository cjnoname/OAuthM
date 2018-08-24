using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblEntitlementUsage
    {
        public int EntitlementUsageId { get; set; }
        public int EntitlementPasswordId { get; set; }
        public int? ProtectionGroupId { get; set; }
        public int? EntitlementId { get; set; }
        public int? CustomerId { get; set; }
        public string EventCode { get; set; }
        public string PriceTypeCode { get; set; }
        public int? Admits { get; set; }
        public int? TransactionDate { get; set; }
        public int? TransactionNumber { get; set; }
        public string NativeBarcode { get; set; }
        public string ForeignEventCode { get; set; }
        public bool IsAttendance { get; set; }
        public bool IsDisabled { get; set; }
        public int? DisabledReasonId { get; set; }
        public bool UsageCancelled { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public string PaxmasterEventCode { get; set; }
        public string Seating { get; set; }
        public string SellerCode { get; set; }
        public int? BasketLeaderTransactionDate { get; set; }
        public int? BasketLeaderTransactionNumber { get; set; }
        public int? SeatCategory { get; set; }
        public string AfileName { get; set; }
        public int? OriginAccountNumber { get; set; }
        public DateTime? TransactionDateTime { get; set; }
        public string DeliveryMethod { get; set; }
        public string DistributionChannelCode { get; set; }
        public string SourcePriceType { get; set; }
        public decimal? TicketCost { get; set; }
        public decimal? TicketGst { get; set; }
        public string OfferCode { get; set; }

        public TblCustomer Customer { get; set; }
        public TblEntitlementDisabledReason DisabledReason { get; set; }
        public TblDistributionChannel DistributionChannelCodeNavigation { get; set; }
        public TblEntitlement Entitlement { get; set; }
        public TblEntitlementPassword EntitlementPassword { get; set; }
        public TblProtectionGroup ProtectionGroup { get; set; }
    }
}
