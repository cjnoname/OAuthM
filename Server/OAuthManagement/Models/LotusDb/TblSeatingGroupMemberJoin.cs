using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSeatingGroupMemberJoin
    {
        public int SeatingGroupId { get; set; }
        public int OrganisationCustomerId { get; set; }
        public int AllocationOptionId { get; set; }
        public string AllocationRequest { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModfiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblMember OrganisationCustomer { get; set; }
        public TblSeatingGroup SeatingGroup { get; set; }
    }
}
