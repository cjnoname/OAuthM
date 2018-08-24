using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class InTblSeatmapReportAccess
    {
        public int SeatmapReportAccessId { get; set; }
        public int UserId { get; set; }
        public int? VenueId { get; set; }
        public int? AccessLevel { get; set; }
        public bool? IsOverride { get; set; }
        public byte[] Tstamp { get; set; }

        public InTblUsers User { get; set; }
        public InTblGroups Venue { get; set; }
    }
}
