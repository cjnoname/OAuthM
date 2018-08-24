using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblPackageUmbrellaJoin
    {
        public int PackageUmbrellaJoinId { get; set; }
        public int ProductId { get; set; }
        public int ChildProductId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblPackage ChildProduct { get; set; }
        public TblPackage Product { get; set; }
    }
}
