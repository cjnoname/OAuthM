using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSysSecurityGroupTask
    {
        public int RecordId { get; set; }
        public int GroupId { get; set; }
        public int TaskId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblSysGroup Group { get; set; }
        public TblSysSecurityTask Task { get; set; }
    }
}
