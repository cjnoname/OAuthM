using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblConfigAttributeGroup
    {
        public TblConfigAttributeGroup()
        {
            TblConfigAttributeOperation = new HashSet<TblConfigAttributeOperation>();
        }

        public int GroupAttributeId { get; set; }
        public int GroupId { get; set; }
        public int AttributeId { get; set; }
        public int AttributePriority { get; set; }
        public int AttributeLinkId { get; set; }
        public string AttributeDefaultOverWrite { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblConfigAttribute Attribute { get; set; }
        public TblConfigAttributeUserControl Group { get; set; }
        public ICollection<TblConfigAttributeOperation> TblConfigAttributeOperation { get; set; }
    }
}
