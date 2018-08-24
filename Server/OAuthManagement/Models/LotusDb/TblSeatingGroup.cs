using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSeatingGroup
    {
        public TblSeatingGroup()
        {
            TblOrderLine = new HashSet<TblOrderLine>();
            TblSeatingGroupMemberJoin = new HashSet<TblSeatingGroupMemberJoin>();
        }

        public int SeatingGroupId { get; set; }
        public int OrganisationId { get; set; }
        public int LeaderMemberId { get; set; }
        public string GroupName { get; set; }
        public short WillMove { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public DateTime? RequestProcessedDate { get; set; }
        public string ResponseMessage { get; set; }
        public int? RequestFail { get; set; }

        public TblMember LeaderMember { get; set; }
        public TblMembershipOrganisation Organisation { get; set; }
        public ICollection<TblOrderLine> TblOrderLine { get; set; }
        public ICollection<TblSeatingGroupMemberJoin> TblSeatingGroupMemberJoin { get; set; }
    }
}
