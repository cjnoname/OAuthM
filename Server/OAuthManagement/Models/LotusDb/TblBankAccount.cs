using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblBankAccount
    {
        public TblBankAccount()
        {
            TblAutomaticRenewalPaymentMethod = new HashSet<TblAutomaticRenewalPaymentMethod>();
        }

        public int BankAccountId { get; set; }
        public string BranchId { get; set; }
        public byte[] AccountNumber { get; set; }
        public string AccountName { get; set; }
        public int CustomerId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblCustomer Customer { get; set; }
        public ICollection<TblAutomaticRenewalPaymentMethod> TblAutomaticRenewalPaymentMethod { get; set; }
    }
}
