using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOriginShippingRecordMap
    {
        public TblOriginShippingRecordMap()
        {
            TblBillingRecord = new HashSet<TblBillingRecord>();
        }

        public int ShippingRecordId { get; set; }
        public int ShippingRecordTnum { get; set; }
        public int ShippingRecordDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public TblShippingRecord TblShippingRecord { get; set; }
        public ICollection<TblBillingRecord> TblBillingRecord { get; set; }
    }
}
