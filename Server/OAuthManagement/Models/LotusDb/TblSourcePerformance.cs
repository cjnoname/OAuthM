using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSourcePerformance
    {
        public TblSourcePerformance()
        {
            TblSourcePerformancePackageJoin = new HashSet<TblSourcePerformancePackageJoin>();
            TblSourceSeatAttribute = new HashSet<TblSourceSeatAttribute>();
        }

        public int SourcePerformanceId { get; set; }
        public int SeasonId { get; set; }
        public string ProductCode { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public int? SeasonSeatMapId { get; set; }

        public TblSeason Season { get; set; }
        public ICollection<TblSourcePerformancePackageJoin> TblSourcePerformancePackageJoin { get; set; }
        public ICollection<TblSourceSeatAttribute> TblSourceSeatAttribute { get; set; }
    }
}
