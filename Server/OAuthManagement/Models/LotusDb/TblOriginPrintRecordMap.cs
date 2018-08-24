using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOriginPrintRecordMap
    {
        public TblOriginPrintRecordMap()
        {
            TblPrintRecordPreviousPrintTransaction = new HashSet<TblPrintRecord>();
        }

        public int PrintTransactionId { get; set; }
        public int PrintRecordTnum { get; set; }
        public int PrintRecordDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public TblPrintRecord TblPrintRecordPrintTransaction { get; set; }
        public ICollection<TblPrintRecord> TblPrintRecordPreviousPrintTransaction { get; set; }
    }
}
