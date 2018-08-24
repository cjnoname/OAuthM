using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblPackageMembershipProductOverride
    {
        public int MembershipProductOverrideId { get; set; }
        public int? ProductId { get; set; }
        public int? MembershipProductId { get; set; }
        public int? PayingGuestsQty { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblMembershipProduct MembershipProduct { get; set; }
        public TblPackage Product { get; set; }
    }
}
