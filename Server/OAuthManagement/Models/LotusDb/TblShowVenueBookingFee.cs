using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblShowVenueBookingFee
    {
        public int BfeeClassId { get; set; }
        public int ShowVenueId { get; set; }
        public int SellerClassId { get; set; }
        public decimal? BfeePerTicket { get; set; }
        public bool? UseSuppBfee { get; set; }
        public int CalculatePerTicketBfee { get; set; }
        public decimal? BfeePerTrans { get; set; }
        public decimal? MinimumBfeePerTrans { get; set; }
        public decimal? MaximumBfeePerTrans { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public byte[] Tstamp { get; set; }

        public TblSellerClass SellerClass { get; set; }
        public TblShowVenue ShowVenue { get; set; }
    }
}
