using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblPriceTypeRule
    {
        public TblPriceTypeRule()
        {
            TblPriceTypeRulePriceType = new HashSet<TblPriceTypeRulePriceType>();
        }

        public int PriceTypeRuleId { get; set; }
        public int PerformanceId { get; set; }
        public string RuleName { get; set; }
        public int MinParentAdmits { get; set; }
        public int MaxChildAdmits { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public PwTblPerformances Performance { get; set; }
        public ICollection<TblPriceTypeRulePriceType> TblPriceTypeRulePriceType { get; set; }
    }
}
