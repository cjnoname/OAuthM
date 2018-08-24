using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblMembershipProductPackageJoin
    {
        public int MembershipProductId { get; set; }
        public int PackageId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblMembershipProduct MembershipProduct { get; set; }
        public TblPackage Package { get; set; }
    }
}
