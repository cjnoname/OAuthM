using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblConfigAttributeOperation
    {
        public int AttributeOperationId { get; set; }
        public int GroupAttributeId { get; set; }
        public int VisibleOperationId { get; set; }
        public int ModifyOperationId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblConfigAttributeGroup GroupAttribute { get; set; }
        public TblSysSecurityOperation ModifyOperation { get; set; }
    }
}
