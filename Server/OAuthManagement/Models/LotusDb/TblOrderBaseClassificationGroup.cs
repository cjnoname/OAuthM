using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOrderBaseClassificationGroup
    {
        public int OrderBaseClassificationGroupId { get; set; }
        public int OrganisationId { get; set; }
        public int OrderBaseClassificationGroup { get; set; }
        public int MembershipProductId { get; set; }
        public int OrderBaseClassificationId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public int? IncMemberTix { get; set; }
        public int? IncGuestTix { get; set; }

        public TblMembershipProduct MembershipProduct { get; set; }
        public TblOrderBaseClassification OrderBaseClassification { get; set; }
        public TblOrganisation Organisation { get; set; }
    }
}
