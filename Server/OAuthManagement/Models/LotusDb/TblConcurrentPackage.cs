using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblConcurrentPackage
    {
        public int ConcurrentPackageId { get; set; }
        public int SourceProductId { get; set; }
        public int TargetProductId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblPackage SourceProduct { get; set; }
        public TblPackage TargetProduct { get; set; }
    }
}
