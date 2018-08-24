using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblMembershipOrganisationType
    {
        public TblMembershipOrganisationType()
        {
            TblMembershipOrganisation = new HashSet<TblMembershipOrganisation>();
        }

        public int MembershipOrganisationTypeId { get; set; }
        public string MembershipOrganisationTypeName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<TblMembershipOrganisation> TblMembershipOrganisation { get; set; }
    }
}
