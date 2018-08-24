using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblProductGroup
    {
        public int ProductGroupId { get; set; }
        public string Heading { get; set; }
        public string Description { get; set; }
        public int? DisplayIndex { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public int OrganisationId { get; set; }

        public TblOrganisation Organisation { get; set; }
    }
}
