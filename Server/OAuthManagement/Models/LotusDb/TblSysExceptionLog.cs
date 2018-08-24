using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSysExceptionLog
    {
        public TblSysExceptionLog()
        {
            TblSysCategoryExceptionLog = new HashSet<TblSysCategoryExceptionLog>();
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
        public string InnerExceptionType { get; set; }
        public string InnerText { get; set; }
        public string OuterExceptionType { get; set; }
        public string OuterText { get; set; }
        public string CallStackInformation { get; set; }
        public string WindowsAccountName { get; set; }
        public string ProductionLevel { get; set; }
        public int? UserId { get; set; }
        public string SourceApplication { get; set; }
        public string Component { get; set; }

        public ICollection<TblSysCategoryExceptionLog> TblSysCategoryExceptionLog { get; set; }
    }
}
