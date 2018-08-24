using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblRankingFactor
    {
        public TblRankingFactor()
        {
            TblMembershipSeat = new HashSet<TblMembershipSeat>();
            TblProduct = new HashSet<TblProduct>();
        }

        public int RankingFactorId { get; set; }
        public int OrganisationId { get; set; }
        public string RankingFactorName { get; set; }
        public decimal? RankingFactor { get; set; }
        public decimal? BookingFactor { get; set; }
        public decimal? NonBookingFactor { get; set; }
        public decimal? NonAttendanceFactor { get; set; }
        public decimal? PayingGuestFactor { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public int? RankRotationFactor { get; set; }
        public int? MaxRank { get; set; }

        public TblOrganisation Organisation { get; set; }
        public ICollection<TblMembershipSeat> TblMembershipSeat { get; set; }
        public ICollection<TblProduct> TblProduct { get; set; }
    }
}
