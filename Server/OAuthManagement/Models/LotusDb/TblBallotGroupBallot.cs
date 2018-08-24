using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblBallotGroupBallot
    {
        public int BallotGroupId { get; set; }
        public int BallotId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblBallot Ballot { get; set; }
        public TblBallotGroup BallotGroup { get; set; }
    }
}
