using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblProductUpgrade
    {
        public int UpgradeProductId { get; set; }
        public int TargetProductId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public bool? DefaultUpgrade { get; set; }

        public TblProduct TargetProduct { get; set; }
        public TblProduct UpgradeProduct { get; set; }
    }
}
