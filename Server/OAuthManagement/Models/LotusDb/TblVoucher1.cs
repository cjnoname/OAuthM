using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblVoucher1
    {
        public TblVoucher1()
        {
            TblGiftCard = new HashSet<TblGiftCard>();
            TblVoucherTransaction = new HashSet<TblVoucherTransaction>();
        }

        public int VoucherId { get; set; }
        public string VoucherIdentifier { get; set; }
        public DateTime? ActivationDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public DateTime? LockedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public DateTime? LockedUntilDate { get; set; }

        public ICollection<TblGiftCard> TblGiftCard { get; set; }
        public ICollection<TblVoucherTransaction> TblVoucherTransaction { get; set; }
    }
}
