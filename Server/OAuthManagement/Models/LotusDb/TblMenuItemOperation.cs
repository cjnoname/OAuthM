using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblMenuItemOperation
    {
        public int MenuItemOperationId { get; set; }
        public int MenuItemId { get; set; }
        public int OperationId { get; set; }
        public bool? Required { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblMenuItem MenuItem { get; set; }
        public TblSysSecurityOperation Operation { get; set; }
    }
}
