using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSysSecurityTask
    {
        public TblSysSecurityTask()
        {
            TblSysSecurityGroupTask = new HashSet<TblSysSecurityGroupTask>();
            TblSysSecurityTaskOperation = new HashSet<TblSysSecurityTaskOperation>();
        }

        public int TaskId { get; set; }
        public int ApplicationId { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblSysApplication Application { get; set; }
        public ICollection<TblSysSecurityGroupTask> TblSysSecurityGroupTask { get; set; }
        public ICollection<TblSysSecurityTaskOperation> TblSysSecurityTaskOperation { get; set; }
    }
}
