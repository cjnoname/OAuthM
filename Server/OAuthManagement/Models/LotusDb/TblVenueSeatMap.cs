using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblVenueSeatMap
    {
        public int VenueSeatMapId { get; set; }
        public int ShowVenueId { get; set; }
        public string SeatMap { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public byte[] Tstamp { get; set; }

        public TblShowVenue ShowVenue { get; set; }
    }
}
