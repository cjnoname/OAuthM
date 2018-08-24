using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblBallotGroupEntryBallotEntry
    {
        public int BallotGroupEntryId { get; set; }
        public int BallotEntryId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblBallotEntry BallotEntry { get; set; }
        public TblBallotGroupEntry BallotGroupEntry { get; set; }
    }
}
