using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSubscriptionStatus
    {
        public TblSubscriptionStatus()
        {
            TblSubscription = new HashSet<TblSubscription>();
        }

        public int SubscriptionStatusId { get; set; }
        public string SubscriptionStatusName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<TblSubscription> TblSubscription { get; set; }
    }
}
