using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblProductPricingExtension
    {
        public int ProductPricingExtensionId { get; set; }
        public int ProductPricingId { get; set; }
        public decimal? Price { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ExtRefHoldCode { get; set; }
        public bool? SellerOnly { get; set; }
        public string PromotionCode { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblProductPricing ProductPricing { get; set; }
    }
}
