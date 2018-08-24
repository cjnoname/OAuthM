using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblTaxInvoiceRecord
    {
        public int TaxInvoiceId { get; set; }
        public int OrderId { get; set; }
        public int? PreviousTaxInvoiceId { get; set; }
        public int? SaleTransactionId { get; set; }
        public bool? IsPrintedOffline { get; set; }
        public bool? IsCopy { get; set; }
        public string Abn { get; set; }
        public string InvoiceName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string RecipientEmail { get; set; }
        public string Zipcode { get; set; }
        public int? Quantity { get; set; }
        public decimal? TotalPaid { get; set; }
        public decimal? TotalTax { get; set; }
        public decimal? BfeeAmount { get; set; }
        public decimal? HfeeAmount { get; set; }
        public decimal? TicketCost { get; set; }
        public string PrintSellerId { get; set; }
        public string DispatchType { get; set; }
        public DateTime? TaxInvoiceDateTime { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblOrder Order { get; set; }
        public TblOriginTaxInvoiceMap PreviousTaxInvoice { get; set; }
        public TblOriginInventoryTransactionMap SaleTransaction { get; set; }
        public TblOriginTaxInvoiceMap TaxInvoice { get; set; }
    }
}
