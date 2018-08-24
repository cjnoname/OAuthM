using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblBallotProcessStatus
    {
        public TblBallotProcessStatus()
        {
            TblBallotEntry = new HashSet<TblBallotEntry>();
        }

        public int BallotProcessStatusId { get; set; }
        public string BallotProcessStatusName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<TblBallotEntry> TblBallotEntry { get; set; }
    }
}
