using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblShowVenueDispatchTimes
    {
        public int DispatchTimeId { get; set; }
        public int ShowVenueId { get; set; }
        public int DeliveryTypeId { get; set; }
        public bool? AllowWeb { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public byte[] Tstamp { get; set; }
        public string StartDate { get; set; }
        public string StartTime { get; set; }
        public string StopDate { get; set; }
        public string StopTime { get; set; }

        public TblDeliveryType DeliveryType { get; set; }
        public TblShowVenue ShowVenue { get; set; }
    }
}
