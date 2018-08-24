using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblPriceTypeRulePriceType
    {
        public int PriceTypeRuleId { get; set; }
        public int PerformancePriceTypeId { get; set; }
        public bool IsParent { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblPerformancePriceType PerformancePriceType { get; set; }
        public TblPriceTypeRule PriceTypeRule { get; set; }
    }
}
