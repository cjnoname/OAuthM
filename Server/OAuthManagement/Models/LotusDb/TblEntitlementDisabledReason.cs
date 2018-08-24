using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblEntitlementDisabledReason
    {
        public TblEntitlementDisabledReason()
        {
            TblEntitlementPassword = new HashSet<TblEntitlementPassword>();
            TblEntitlementUsage = new HashSet<TblEntitlementUsage>();
        }

        public int DisabledReasonId { get; set; }
        public string DisabledReasonCode { get; set; }
        public string DisabledReasonText { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public string Mapping { get; set; }

        public ICollection<TblEntitlementPassword> TblEntitlementPassword { get; set; }
        public ICollection<TblEntitlementUsage> TblEntitlementUsage { get; set; }
    }
}
