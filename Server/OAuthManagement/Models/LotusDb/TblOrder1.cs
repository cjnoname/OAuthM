using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOrder1
    {
        public TblOrder1()
        {
            TblOrderLine = new HashSet<TblOrderLine>();
            TblOrderLineMemberShopItem = new HashSet<TblOrderLineMemberShopItem>();
            TblOrderPaymentHistory = new HashSet<TblOrderPaymentHistory>();
            TblOrderlineClassification = new HashSet<TblOrderlineClassification>();
        }

        public int OrderId { get; set; }
        public int OrganisationCustomerId { get; set; }
        public DateTime OrderJournalDate { get; set; }
        public string Channel { get; set; }
        public int? PointOfSale { get; set; }
        public string SellerId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public short? PaymentType { get; set; }
        public DateTime OrderReceivedDate { get; set; }
        public int? OrganisationId { get; set; }
        public string OriginErrorKey { get; set; }
        public string OriginErrorAdvice { get; set; }
        public DateTime? RequestProcessedDate { get; set; }
        public string ResponseMessage { get; set; }
        public DateTime? FailedPaymentDate { get; set; }
        public int? RequestFail { get; set; }
        public DateTime? FailedPaymentRequestProcessedDate { get; set; }
        public int? FailedPaymentRequestFail { get; set; }
        public string FailedPaymentResponseMessage { get; set; }
        public int? OrderStatusId { get; set; }
        public int? GroupId { get; set; }

        public TblOrganisationCustomer OrganisationCustomer { get; set; }
        public TblOrderClassification TblOrderClassification { get; set; }
        public TblOrderPaymentDetail TblOrderPaymentDetail { get; set; }
        public ICollection<TblOrderLine> TblOrderLine { get; set; }
        public ICollection<TblOrderLineMemberShopItem> TblOrderLineMemberShopItem { get; set; }
        public ICollection<TblOrderPaymentHistory> TblOrderPaymentHistory { get; set; }
        public ICollection<TblOrderlineClassification> TblOrderlineClassification { get; set; }
    }
}
