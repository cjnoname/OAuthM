using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblBallotGroupRule
    {
        public TblBallotGroupRule()
        {
            TblBallotGroupEntry = new HashSet<TblBallotGroupEntry>();
        }

        public int BallotGroupRuleId { get; set; }
        public int BallotGroupId { get; set; }
        public string SourcePriceType { get; set; }
        public int? MinimumAllocation { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblBallotGroup BallotGroup { get; set; }
        public ICollection<TblBallotGroupEntry> TblBallotGroupEntry { get; set; }
    }
}
