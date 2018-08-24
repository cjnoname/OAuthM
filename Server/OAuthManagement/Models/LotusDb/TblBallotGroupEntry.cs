using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblBallotGroupEntry
    {
        public TblBallotGroupEntry()
        {
            TblBallotGroupEntryBallotEntry = new HashSet<TblBallotGroupEntryBallotEntry>();
        }

        public int BallotGroupEntryId { get; set; }
        public int BallotGroupEntryGroupId { get; set; }
        public int BallotGroupRuleId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblBallotGroupEntryGroup BallotGroupEntryGroup { get; set; }
        public TblBallotGroupRule BallotGroupRule { get; set; }
        public ICollection<TblBallotGroupEntryBallotEntry> TblBallotGroupEntryBallotEntry { get; set; }
    }
}
