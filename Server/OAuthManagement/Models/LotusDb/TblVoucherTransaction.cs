using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblVoucherTransaction
    {
        public int VoucherTransactionId { get; set; }
        public int VoucherId { get; set; }
        public int TransactionDate { get; set; }
        public int TransactionNumber { get; set; }
        public int PaxNumber { get; set; }
        public bool IsRedeemed { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public int? RedeemedForTransactionDate { get; set; }
        public int? RedeemedForTransactionNumber { get; set; }

        public TblVoucher1 Voucher { get; set; }
    }
}
