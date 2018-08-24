using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOrderLineAllocation
    {
        public int OrderLineId { get; set; }
        public int TransactionDate { get; set; }
        public int TransactionTnum { get; set; }
        public string Section { get; set; }
        public string Row { get; set; }
        public string SeatSpan { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblOrderLine OrderLine { get; set; }
    }
}
