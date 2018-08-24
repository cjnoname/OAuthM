using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblTicketLimit
    {
        public int TicketLimitId { get; set; }
        public int TicketLimitTypeId { get; set; }
        public int? ShowItemId { get; set; }
        public int MaximumAdmits { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblShowItem ShowItem { get; set; }
        public TblTicketLimitType TicketLimitType { get; set; }
    }
}
