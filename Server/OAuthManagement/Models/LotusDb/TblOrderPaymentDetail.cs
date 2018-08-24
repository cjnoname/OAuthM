using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOrderPaymentDetail
    {
        public int OrderId { get; set; }
        public short PaymentMethod { get; set; }
        public string PaymentNumber { get; set; }
        public string PaymentReference { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblOrder1 Order { get; set; }
    }
}
