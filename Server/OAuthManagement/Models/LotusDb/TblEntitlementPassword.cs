using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblEntitlementPassword
    {
        public TblEntitlementPassword()
        {
            TblEntitlementUsage = new HashSet<TblEntitlementUsage>();
        }

        public int EntitlementPasswordId { get; set; }
        public int EntitlementGroupId { get; set; }
        public string EntitlementPassword { get; set; }
        public bool IsDisabled { get; set; }
        public int? DisabledReasonId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblEntitlementDisabledReason DisabledReason { get; set; }
        public TblEntitlementGroup EntitlementGroup { get; set; }
        public ICollection<TblEntitlementUsage> TblEntitlementUsage { get; set; }
    }
}
