using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSeat
    {
        public TblSeat()
        {
            TblSeatAttribute = new HashSet<TblSeatAttribute>();
            TblSourceSeatAttribute = new HashSet<TblSourceSeatAttribute>();
        }

        public int SeatId { get; set; }
        public int RowId { get; set; }
        public string SeatName { get; set; }
        public int? SequenceNumber { get; set; }
        public int? Rank { get; set; }
        public int? PriceCategory { get; set; }
        public bool? IsRightAisle { get; set; }
        public bool? IsLeftAisle { get; set; }
        public bool? IsRightBarrier { get; set; }
        public bool? IsLeftBarrier { get; set; }
        public bool? IsObstructedView { get; set; }
        public bool? IsWheelchairSpace { get; set; }
        public bool? IsWheelchairEscort { get; set; }
        public bool? IsEasyAccess { get; set; }
        public bool? IsUnavailable { get; set; }
        public string InitialOriginState { get; set; }
        public string InititalOriginPriceTypeType { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblRow Row { get; set; }
        public ICollection<TblSeatAttribute> TblSeatAttribute { get; set; }
        public ICollection<TblSourceSeatAttribute> TblSourceSeatAttribute { get; set; }
    }
}
