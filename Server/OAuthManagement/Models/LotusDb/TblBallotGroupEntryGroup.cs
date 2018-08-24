using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblBallotGroupEntryGroup
    {
        public TblBallotGroupEntryGroup()
        {
            TblBallotGroupEntry = new HashSet<TblBallotGroupEntry>();
        }

        public int BallotGroupEntryGroupId { get; set; }
        public int BallotGroupId { get; set; }
        public int? Instalments { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public decimal? PartPaymentFee { get; set; }

        public TblBallotGroup BallotGroup { get; set; }
        public ICollection<TblBallotGroupEntry> TblBallotGroupEntry { get; set; }
    }
}
