using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblPerformancePriceType
    {
        public TblPerformancePriceType()
        {
            TblPriceTypeRulePriceType = new HashSet<TblPriceTypeRulePriceType>();
        }

        public int PerformancePriceTypeId { get; set; }
        public int PerformanceId { get; set; }
        public string PriceTypeCode { get; set; }
        public bool IsHold { get; set; }
        public bool ExclusiveToEntitlementGroups { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public PwTblPerformances Performance { get; set; }
        public ICollection<TblPriceTypeRulePriceType> TblPriceTypeRulePriceType { get; set; }
    }
}
