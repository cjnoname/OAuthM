using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblAutomaticRenewalPaymentMethod
    {
        public int AutomaticRenewalPaymentMethodId { get; set; }
        public int CustomerId { get; set; }
        public int? OrganisationCustomerId { get; set; }
        public int? CreditCardId { get; set; }
        public int? BankAccountId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblBankAccount BankAccount { get; set; }
        public TblCreditCardDetails CreditCard { get; set; }
        public TblCustomer Customer { get; set; }
        public TblOrganisationCustomer OrganisationCustomer { get; set; }
    }
}
