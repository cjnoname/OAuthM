using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblProcessLock
    {
        public int ProcessLockId { get; set; }
        public int OrganisationId { get; set; }
        public int ProcessType { get; set; }
        public string UniqueKeys { get; set; }
        public DateTime StartDate { get; set; }
        public int StartedBy { get; set; }
        public DateTime? StopDate { get; set; }
        public int? StoppedBy { get; set; }
        public bool IsLocked { get; set; }
        public bool? Cancelled { get; set; }
        public DateTime? CancelledDate { get; set; }
        public int? CancelledBy { get; set; }

        public TblOrganisation Organisation { get; set; }
    }
}
