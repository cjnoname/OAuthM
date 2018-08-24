using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSysSecurityOperation
    {
        public TblSysSecurityOperation()
        {
            TblConfigAttributeOperation = new HashSet<TblConfigAttributeOperation>();
            TblMenuItemOperation = new HashSet<TblMenuItemOperation>();
            TblSysSecurityTaskOperation = new HashSet<TblSysSecurityTaskOperation>();
        }

        public int OperationId { get; set; }
        public int ApplicationId { get; set; }
        public string OperationName { get; set; }
        public string OperationDescription { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblSysApplication Application { get; set; }
        public ICollection<TblConfigAttributeOperation> TblConfigAttributeOperation { get; set; }
        public ICollection<TblMenuItemOperation> TblMenuItemOperation { get; set; }
        public ICollection<TblSysSecurityTaskOperation> TblSysSecurityTaskOperation { get; set; }
    }
}
