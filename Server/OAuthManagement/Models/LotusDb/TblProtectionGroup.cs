using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblProtectionGroup
    {
        public TblProtectionGroup()
        {
            TblEntitlementUsage = new HashSet<TblEntitlementUsage>();
            TblProtectionGroupEntitlement = new HashSet<TblProtectionGroupEntitlement>();
            TblProtectionItem = new HashSet<TblProtectionItem>();
        }

        public int ProtectionGroupId { get; set; }
        public int EntitlementGroupId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblEntitlementGroup EntitlementGroup { get; set; }
        public ICollection<TblEntitlementUsage> TblEntitlementUsage { get; set; }
        public ICollection<TblProtectionGroupEntitlement> TblProtectionGroupEntitlement { get; set; }
        public ICollection<TblProtectionItem> TblProtectionItem { get; set; }
    }
}
