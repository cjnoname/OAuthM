using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class PwTblSeasonPerformancesCulture
    {
        public int SpcId { get; set; }
        public int SpcSpid { get; set; }
        public string SpcNcvcode { get; set; }
        public string SpcTitle { get; set; }

        public PwTblSeasonPerformances SpcSp { get; set; }
    }
}
