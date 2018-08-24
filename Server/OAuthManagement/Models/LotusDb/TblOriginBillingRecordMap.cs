using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOriginBillingRecordMap
    {
        public TblOriginBillingRecordMap()
        {
            TblBillingRecordReplacedBillingRecord = new HashSet<TblBillingRecord>();
            TblBillingRecordReplacementBilling = new HashSet<TblBillingRecord>();
        }

        public int BillingId { get; set; }
        public int BillingTnum { get; set; }
        public int BillingDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public TblBillingRecord TblBillingRecordBilling { get; set; }
        public ICollection<TblBillingRecord> TblBillingRecordReplacedBillingRecord { get; set; }
        public ICollection<TblBillingRecord> TblBillingRecordReplacementBilling { get; set; }
    }
}
