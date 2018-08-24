using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblCreditCardDetails
    {
        public TblCreditCardDetails()
        {
            TblAutomaticRenewalPaymentMethod = new HashSet<TblAutomaticRenewalPaymentMethod>();
            TblCustomerCreditCard = new HashSet<TblCustomerCreditCard>();
        }

        public int CreditCardId { get; set; }
        public int CardTypeId { get; set; }
        public byte[] CardNumber { get; set; }
        public string CardName { get; set; }
        public string FromDate { get; set; }
        public string ExpiryDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblCardType CardType { get; set; }
        public ICollection<TblAutomaticRenewalPaymentMethod> TblAutomaticRenewalPaymentMethod { get; set; }
        public ICollection<TblCustomerCreditCard> TblCustomerCreditCard { get; set; }
    }
}
