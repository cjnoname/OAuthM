using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblVenuePolicy
    {
        public int VenuePolicyId { get; set; }
        public int ShowVenueId { get; set; }
        public bool? Over18 { get; set; }
        public bool? Bar { get; set; }
        public bool? Food { get; set; }
        public bool? Heading { get; set; }
        public bool? Merchandise { get; set; }
        public bool? Disability { get; set; }
        public string Detail { get; set; }
        public bool? StaffRequired { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public byte[] Tstamp { get; set; }

        public TblShowVenue ShowVenue { get; set; }
    }
}
