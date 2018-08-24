using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblEntitlementDependency
    {
        public int ParentEntitlementId { get; set; }
        public int ChildEntitlementId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblEntitlement ChildEntitlement { get; set; }
        public TblEntitlement ParentEntitlement { get; set; }
    }
}
