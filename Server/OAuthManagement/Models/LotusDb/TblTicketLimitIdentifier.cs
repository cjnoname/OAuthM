using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblTicketLimitIdentifier
    {
        public int TicketLimitIdentifierId { get; set; }
        public int TicketLimitTypeId { get; set; }
        public int TicketLimitUsageId { get; set; }
        public string TicketLimitIdentifier { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblTicketLimitType TicketLimitType { get; set; }
        public TblTicketLimitUsage TicketLimitUsage { get; set; }
    }
}
