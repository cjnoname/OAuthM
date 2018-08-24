using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblProtectionItemSourcePriceType
    {
        public int ProtectionItemSourcePriceTypeId { get; set; }
        public int ProtectionItemId { get; set; }
        public bool IsAvails { get; set; }
        public string PriceTypeCode { get; set; }
        public int? MaximumNonEntitlementPriceTypeAdmits { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblProtectionItem ProtectionItem { get; set; }
    }
}
