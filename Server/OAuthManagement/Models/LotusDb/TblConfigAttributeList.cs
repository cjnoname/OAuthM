using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblConfigAttributeList
    {
        public int ConfigAttributeListId { get; set; }
        public int AttributeId { get; set; }
        public int AttributeListValue { get; set; }
        public string AttributeListName { get; set; }
        public bool AttributeDefault { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblConfigAttribute Attribute { get; set; }
    }
}
