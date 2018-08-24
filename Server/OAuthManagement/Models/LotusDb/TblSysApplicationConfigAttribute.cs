using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSysApplicationConfigAttribute
    {
        public int AttributeId { get; set; }
        public int ApplicationId { get; set; }
        public string AttributeName { get; set; }
        public string AttributeDescription { get; set; }
        public string AttributeDefaultValue { get; set; }
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
    }
}
