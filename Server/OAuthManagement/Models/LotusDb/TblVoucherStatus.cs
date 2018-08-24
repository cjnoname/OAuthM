using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblVoucherStatus
    {
        public TblVoucherStatus()
        {
            TblVoucher = new HashSet<TblVoucher>();
        }

        public int VoucherStatusId { get; set; }
        public string VoucherStatus { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<TblVoucher> TblVoucher { get; set; }
    }
}
