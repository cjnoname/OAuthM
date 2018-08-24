using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSubscriptionAllocation
    {
        public TblSubscriptionAllocation()
        {
            TblOrderSubscriptionInfo = new HashSet<TblOrderSubscriptionInfo>();
            TblSeatAttribute = new HashSet<TblSeatAttribute>();
            TblSubscriptionAllocationPreferred = new HashSet<TblSubscriptionAllocationPreferred>();
        }

        public int SubscriptionAllocationId { get; set; }
        public int? SubscriptionId { get; set; }
        public string Section { get; set; }
        public string Row { get; set; }
        public string Seat { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public int? VenueId { get; set; }
        public int? PaxcardAllocationId { get; set; }

        public TblPaxcardAllocation PaxcardAllocation { get; set; }
        public TblSubscription Subscription { get; set; }
        public TblVenue Venue { get; set; }
        public ICollection<TblOrderSubscriptionInfo> TblOrderSubscriptionInfo { get; set; }
        public ICollection<TblSeatAttribute> TblSeatAttribute { get; set; }
        public ICollection<TblSubscriptionAllocationPreferred> TblSubscriptionAllocationPreferred { get; set; }
    }
}
