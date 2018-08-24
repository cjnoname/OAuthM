using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblInventoryTransactionSource
    {
        public DateTime TransactionDate { get; set; }
        public int TransactionNumber { get; set; }
        public string SourceCode { get; set; }
        public string ReferrerType { get; set; }
        public int? ReferrerId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
    }
}
