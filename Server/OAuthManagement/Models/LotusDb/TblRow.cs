using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblRow
    {
        public TblRow()
        {
            TblSeat = new HashSet<TblSeat>();
        }

        public int RowId { get; set; }
        public int SeasonSeatMapSectionId { get; set; }
        public string RowName { get; set; }
        public int? SequenceNumber { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblSeasonSeatMapSection SeasonSeatMapSection { get; set; }
        public ICollection<TblSeat> TblSeat { get; set; }
    }
}
