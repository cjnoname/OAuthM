using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblBallotGroupAction
    {
        public int BallotGroupActionId { get; set; }
        public int BallotGroupId { get; set; }
        public string ActionTitle { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblBallotGroup BallotGroup { get; set; }
    }
}
