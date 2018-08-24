using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class PwTblPasswords
    {
        public int PwdPgid { get; set; }
        public string PwdPassword { get; set; }
        public int PwdUsageCount { get; set; }

        public PwTblPasswordGroups PwdPg { get; set; }
    }
}
