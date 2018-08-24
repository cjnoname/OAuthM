using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblMembershipPortalAttributeType
    {
        public TblMembershipPortalAttributeType()
        {
            TblMembershipPortalAttribute = new HashSet<TblMembershipPortalAttribute>();
        }

        public int MembershipPortalAttributeTypeId { get; set; }
        public string AttributeTypeName { get; set; }
        public string ValidationExpression { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<TblMembershipPortalAttribute> TblMembershipPortalAttribute { get; set; }
    }
}
