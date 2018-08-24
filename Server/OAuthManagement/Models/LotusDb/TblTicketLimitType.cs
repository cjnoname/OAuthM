using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblTicketLimitType
    {
        public TblTicketLimitType()
        {
            TblTicketLimit = new HashSet<TblTicketLimit>();
            TblTicketLimitIdentifier = new HashSet<TblTicketLimitIdentifier>();
        }

        public int TicketLimitTypeId { get; set; }
        public string TicketLimitTypeName { get; set; }
        public bool? IsGlobal { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<TblTicketLimit> TblTicketLimit { get; set; }
        public ICollection<TblTicketLimitIdentifier> TblTicketLimitIdentifier { get; set; }
    }
}
