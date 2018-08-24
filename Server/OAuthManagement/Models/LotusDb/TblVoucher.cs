using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblVoucher
    {
        public TblVoucher()
        {
            TblCustomerAccountBalanceJournal = new HashSet<TblCustomerAccountBalanceJournal>();
        }

        public int VoucherId { get; set; }
        public int CustomerId { get; set; }
        public int TransactionDate { get; set; }
        public int TransactionNumber { get; set; }
        public decimal Amount { get; set; }
        public string PriceTypeCode { get; set; }
        public int VoucherStatusId { get; set; }
        public int? RedeemedCustomerId { get; set; }
        public DateTime? RedeemedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public string PriceCategory { get; set; }

        public TblCustomer Customer { get; set; }
        public TblCustomer RedeemedCustomer { get; set; }
        public TblVoucherStatus VoucherStatus { get; set; }
        public ICollection<TblCustomerAccountBalanceJournal> TblCustomerAccountBalanceJournal { get; set; }
    }
}
