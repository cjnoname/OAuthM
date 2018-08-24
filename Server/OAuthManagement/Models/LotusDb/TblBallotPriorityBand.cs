using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblBallotPriorityBand
    {
        public int BallotId { get; set; }
        public byte AllocationOrder { get; set; }
        public string RegistrationPerformanceCode { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public int PriorityBandId { get; set; }

        public TblBallot Ballot { get; set; }
    }
}
