using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblMemGroupMembershipJoin
    {
        public int MembershipGroupId { get; set; }
        public int MembershipId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblMembership Membership { get; set; }
        public TblMembershipGroup MembershipGroup { get; set; }
    }
}
