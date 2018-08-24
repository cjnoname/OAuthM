using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblMembershipPortalAttributeValue
    {
        public int OrganisationId { get; set; }
        public int MembershipPortalAttributeId { get; set; }
        public string Value { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblMembershipPortalAttribute MembershipPortalAttribute { get; set; }
        public TblMembershipOrganisation Organisation { get; set; }
    }
}
