using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblTicketType
    {
        public TblTicketType()
        {
            TblMembershipTicketGenerationLog = new HashSet<TblMembershipTicketGenerationLog>();
        }

        public int TicketTypeId { get; set; }
        public string TicketType { get; set; }
        public string Description { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public ICollection<TblMembershipTicketGenerationLog> TblMembershipTicketGenerationLog { get; set; }
    }
}
