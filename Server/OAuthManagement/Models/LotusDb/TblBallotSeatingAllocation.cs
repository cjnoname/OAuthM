using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblBallotSeatingAllocation
    {
        public int BallotSeatingAllocationId { get; set; }
        public int BallotSeatingChoiceId { get; set; }
        public string PerformanceCode { get; set; }
        public string DemandArea { get; set; }
        public byte AllocationOrder { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblBallotSeatingChoice BallotSeatingChoice { get; set; }
    }
}
