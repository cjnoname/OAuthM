using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOrganisationFeature
    {
        public TblOrganisationFeature()
        {
            TblOrganisationCommonAttribute = new HashSet<TblOrganisationCommonAttribute>();
            TblOrganisationCustomerFeature = new HashSet<TblOrganisationCustomerFeature>();
        }

        public int OrganisationFeatureId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public ICollection<TblOrganisationCommonAttribute> TblOrganisationCommonAttribute { get; set; }
        public ICollection<TblOrganisationCustomerFeature> TblOrganisationCustomerFeature { get; set; }
    }
}
