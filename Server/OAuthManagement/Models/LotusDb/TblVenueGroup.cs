using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblVenueGroup
    {
        public int VenueGroupId { get; set; }
        public int VenueManagerId { get; set; }
        public int VenueId { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public byte[] Tstamp { get; set; }

        public TblVenue Venue { get; set; }
        public TblVenueManager VenueManager { get; set; }
    }
}
