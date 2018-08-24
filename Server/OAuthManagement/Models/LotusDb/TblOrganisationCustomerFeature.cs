using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOrganisationCustomerFeature
    {
        public int OrganisationCustomerFeatureId { get; set; }
        public int OrganisationFeatureId { get; set; }
        public int OrganisationId { get; set; }
        public bool? Enabled { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public TblOrganisation Organisation { get; set; }
        public TblOrganisationFeature OrganisationFeature { get; set; }
    }
}
