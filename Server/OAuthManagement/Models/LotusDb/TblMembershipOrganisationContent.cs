using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblMembershipOrganisationContent
    {
        public int OrganisationContentId { get; set; }
        public int OrganisationId { get; set; }
        public int ContentTypeId { get; set; }
        public string Blurb { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblMembershipContentType ContentType { get; set; }
        public TblMembershipOrganisation Organisation { get; set; }
    }
}
