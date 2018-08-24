using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblShowVenueTicketLine
    {
        public int TitleLineId { get; set; }
        public int ShowVenueId { get; set; }
        public string TitleLine { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public byte[] Tstamp { get; set; }

        public TblShowVenue ShowVenue { get; set; }
    }
}
