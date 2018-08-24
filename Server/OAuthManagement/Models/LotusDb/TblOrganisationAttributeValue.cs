using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOrganisationAttributeValue
    {
        public int RecordId { get; set; }
        public int AttributeId { get; set; }
        public int OrganisationCustomerId { get; set; }
        public int? ChoiceId { get; set; }
        public int? AttributeDataTypeId { get; set; }
        public int? AddressId { get; set; }
        public DateTime? DateTimeValue { get; set; }
        public bool? BooleanValue { get; set; }
        public string TextValue { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public double? NumericValue { get; set; }

        public TblAddress Address { get; set; }
        public TblOrganisationAttribute Attribute { get; set; }
        public TblAttributeDataType AttributeDataType { get; set; }
        public TblOrganisationChoiceAttribute Choice { get; set; }
        public TblOrganisationCustomer OrganisationCustomer { get; set; }
    }
}
