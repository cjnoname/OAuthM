using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblBallotSeatingChoice
    {
        public TblBallotSeatingChoice()
        {
            TblBallotEntry = new HashSet<TblBallotEntry>();
            TblBallotSeatingAllocation = new HashSet<TblBallotSeatingAllocation>();
        }

        public int BallotSeatingChoiceId { get; set; }
        public int BallotId { get; set; }
        public int RegistrationPriceCategory { get; set; }
        public string SeatingChoiceName { get; set; }
        public bool IsDisabled { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblBallot Ballot { get; set; }
        public ICollection<TblBallotEntry> TblBallotEntry { get; set; }
        public ICollection<TblBallotSeatingAllocation> TblBallotSeatingAllocation { get; set; }
    }
}
