using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblEntitlement
    {
        public TblEntitlement()
        {
            TblBallotGroup = new HashSet<TblBallotGroup>();
            TblEntitlementDependencyChildEntitlement = new HashSet<TblEntitlementDependency>();
            TblEntitlementDependencyParentEntitlement = new HashSet<TblEntitlementDependency>();
            TblEntitlementUsage = new HashSet<TblEntitlementUsage>();
            TblProtectionGroupEntitlement = new HashSet<TblProtectionGroupEntitlement>();
        }

        public int EntitlementId { get; set; }
        public string EntitlementName { get; set; }
        public int? MaximumUsage { get; set; }
        public int? MaximumAdmits { get; set; }
        public int? MaximumAdmitsPerProtectionGroup { get; set; }
        public bool CancelBarcode { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public string OfferCode { get; set; }

        public ICollection<TblBallotGroup> TblBallotGroup { get; set; }
        public ICollection<TblEntitlementDependency> TblEntitlementDependencyChildEntitlement { get; set; }
        public ICollection<TblEntitlementDependency> TblEntitlementDependencyParentEntitlement { get; set; }
        public ICollection<TblEntitlementUsage> TblEntitlementUsage { get; set; }
        public ICollection<TblProtectionGroupEntitlement> TblProtectionGroupEntitlement { get; set; }
    }
}
