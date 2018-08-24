using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblPaxcardAllocation
    {
        public TblPaxcardAllocation()
        {
            TblSubscriptionAllocation = new HashSet<TblSubscriptionAllocation>();
        }

        public int PaxcardAllocationId { get; set; }
        public int PaxcardId { get; set; }
        public int VenueId { get; set; }
        public int? SeatingSourceTransactionDate { get; set; }
        public int? SeatingSourceTransactionNumber { get; set; }
        public string GateNumber { get; set; }
        public string BlockNumber { get; set; }
        public string SectionTitleLine { get; set; }
        public string Stair { get; set; }
        public string Aisle { get; set; }
        public string Section { get; set; }
        public string Row { get; set; }
        public string Seat { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblPaxcard Paxcard { get; set; }
        public TblVenue Venue { get; set; }
        public ICollection<TblSubscriptionAllocation> TblSubscriptionAllocation { get; set; }
    }
}
