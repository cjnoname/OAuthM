using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblCustomerAccountBalanceJournal
    {
        public int RecordId { get; set; }
        public int CustomerId { get; set; }
        public decimal Amount { get; set; }
        public decimal OldBalance { get; set; }
        public decimal NewBalance { get; set; }
        public string SellerCode { get; set; }
        public int? VoucherId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public TblCustomer Customer { get; set; }
        public TblVoucher Voucher { get; set; }
    }
}
