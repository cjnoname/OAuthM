using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblMembershipSeat
    {
        public int MembershipSeatId { get; set; }
        public int OrganisationCustomerId { get; set; }
        public int RankingFactorId { get; set; }
        public string Section { get; set; }
        public string Row { get; set; }
        public string Seat { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblOrganisationCustomer OrganisationCustomer { get; set; }
        public TblRankingFactor RankingFactor { get; set; }
    }
}
