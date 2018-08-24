using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class PwTblSeasonPerformances
    {
        public PwTblSeasonPerformances()
        {
            PwTblSeasonPerformancesCulture = new HashSet<PwTblSeasonPerformancesCulture>();
            PwTblSlotPerformances = new HashSet<PwTblSlotPerformances>();
        }

        public int SpId { get; set; }
        public string SpPerfCode { get; set; }
        public string SpSoftixWho { get; set; }
        public string SpSoftixWhen { get; set; }
        public string SpSoftixWhere { get; set; }
        public string SpVncode { get; set; }
        public DateTime SpPerformanceDate { get; set; }

        public ICollection<PwTblSeasonPerformancesCulture> PwTblSeasonPerformancesCulture { get; set; }
        public ICollection<PwTblSlotPerformances> PwTblSlotPerformances { get; set; }
    }
}
