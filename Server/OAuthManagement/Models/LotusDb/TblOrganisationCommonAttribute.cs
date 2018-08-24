using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOrganisationCommonAttribute
    {
        public TblOrganisationCommonAttribute()
        {
            TblOrganisationAttribute = new HashSet<TblOrganisationAttribute>();
            TblOrganisationChoiceAttribute = new HashSet<TblOrganisationChoiceAttribute>();
        }

        public int CommonAttributeId { get; set; }
        public int AttributeDataTypeId { get; set; }
        public int? AddressTypeId { get; set; }
        public string AttributeName { get; set; }
        public string DisplayLabel { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public int? OrganisationFeatureId { get; set; }

        public TblAddressType AddressType { get; set; }
        public TblAttributeDataType AttributeDataType { get; set; }
        public TblOrganisationFeature OrganisationFeature { get; set; }
        public ICollection<TblOrganisationAttribute> TblOrganisationAttribute { get; set; }
        public ICollection<TblOrganisationChoiceAttribute> TblOrganisationChoiceAttribute { get; set; }
    }
}
