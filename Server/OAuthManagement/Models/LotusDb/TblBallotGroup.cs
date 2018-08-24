using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblBallotGroup
    {
        public TblBallotGroup()
        {
            TblBallotGroupAction = new HashSet<TblBallotGroupAction>();
            TblBallotGroupBallot = new HashSet<TblBallotGroupBallot>();
            TblBallotGroupEntryGroup = new HashSet<TblBallotGroupEntryGroup>();
            TblBallotGroupRule = new HashSet<TblBallotGroupRule>();
        }

        public int BallotGroupId { get; set; }
        public int EntitlementId { get; set; }
        public string BallotGroupName { get; set; }
        public string InstalmentsFeePerformanceCode { get; set; }
        public string InstalmentsFeePriceType { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblEntitlement Entitlement { get; set; }
        public ICollection<TblBallotGroupAction> TblBallotGroupAction { get; set; }
        public ICollection<TblBallotGroupBallot> TblBallotGroupBallot { get; set; }
        public ICollection<TblBallotGroupEntryGroup> TblBallotGroupEntryGroup { get; set; }
        public ICollection<TblBallotGroupRule> TblBallotGroupRule { get; set; }
    }
}
