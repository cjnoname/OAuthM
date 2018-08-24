using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblBallot
    {
        public TblBallot()
        {
            TblBallotAction = new HashSet<TblBallotAction>();
            TblBallotEntry = new HashSet<TblBallotEntry>();
            TblBallotGroupBallot = new HashSet<TblBallotGroupBallot>();
            TblBallotPriorityBand = new HashSet<TblBallotPriorityBand>();
            TblBallotSeatingChoice = new HashSet<TblBallotSeatingChoice>();
        }

        public int BallotId { get; set; }
        public string BallotName { get; set; }
        public bool IsRandom { get; set; }
        public bool ReturnFailedEntries { get; set; }
        public string FailedCreditCardHold { get; set; }
        public bool UseRegistrationPriceType { get; set; }
        public string SellerCode { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public string AllocateToHold { get; set; }
        public bool IgnoreNoAllocationOrder { get; set; }
        public bool AllowNonEfpentries { get; set; }

        public ICollection<TblBallotAction> TblBallotAction { get; set; }
        public ICollection<TblBallotEntry> TblBallotEntry { get; set; }
        public ICollection<TblBallotGroupBallot> TblBallotGroupBallot { get; set; }
        public ICollection<TblBallotPriorityBand> TblBallotPriorityBand { get; set; }
        public ICollection<TblBallotSeatingChoice> TblBallotSeatingChoice { get; set; }
    }
}
