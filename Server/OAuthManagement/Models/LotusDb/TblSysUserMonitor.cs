using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSysUserMonitor
    {
        public int UserId { get; set; }
        public DateTime? LastAccessedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? PasswordExpiry { get; set; }

        public TblSysUser User { get; set; }
    }
}
