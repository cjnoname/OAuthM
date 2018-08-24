using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class PwTblPerformances
    {
        public PwTblPerformances()
        {
            TblPerformancePriceType = new HashSet<TblPerformancePriceType>();
            TblPriceTypeRule = new HashSet<TblPriceTypeRule>();
        }

        public int PfId { get; set; }
        public int PfVsid { get; set; }
        public string PfPerfCode { get; set; }
        public bool PfIsPlaceHolder { get; set; }
        public bool PfIsSoldOut { get; set; }
        public DateTime? PfOnSaleDate { get; set; }
        public DateTime PfPerformanceDate { get; set; }
        public DateTime? PfOffSaleDate { get; set; }
        public string PfSoftixWho { get; set; }
        public string PfSoftixWhen { get; set; }
        public string PfSoftixWhere { get; set; }
        public int PfTicketLimit { get; set; }
        public string PfPlaceHolderPricing { get; set; }
        public bool? PfIsRetired { get; set; }
        public string PfPaxmasterEventCode { get; set; }

        public PwTblVenueshows PfVs { get; set; }
        public ICollection<TblPerformancePriceType> TblPerformancePriceType { get; set; }
        public ICollection<TblPriceTypeRule> TblPriceTypeRule { get; set; }
    }
}
