using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblCustomerTypeAttributeValue
    {
        public int RecordId { get; set; }
        public int CustomerCustomerTypeId { get; set; }
        public int AttributeId { get; set; }
        public int? AttributeDataTypeId { get; set; }
        public int? ChoiceId { get; set; }
        public bool? BooleanValue { get; set; }
        public DateTime? DateTimeValue { get; set; }
        public string TextValue { get; set; }
        public int? AddressId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public double? NumericValue { get; set; }

        public TblAddress Address { get; set; }
        public TblCustomerTypeAttribute Attribute { get; set; }
        public TblAttributeDataType AttributeDataType { get; set; }
        public TblCustomerTypeChoiceAttribute Choice { get; set; }
        public TblCustomerCustomerType CustomerCustomerType { get; set; }
    }
}
