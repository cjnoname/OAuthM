using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSysCategoryExceptionLog
    {
        public int CategoryLogId { get; set; }
        public int CategoryId { get; set; }
        public int LogId { get; set; }

        public TblSysLoggingCategory Category { get; set; }
        public TblSysExceptionLog Log { get; set; }
    }
}
