using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblPerformance
    {
        public int ProductId { get; set; }
        public DateTime? PerformanceDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public int? VenueId { get; set; }
        public DateTime? SeasonDescriptionFileExpired { get; set; }

        public TblProduct Product { get; set; }
        public TblVenue Venue { get; set; }
    }
}
