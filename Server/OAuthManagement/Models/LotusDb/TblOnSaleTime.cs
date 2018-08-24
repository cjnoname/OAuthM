using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOnSaleTime
    {
        public int OnSaleTimeId { get; set; }
        public int ShowVenueId { get; set; }
        public int? SalesChannelId { get; set; }
        public string SellerCode { get; set; }
        public string Additive { get; set; }
        public string StartDate { get; set; }
        public string StartTime { get; set; }
        public string EndDate { get; set; }
        public string EndTime { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public byte[] Tstamp { get; set; }

        public TblSalesChannel SalesChannel { get; set; }
        public TblShowVenue ShowVenue { get; set; }
    }
}
