using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOrderLineAttributeValue
    {
        public int RecordId { get; set; }
        public int AttributeId { get; set; }
        public int OrderLineId { get; set; }
        public int? ChoiceId { get; set; }
        public int? AttributeDataTypeId { get; set; }
        public int? AddressId { get; set; }
        public string AttributeValue { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblAddress Address { get; set; }
        public TblOrderLineAttribute Attribute { get; set; }
        public TblAttributeDataType AttributeDataType { get; set; }
        public TblOrderLineChoiceAttribute Choice { get; set; }
        public TblOrderLine OrderLine { get; set; }
    }
}
