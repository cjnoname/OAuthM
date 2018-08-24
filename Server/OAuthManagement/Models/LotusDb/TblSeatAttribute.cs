using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSeatAttribute
    {
        public int SeatAttributeId { get; set; }
        public int? PackageId { get; set; }
        public int SeatId { get; set; }
        public int? SeatStatusId { get; set; }
        public int? SubscriptionAllocationId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public string OriginErrorKey { get; set; }
        public string OriginErrorAdvice { get; set; }

        public TblPackage Package { get; set; }
        public TblSeat Seat { get; set; }
        public TblSeatStatus SeatStatus { get; set; }
        public TblSubscriptionAllocation SubscriptionAllocation { get; set; }
    }
}
