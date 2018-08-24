using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblShowVenuePriceTable
    {
        public TblShowVenuePriceTable()
        {
            TblPerformancePriceTable = new HashSet<TblPerformancePriceTable>();
            TblPriceTable = new HashSet<TblPriceTable>();
            TblStandardPriceType = new HashSet<TblStandardPriceType>();
        }

        public int ShowVenuePriceTableId { get; set; }
        public int ShowVenueId { get; set; }
        public string PriceTableName { get; set; }
        public string Description { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public byte[] Tstamp { get; set; }

        public TblShowVenue ShowVenue { get; set; }
        public ICollection<TblPerformancePriceTable> TblPerformancePriceTable { get; set; }
        public ICollection<TblPriceTable> TblPriceTable { get; set; }
        public ICollection<TblStandardPriceType> TblStandardPriceType { get; set; }
    }
}
