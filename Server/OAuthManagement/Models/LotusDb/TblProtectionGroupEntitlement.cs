using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblProtectionGroupEntitlement
    {
        public TblProtectionGroupEntitlement()
        {
            TblProtectionGroupEntitlementPriceType = new HashSet<TblProtectionGroupEntitlementPriceType>();
        }

        public int ProtectionGroupEntitlementId { get; set; }
        public int ProtectionGroupId { get; set; }
        public int EntitlementId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public string OfferCode { get; set; }

        public TblEntitlement Entitlement { get; set; }
        public TblProtectionGroup ProtectionGroup { get; set; }
        public ICollection<TblProtectionGroupEntitlementPriceType> TblProtectionGroupEntitlementPriceType { get; set; }
    }
}
