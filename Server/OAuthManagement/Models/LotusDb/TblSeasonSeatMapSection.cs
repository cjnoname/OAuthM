using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSeasonSeatMapSection
    {
        public TblSeasonSeatMapSection()
        {
            TblRow = new HashSet<TblRow>();
        }

        public int SeasonSeatMapSectionId { get; set; }
        public int SeasonSeatMapId { get; set; }
        public string SectionName { get; set; }
        public string BestAvailableArea { get; set; }
        public int? Rank { get; set; }
        public int? Rows { get; set; }
        public int? Cols { get; set; }
        public int? LeaveOneSeatPenalty { get; set; }
        public int? LeaveThreeSeatsPenalty { get; set; }
        public decimal? RowToSeatRatio { get; set; }
        public int? BestSeatRowSequenceNumber { get; set; }
        public int? BestSeatSeatSequenceNumber { get; set; }
        public bool? IsGasection { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblSeasonSeatMap SeasonSeatMap { get; set; }
        public ICollection<TblRow> TblRow { get; set; }
    }
}
