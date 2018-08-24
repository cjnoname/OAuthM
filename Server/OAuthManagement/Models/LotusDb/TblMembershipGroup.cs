using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblMembershipGroup
    {
        public TblMembershipGroup()
        {
            TblMemGroupMembershipJoin = new HashSet<TblMemGroupMembershipJoin>();
        }

        public int MembershipGroupId { get; set; }
        public int LeaderMemberId { get; set; }
        public string GroupName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblMember LeaderMember { get; set; }
        public ICollection<TblMemGroupMembershipJoin> TblMemGroupMembershipJoin { get; set; }
    }
}
