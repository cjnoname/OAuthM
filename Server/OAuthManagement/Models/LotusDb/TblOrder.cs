using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOrder
    {
        public TblOrder()
        {
            TblBillingRecord = new HashSet<TblBillingRecord>();
            TblInventoryTransaction = new HashSet<TblInventoryTransaction>();
            TblPrintRecord = new HashSet<TblPrintRecord>();
            TblShippingRecord = new HashSet<TblShippingRecord>();
            TblTaxInvoiceRecord = new HashSet<TblTaxInvoiceRecord>();
        }

        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? OrderJournalDate { get; set; }
        public string Channel { get; set; }
        public int? PointOfSale { get; set; }
        public string SellerId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public TblCustomer Customer { get; set; }
        public TblOriginOrderMap Order { get; set; }
        public ICollection<TblBillingRecord> TblBillingRecord { get; set; }
        public ICollection<TblInventoryTransaction> TblInventoryTransaction { get; set; }
        public ICollection<TblPrintRecord> TblPrintRecord { get; set; }
        public ICollection<TblShippingRecord> TblShippingRecord { get; set; }
        public ICollection<TblTaxInvoiceRecord> TblTaxInvoiceRecord { get; set; }
    }
}
