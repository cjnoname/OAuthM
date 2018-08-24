using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblShowVenuePerformance
    {
        public TblShowVenuePerformance()
        {
            TblPerformancePriceTable = new HashSet<TblPerformancePriceTable>();
        }

        public int ShowVenuePerformanceId { get; set; }
        public int ShowVenueId { get; set; }
        public string EventCode { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public bool Hidden { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public byte[] Tstamp { get; set; }
        public DateTime? PublishDate { get; set; }

        public TblShowVenue ShowVenue { get; set; }
        public ICollection<TblPerformancePriceTable> TblPerformancePriceTable { get; set; }
    }
}
