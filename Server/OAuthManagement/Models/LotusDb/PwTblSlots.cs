using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class PwTblSlots
    {
        public PwTblSlots()
        {
            PwTblSlotPerformances = new HashSet<PwTblSlotPerformances>();
            PwTblSlotsCulture = new HashSet<PwTblSlotsCulture>();
        }

        public int SlId { get; set; }
        public int SlShid { get; set; }
        public int SlIndex { get; set; }
        public int SlUiOrder { get; set; }
        public int SlMaximumSelections { get; set; }
        public int SlMinimumSelections { get; set; }
        public int? SlRequiredSelections { get; set; }

        public PwTblShows SlSh { get; set; }
        public ICollection<PwTblSlotPerformances> PwTblSlotPerformances { get; set; }
        public ICollection<PwTblSlotsCulture> PwTblSlotsCulture { get; set; }
    }
}
