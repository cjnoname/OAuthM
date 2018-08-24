using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSysUserGroup
    {
        public int RecordId { get; set; }
        public int GroupId { get; set; }
        public int UserId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblSysGroup Group { get; set; }
        public TblSysUser User { get; set; }
    }
}
