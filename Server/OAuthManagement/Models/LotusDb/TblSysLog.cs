﻿using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSysLog
    {
        public TblSysLog()
        {
            TblSysCategoryLog = new HashSet<TblSysCategoryLog>();
        }

        public int LogId { get; set; }
        public int? EventId { get; set; }
        public int Priority { get; set; }
        public string Severity { get; set; }
        public string Title { get; set; }
        public DateTime Timestamp { get; set; }
        public DateTime TimestampUtc { get; set; }
        public int ApplicationId { get; set; }
        public string MachineName { get; set; }
        public string AppDomainName { get; set; }
        public string ProcessId { get; set; }
        public string ProcessName { get; set; }
        public string ThreadName { get; set; }
        public string Win32ThreadId { get; set; }
        public string Message { get; set; }
        public string WindowsAccountName { get; set; }
        public string ProductionLevel { get; set; }
        public int? UserId { get; set; }
        public string SourceApplication { get; set; }

        public ICollection<TblSysCategoryLog> TblSysCategoryLog { get; set; }
    }
}
