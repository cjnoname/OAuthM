using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblProductPricing
    {
        public TblProductPricing()
        {
            TblProductPricingExtension = new HashSet<TblProductPricingExtension>();
        }

        public int ProductPricingId { get; set; }
        public int PriceTypeId { get; set; }
        public int ProductCategoryId { get; set; }
        public int ProductId { get; set; }
        public decimal? Price { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public string ExtRefHoldCode { get; set; }
        public bool? SellerOnly { get; set; }
        public string PromotionCode { get; set; }
        public bool? IsGacategory { get; set; }

        public TblPriceType PriceType { get; set; }
        public TblProduct Product { get; set; }
        public TblProductCategory ProductCategory { get; set; }
        public ICollection<TblProductPricingExtension> TblProductPricingExtension { get; set; }
    }
}
