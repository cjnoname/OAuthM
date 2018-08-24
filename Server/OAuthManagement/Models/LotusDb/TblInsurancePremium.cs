using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblInsurancePremium
    {
        public int InsurancePremiumId { get; set; }
        public string PerformanceCode { get; set; }
        public string ProductType { get; set; }
        public string ExternalProductId { get; set; }
        public int PriceFrom { get; set; }
        public int PriceTo { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
    }
}
