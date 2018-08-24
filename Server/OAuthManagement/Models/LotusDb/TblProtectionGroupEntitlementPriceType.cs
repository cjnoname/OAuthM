using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblProtectionGroupEntitlementPriceType
    {
        public int ProtectionGroupEntitlementId { get; set; }
        public string PriceTypeCode { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblProtectionGroupEntitlement ProtectionGroupEntitlement { get; set; }
    }
}
