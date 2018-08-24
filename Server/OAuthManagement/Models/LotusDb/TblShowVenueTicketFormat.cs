using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblShowVenueTicketFormat
    {
        public int TicketFormatId { get; set; }
        public int ShowVenueId { get; set; }
        public int TitleLinePrefVenue { get; set; }
        public int TitleLinePrefEvent { get; set; }
        public int TitleLinePrefDate { get; set; }
        public string EventComment { get; set; }
        public string TicketFormatScript { get; set; }
        public string ReceiptFormatScript { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public byte[] Tstamp { get; set; }
        public int? TitleLineBasket { get; set; }

        public TblShowVenue ShowVenue { get; set; }
    }
}
