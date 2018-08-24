using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSubscription1
    {
        public TblSubscription1()
        {
            TblCustomerSubscription = new HashSet<TblCustomerSubscription>();
            TblSubscriptionChoice = new HashSet<TblSubscriptionChoice>();
        }

        public int SubscriptionId { get; set; }
        public string SubscriptionName { get; set; }
        public string Label { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsChoice { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblSubscriptionPremiumSms TblSubscriptionPremiumSms { get; set; }
        public ICollection<TblCustomerSubscription> TblCustomerSubscription { get; set; }
        public ICollection<TblSubscriptionChoice> TblSubscriptionChoice { get; set; }
    }
}
