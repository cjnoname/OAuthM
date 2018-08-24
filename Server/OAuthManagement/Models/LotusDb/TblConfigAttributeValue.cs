using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblConfigAttributeValue
    {
        public int ConfigAttributeValueId { get; set; }
        public int AttributeId { get; set; }
        public int EntityId { get; set; }
        public int EntityKey { get; set; }
        public int AttributeDataTypeId { get; set; }
        public string TextValue { get; set; }
        public int? IntegerValue { get; set; }
        public decimal? NumericValue { get; set; }
        public DateTime? DateTimeValue { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblConfigAttribute Attribute { get; set; }
        public TblAttributeDataType AttributeDataType { get; set; }
        public TblConfigAttributeEntity Entity { get; set; }
    }
}
