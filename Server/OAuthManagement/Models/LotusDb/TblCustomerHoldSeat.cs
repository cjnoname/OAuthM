using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblCustomerHoldSeat
    {
        public int CustomerHoldSeatId { get; set; }
        public int CustomerHoldId { get; set; }
        public int CustomerHoldSeatStatusId { get; set; }
        public string Section { get; set; }
        public string Row { get; set; }
        public string SeatNumber { get; set; }
        public int AllocationPriority { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModfiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblCustomerHold CustomerHold { get; set; }
        public TblCustomerHoldSeatStatus CustomerHoldSeatStatus { get; set; }
    }
}
