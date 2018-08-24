using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class PwTblSlotPerformancePriceCategoryMappings
    {
        public int SlppcmId { get; set; }
        public int SlppcmSlpid { get; set; }
        public int SlppcmSeriesPriceCategoryCode { get; set; }
        public int SlppcmPerformancePriceCategoryCode { get; set; }

        public PwTblSlotPerformances SlppcmSlp { get; set; }
    }
}
