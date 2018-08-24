using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOrderLineCommonAttribute
    {
        public TblOrderLineCommonAttribute()
        {
            TblOrderLineAttribute = new HashSet<TblOrderLineAttribute>();
            TblOrderLineChoiceAttribute = new HashSet<TblOrderLineChoiceAttribute>();
        }

        public int CommonAttributeId { get; set; }
        public int AttributeDataTypeId { get; set; }
        public int? AddressTypeId { get; set; }
        public string AttributeName { get; set; }
        public string DisplayLabel { get; set; }
        public string Locale { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblAddressType AddressType { get; set; }
        public TblAttributeDataType AttributeDataType { get; set; }
        public ICollection<TblOrderLineAttribute> TblOrderLineAttribute { get; set; }
        public ICollection<TblOrderLineChoiceAttribute> TblOrderLineChoiceAttribute { get; set; }
    }
}
