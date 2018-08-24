using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblMemberRanking
    {
        public int MemberRankingId { get; set; }
        public int OrganisationCustomerId { get; set; }
        public int ProductId { get; set; }
        public int? MemberRank { get; set; }
        public int? NextMemberRank { get; set; }
        public int? ProductBooking { get; set; }
        public int? ProductAttendance { get; set; }
        public int? PreviousMemberRankingId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public int? OriginalMemberRank { get; set; }

        public TblOrganisationCustomer OrganisationCustomer { get; set; }
        public TblProduct Product { get; set; }
    }
}
