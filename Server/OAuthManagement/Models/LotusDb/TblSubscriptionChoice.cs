using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSubscriptionChoice
    {
        public TblSubscriptionChoice()
        {
            TblCustomerSubscription = new HashSet<TblCustomerSubscription>();
        }

        public int SubscriptionChoiceId { get; set; }
        public int SubscriptionId { get; set; }
        public string ChoiceName { get; set; }
        public string DisplayLabel { get; set; }
        public int DisplayOrder { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblSubscription1 Subscription { get; set; }
        public ICollection<TblCustomerSubscription> TblCustomerSubscription { get; set; }
    }
}
