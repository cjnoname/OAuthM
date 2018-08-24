using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOriginTaxInvoiceMap
    {
        public TblOriginTaxInvoiceMap()
        {
            TblTaxInvoiceRecordPreviousTaxInvoice = new HashSet<TblTaxInvoiceRecord>();
        }

        public int TaxInvoiceId { get; set; }
        public int TaxInvoiceTnum { get; set; }
        public int TaxInvoiceDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public TblTaxInvoiceRecord TblTaxInvoiceRecordTaxInvoice { get; set; }
        public ICollection<TblTaxInvoiceRecord> TblTaxInvoiceRecordPreviousTaxInvoice { get; set; }
    }
}
