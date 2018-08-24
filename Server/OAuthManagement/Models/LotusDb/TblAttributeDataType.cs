using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblAttributeDataType
    {
        public TblAttributeDataType()
        {
            TblActivityTypeAttribute = new HashSet<TblActivityTypeAttribute>();
            TblActivityTypeAttributeValue = new HashSet<TblActivityTypeAttributeValue>();
            TblActivityTypeCommonAttribute = new HashSet<TblActivityTypeCommonAttribute>();
            TblConfigAttributeControl = new HashSet<TblConfigAttributeControl>();
            TblConfigAttributeValue = new HashSet<TblConfigAttributeValue>();
            TblCustomerTypeAttribute = new HashSet<TblCustomerTypeAttribute>();
            TblCustomerTypeAttributeValue = new HashSet<TblCustomerTypeAttributeValue>();
            TblCustomerTypeCommonAttribute = new HashSet<TblCustomerTypeCommonAttribute>();
            TblEnquiryFilterParam = new HashSet<TblEnquiryFilterParam>();
            TblOrderLineAttribute = new HashSet<TblOrderLineAttribute>();
            TblOrderLineAttributeValue = new HashSet<TblOrderLineAttributeValue>();
            TblOrderLineCommonAttribute = new HashSet<TblOrderLineCommonAttribute>();
            TblOrganisationAttribute = new HashSet<TblOrganisationAttribute>();
            TblOrganisationAttributeValue = new HashSet<TblOrganisationAttributeValue>();
            TblOrganisationCommonAttribute = new HashSet<TblOrganisationCommonAttribute>();
            TblSysUserPreference = new HashSet<TblSysUserPreference>();
        }

        public int AttributeDataTypeId { get; set; }
        public string AttributeDataTypeName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<TblActivityTypeAttribute> TblActivityTypeAttribute { get; set; }
        public ICollection<TblActivityTypeAttributeValue> TblActivityTypeAttributeValue { get; set; }
        public ICollection<TblActivityTypeCommonAttribute> TblActivityTypeCommonAttribute { get; set; }
        public ICollection<TblConfigAttributeControl> TblConfigAttributeControl { get; set; }
        public ICollection<TblConfigAttributeValue> TblConfigAttributeValue { get; set; }
        public ICollection<TblCustomerTypeAttribute> TblCustomerTypeAttribute { get; set; }
        public ICollection<TblCustomerTypeAttributeValue> TblCustomerTypeAttributeValue { get; set; }
        public ICollection<TblCustomerTypeCommonAttribute> TblCustomerTypeCommonAttribute { get; set; }
        public ICollection<TblEnquiryFilterParam> TblEnquiryFilterParam { get; set; }
        public ICollection<TblOrderLineAttribute> TblOrderLineAttribute { get; set; }
        public ICollection<TblOrderLineAttributeValue> TblOrderLineAttributeValue { get; set; }
        public ICollection<TblOrderLineCommonAttribute> TblOrderLineCommonAttribute { get; set; }
        public ICollection<TblOrganisationAttribute> TblOrganisationAttribute { get; set; }
        public ICollection<TblOrganisationAttributeValue> TblOrganisationAttributeValue { get; set; }
        public ICollection<TblOrganisationCommonAttribute> TblOrganisationCommonAttribute { get; set; }
        public ICollection<TblSysUserPreference> TblSysUserPreference { get; set; }
    }
}
