using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOrderPaymentHistory
    {
        public TblOrderPaymentHistory()
        {
            TblOrderLinePaymentHistory = new HashSet<TblOrderLinePaymentHistory>();
        }

        public int OrderPaymentHistoryId { get; set; }
        public int OrderId { get; set; }
        public int PaymentMethodId { get; set; }
        public string PaymentMethodReference { get; set; }
        public decimal? Amount { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public byte[] Tstamp { get; set; }
        public string PaymentRunNumber { get; set; }
        public decimal? ExtCcfee { get; set; }
        public DateTime? RequestProcessedDate { get; set; }
        public string ResponseMessage { get; set; }
        public int? RequestFail { get; set; }

        public TblOrder1 Order { get; set; }
        public TblPaymentMethod PaymentMethod { get; set; }
        public ICollection<TblOrderLinePaymentHistory> TblOrderLinePaymentHistory { get; set; }
    }
}
