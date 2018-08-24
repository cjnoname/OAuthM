using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblBillingRecord
    {
        public int BillingId { get; set; }
        public int OrderId { get; set; }
        public int? ShippingRecordId { get; set; }
        public int? ReplacedBillingRecordId { get; set; }
        public int? ReplacementBillingId { get; set; }
        public string AuthorisationStatusId { get; set; }
        public int? InventoryTransactionId { get; set; }
        public int? BillingRecordCount { get; set; }
        public decimal? BillingAmount { get; set; }
        public string CreditCardName { get; set; }
        public string PayType { get; set; }
        public DateTime? LastTimeUsed { get; set; }
        public int? HowPaid { get; set; }
        public int? HowPaidCchp { get; set; }
        public string Comment { get; set; }
        public string AuthorisationId { get; set; }
        public int? XpiryMonthYear { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAreaCode { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerPostCode { get; set; }
        public string Eftreference { get; set; }
        public string MerchantName { get; set; }
        public bool? IsCreditAmount { get; set; }
        public string Seller { get; set; }
        public decimal? PayTypeFee { get; set; }
        public int? PayTypeFeeType { get; set; }
        public decimal? EuroRounding { get; set; }
        public decimal? FundsMoved { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? CollectableDueDate { get; set; }
        public int? Eftstatus { get; set; }
        public bool? AuthorisationRequired { get; set; }
        public bool? Eftpending { get; set; }
        public bool? SettlementRequired { get; set; }
        public bool? Eftfailed { get; set; }
        public bool? Eftdone { get; set; }
        public string EftstatusMessage { get; set; }
        public string VerifiedByVisaSli { get; set; }
        public string SettlementStatus { get; set; }
        public DateTime? BillingDateTime { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public string LastFourDigits { get; set; }
        public byte[] CreditCardNumber { get; set; }
        public int? Installments { get; set; }
        public string GiroBankAccount { get; set; }
        public int? GiroBatch { get; set; }
        public int? GiroDateReceived { get; set; }
        public bool? ShipToBillingAddress { get; set; }

        public TblAuthorisationStatus AuthorisationStatus { get; set; }
        public TblOriginBillingRecordMap Billing { get; set; }
        public TblOrder Order { get; set; }
        public TblOriginBillingRecordMap ReplacedBillingRecord { get; set; }
        public TblOriginBillingRecordMap ReplacementBilling { get; set; }
        public TblOriginShippingRecordMap ShippingRecord { get; set; }
    }
}
