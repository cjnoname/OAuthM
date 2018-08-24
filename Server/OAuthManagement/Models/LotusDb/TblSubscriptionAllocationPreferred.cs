using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSubscriptionAllocationPreferred
    {
        public int SubscriptionAllocationPreferredId { get; set; }
        public int SubscriptionAllocationId { get; set; }
        public string Section { get; set; }
        public string Row { get; set; }
        public string Seat { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblSubscriptionAllocation SubscriptionAllocation { get; set; }
    }
}
