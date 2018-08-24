using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblMembershipContentType
    {
        public TblMembershipContentType()
        {
            TblMembershipOrganisationContent = new HashSet<TblMembershipOrganisationContent>();
        }

        public int ContentTypeId { get; set; }
        public string KeyName { get; set; }
        public string ContentTypeDescription { get; set; }
        public string GroupName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<TblMembershipOrganisationContent> TblMembershipOrganisationContent { get; set; }
    }
}
