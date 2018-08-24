using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblTicketLimitUsage
    {
        public TblTicketLimitUsage()
        {
            TblTicketLimitIdentifier = new HashSet<TblTicketLimitIdentifier>();
        }

        public int TicketLimitUsageId { get; set; }
        public int CustomerId { get; set; }
        public int TransactionDate { get; set; }
        public int TransactionNumber { get; set; }
        public int AdmitCount { get; set; }
        public string PerformanceCode { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblCustomer Customer { get; set; }
        public ICollection<TblTicketLimitIdentifier> TblTicketLimitIdentifier { get; set; }
    }
}
