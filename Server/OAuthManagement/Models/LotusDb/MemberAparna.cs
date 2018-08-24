using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class MemberAparna
    {
        public int OrganisationCustomerId { get; set; }
        public int OrganisationId { get; set; }
        public long CustomerId { get; set; }
        public int? PrimaryOrganisationCustomerId { get; set; }
        public string MemberNumber { get; set; }
        public string UserName { get; set; }
        public DateTime? MemberSince { get; set; }
        public string ExternalReference { get; set; }
        public string MembershipType { get; set; }
        public DateTime? SourceCreatedDate { get; set; }
        public DateTime? SourceModifiedDate { get; set; }
    }
}
