using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblCustomerSubscription
    {
        public int RecordId { get; set; }
        public int SubscriptionId { get; set; }
        public int CustomerId { get; set; }
        public bool IsSubscribed { get; set; }
        public int? SubscriptionChoiceId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblCustomer Customer { get; set; }
        public TblSubscription1 Subscription { get; set; }
        public TblSubscriptionChoice SubscriptionChoice { get; set; }
    }
}
