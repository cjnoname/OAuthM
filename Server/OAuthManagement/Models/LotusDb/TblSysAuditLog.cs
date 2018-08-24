using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSysAuditLog
    {
        public int LogId { get; set; }
        public string ApplicationCategory { get; set; }
        public string AuditFunction { get; set; }
        public string Status { get; set; }
        public DateTime? AuditDateTime { get; set; }
        public string Description { get; set; }
        public string Source { get; set; }
    }
}
