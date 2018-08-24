using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSysSecurityTaskOperation
    {
        public int RecordId { get; set; }
        public int TaskId { get; set; }
        public int OperationId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public TblSysSecurityOperation Operation { get; set; }
        public TblSysSecurityTask Task { get; set; }
    }
}
