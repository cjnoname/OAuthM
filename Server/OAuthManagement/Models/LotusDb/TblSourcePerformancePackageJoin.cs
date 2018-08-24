using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSourcePerformancePackageJoin
    {
        public int SourcePerformancePackageJoinId { get; set; }
        public int SourcePerformanceId { get; set; }
        public int ProductId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public int? VenueId { get; set; }

        public TblPackage Product { get; set; }
        public TblSourcePerformance SourcePerformance { get; set; }
        public TblVenue Venue { get; set; }
    }
}
