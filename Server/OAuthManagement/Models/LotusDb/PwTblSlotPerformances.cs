using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class PwTblSlotPerformances
    {
        public PwTblSlotPerformances()
        {
            PwTblSlotPerformancePriceCategoryMappings = new HashSet<PwTblSlotPerformancePriceCategoryMappings>();
        }

        public int SlpId { get; set; }
        public int SlpSpid { get; set; }
        public int SlpSlid { get; set; }
        public int SlpOrder { get; set; }
        public string SlpHoldCode { get; set; }
        public string SlpSelectionNumber { get; set; }

        public PwTblSlots SlpSl { get; set; }
        public PwTblSeasonPerformances SlpSp { get; set; }
        public ICollection<PwTblSlotPerformancePriceCategoryMappings> PwTblSlotPerformancePriceCategoryMappings { get; set; }
    }
}
