using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class InTblVenueSeatmapSettings
    {
        public int VenueSeatmapSettingsId { get; set; }
        public int VenueId { get; set; }
        public bool? IsSeatmapReportingEnabled { get; set; }
        public bool? AreSectionAdditionsInFront { get; set; }
        public bool? AreSeatsTrimmedAndCentered { get; set; }
        public bool? PadRowWithExtraSeat { get; set; }
        public bool? RowsFillAvailableSpace { get; set; }
        public decimal? NoFillRowSpacingFactor { get; set; }
        public bool? SeatsFillAvailableSpace { get; set; }
        public decimal? NoFillSeatSpacingFactor { get; set; }

        public InTblGroups Venue { get; set; }
    }
}
