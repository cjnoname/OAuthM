using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblShowTime
    {
        public int ShowTimeId { get; set; }
        public int ShowVenueId { get; set; }
        public string BoxOfficeOpens { get; set; }
        public string DoorOpens { get; set; }
        public string Finish { get; set; }
        public string MainAct { get; set; }
        public string Support1 { get; set; }
        public string Support2 { get; set; }
        public string Support3 { get; set; }
        public string Interval1 { get; set; }
        public string Interval2 { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public byte[] Tstamp { get; set; }

        public TblShowVenue ShowVenue { get; set; }
    }
}
