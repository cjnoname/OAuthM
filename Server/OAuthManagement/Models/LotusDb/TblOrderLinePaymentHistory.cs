using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOrderLinePaymentHistory
    {
        public int OrderLinePaymentHistoryId { get; set; }
        public int OrderLineId { get; set; }
        public int OrderPaymentHistoryId { get; set; }
        public decimal? Amount { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public byte[] Tstamp { get; set; }
        public decimal? ExtCcfee { get; set; }
        public string AuthCode { get; set; }
        public string EventCode { get; set; }

        public TblOrderLine OrderLine { get; set; }
        public TblOrderPaymentHistory OrderPaymentHistory { get; set; }
    }
}
