using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblEntitlementGroup
    {
        public TblEntitlementGroup()
        {
            TblEntitlementPassword = new HashSet<TblEntitlementPassword>();
            TblProtectionGroup = new HashSet<TblProtectionGroup>();
        }

        public int EntitlementGroupId { get; set; }
        public string EntitlementGroupName { get; set; }
        public string Mapping { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public string DatabaseSource { get; set; }
        public string EventGroupCode { get; set; }
        public string TicketType { get; set; }
        public string Code { get; set; }

        public ICollection<TblEntitlementPassword> TblEntitlementPassword { get; set; }
        public ICollection<TblProtectionGroup> TblProtectionGroup { get; set; }
    }
}
