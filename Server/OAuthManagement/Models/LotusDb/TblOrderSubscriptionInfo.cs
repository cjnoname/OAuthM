using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOrderSubscriptionInfo
    {
        public int RenewSubscriptionAllocationId { get; set; }
        public bool? ChangeFlag { get; set; }
        public string AllocationException { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public int SubscriptionId { get; set; }

        public TblSubscriptionAllocation RenewSubscriptionAllocation { get; set; }
        public TblSubscription Subscription { get; set; }
    }
}
