using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblDistributionChannel
    {
        public TblDistributionChannel()
        {
            TblEntitlementUsage = new HashSet<TblEntitlementUsage>();
            TblInventoryTransaction = new HashSet<TblInventoryTransaction>();
        }

        public string DistributionChannelCode { get; set; }
        public string Description { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<TblEntitlementUsage> TblEntitlementUsage { get; set; }
        public ICollection<TblInventoryTransaction> TblInventoryTransaction { get; set; }
    }
}
