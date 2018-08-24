using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblMembershipPortalAttribute
    {
        public TblMembershipPortalAttribute()
        {
            TblMembershipPortalAttributeValue = new HashSet<TblMembershipPortalAttributeValue>();
        }

        public int MembershipPortalAttributeId { get; set; }
        public int MembershipPortalAttributeTypeId { get; set; }
        public string AttributeName { get; set; }
        public string ValidationError { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblMembershipPortalAttributeType MembershipPortalAttributeType { get; set; }
        public ICollection<TblMembershipPortalAttributeValue> TblMembershipPortalAttributeValue { get; set; }
    }
}
