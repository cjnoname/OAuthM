using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSysVersion
    {
        public int RecordId { get; set; }
        public int? DbmajorVersion { get; set; }
        public int? DbminorVersion { get; set; }
        public int? DbrevisionVersion { get; set; }
        public DateTime? RevisionDate { get; set; }
        public string Milestone { get; set; }
    }
}
