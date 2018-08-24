using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOrderDelegation
    {
        public int OrderMemberId { get; set; }
        public int DelegatingMembershipId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblMembership DelegatingMembership { get; set; }
        public TblMember OrderMember { get; set; }
    }
}
