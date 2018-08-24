using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOriginInventoryTransactionMap
    {
        public TblOriginInventoryTransactionMap()
        {
            TblInventoryTransactionBasketNextTrans = new HashSet<TblInventoryTransaction>();
            TblInventoryTransactionPaymentTrans = new HashSet<TblInventoryTransaction>();
            TblInventoryTransactionReturnTrans = new HashSet<TblInventoryTransaction>();
            TblInventoryTransactionSaleTrans = new HashSet<TblInventoryTransaction>();
            TblTaxInvoiceRecord = new HashSet<TblTaxInvoiceRecord>();
        }

        public int InventoryTransactionId { get; set; }
        public int InventoryTransactionTnum { get; set; }
        public int InventoryTransactionDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public TblInventoryTransaction TblInventoryTransactionInventoryTransaction { get; set; }
        public ICollection<TblInventoryTransaction> TblInventoryTransactionBasketNextTrans { get; set; }
        public ICollection<TblInventoryTransaction> TblInventoryTransactionPaymentTrans { get; set; }
        public ICollection<TblInventoryTransaction> TblInventoryTransactionReturnTrans { get; set; }
        public ICollection<TblInventoryTransaction> TblInventoryTransactionSaleTrans { get; set; }
        public ICollection<TblTaxInvoiceRecord> TblTaxInvoiceRecord { get; set; }
    }
}
