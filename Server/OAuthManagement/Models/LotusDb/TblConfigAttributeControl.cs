using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblConfigAttributeControl
    {
        public TblConfigAttributeControl()
        {
            TblConfigAttribute = new HashSet<TblConfigAttribute>();
        }

        public int ControlTypeId { get; set; }
        public string ControlType { get; set; }
        public int AttributeDataTypeId { get; set; }
        public short ControlReadOnly { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblAttributeDataType AttributeDataType { get; set; }
        public ICollection<TblConfigAttribute> TblConfigAttribute { get; set; }
    }
}
