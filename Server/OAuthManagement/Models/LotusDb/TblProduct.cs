using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblProduct
    {
        public TblProduct()
        {
            TblForeignBarcode = new HashSet<TblForeignBarcode>();
            TblLinkedFeesFeeProduct = new HashSet<TblLinkedFees>();
            TblLinkedFeesProduct = new HashSet<TblLinkedFees>();
            TblMemberPerformanceBarcode = new HashSet<TblMemberPerformanceBarcode>();
            TblMemberRanking = new HashSet<TblMemberRanking>();
            TblOrderLine = new HashSet<TblOrderLine>();
            TblOrderLineMemberShopItem = new HashSet<TblOrderLineMemberShopItem>();
            TblProdSelProductJoin = new HashSet<TblProdSelProductJoin>();
            TblProductCategoryCapacity = new HashSet<TblProductCategoryCapacity>();
            TblProductMemberShopItem = new HashSet<TblProductMemberShopItem>();
            TblProductMemberShopItemColor = new HashSet<TblProductMemberShopItemColor>();
            TblProductMemberShopItemCustomField = new HashSet<TblProductMemberShopItemCustomField>();
            TblProductMemberShopItemExtraCustomField = new HashSet<TblProductMemberShopItemExtraCustomField>();
            TblProductMemberShopItemImage = new HashSet<TblProductMemberShopItemImage>();
            TblProductMemberShopItemImageUpload = new HashSet<TblProductMemberShopItemImageUpload>();
            TblProductMemberShopItemSize = new HashSet<TblProductMemberShopItemSize>();
            TblProductOrganisationFile = new HashSet<TblProductOrganisationFile>();
            TblProductPricing = new HashSet<TblProductPricing>();
            TblProductProdSelJoin = new HashSet<TblProductProdSelJoin>();
            TblProductUpgradeTargetProduct = new HashSet<TblProductUpgrade>();
            TblProductUpgradeUpgradeProduct = new HashSet<TblProductUpgrade>();
            TblProductWaitlist = new HashSet<TblProductWaitlist>();
            TblSeasonSeatMap = new HashSet<TblSeasonSeatMap>();
            TblShoppingCartItem = new HashSet<TblShoppingCartItem>();
            TblSitWith = new HashSet<TblSitWith>();
            TblSubscription = new HashSet<TblSubscription>();
        }

        public int ProductId { get; set; }
        public int OrganisationId { get; set; }
        public int ProductTypeId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string AncillaryDescription { get; set; }
        public short? SourceId { get; set; }
        public string SourceProductCode { get; set; }
        public bool OnSale { get; set; }
        public DateTime? BookingPeriodStartDate { get; set; }
        public DateTime? BookingPeriodEndDate { get; set; }
        public DateTime? WaitListPeriodStartDate { get; set; }
        public DateTime? WaitListPeriodEndDate { get; set; }
        public bool? DisallowMultipleOrders { get; set; }
        public bool Archived { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public bool? IsSubscription { get; set; }
        public int? ProductClassId { get; set; }
        public int? OrderFulfillmentMethodId { get; set; }
        public short? DisplayIndex { get; set; }
        public string StatusBannerMsg { get; set; }
        public DateTime? VisiblePeriodStartDate { get; set; }
        public DateTime? VisiblePeriodEndDate { get; set; }
        public DateTime? SellerBookingPeriodStartDate { get; set; }
        public DateTime? SellerBookingPeriodEndDate { get; set; }
        public DateTime? SellerWaitlistPeriodStartDate { get; set; }
        public DateTime? SellerWaitlistPeriodEndDate { get; set; }
        public string ConfirmationMessage { get; set; }
        public short? Allocate { get; set; }
        public int? SeasonId { get; set; }
        public int? RankingFactorId { get; set; }
        public int? ParentProductId { get; set; }
        public string ExtRefHoldCode { get; set; }
        public int? DisplayInHeroControl { get; set; }

        public TblOrderFulfillmentMethod OrderFulfillmentMethod { get; set; }
        public TblOrganisation Organisation { get; set; }
        public TblProductClass ProductClass { get; set; }
        public TblProductType ProductType { get; set; }
        public TblRankingFactor RankingFactor { get; set; }
        public TblSeason Season { get; set; }
        public TblProductSource Source { get; set; }
        public TblMandatoryProduct TblMandatoryProduct { get; set; }
        public TblMembershipProduct TblMembershipProduct { get; set; }
        public TblMerchandise TblMerchandise { get; set; }
        public TblPackage TblPackage { get; set; }
        public TblPerformance TblPerformance { get; set; }
        public TblPlaceHolderProduct TblPlaceHolderProduct { get; set; }
        public ICollection<TblForeignBarcode> TblForeignBarcode { get; set; }
        public ICollection<TblLinkedFees> TblLinkedFeesFeeProduct { get; set; }
        public ICollection<TblLinkedFees> TblLinkedFeesProduct { get; set; }
        public ICollection<TblMemberPerformanceBarcode> TblMemberPerformanceBarcode { get; set; }
        public ICollection<TblMemberRanking> TblMemberRanking { get; set; }
        public ICollection<TblOrderLine> TblOrderLine { get; set; }
        public ICollection<TblOrderLineMemberShopItem> TblOrderLineMemberShopItem { get; set; }
        public ICollection<TblProdSelProductJoin> TblProdSelProductJoin { get; set; }
        public ICollection<TblProductCategoryCapacity> TblProductCategoryCapacity { get; set; }
        public ICollection<TblProductMemberShopItem> TblProductMemberShopItem { get; set; }
        public ICollection<TblProductMemberShopItemColor> TblProductMemberShopItemColor { get; set; }
        public ICollection<TblProductMemberShopItemCustomField> TblProductMemberShopItemCustomField { get; set; }
        public ICollection<TblProductMemberShopItemExtraCustomField> TblProductMemberShopItemExtraCustomField { get; set; }
        public ICollection<TblProductMemberShopItemImage> TblProductMemberShopItemImage { get; set; }
        public ICollection<TblProductMemberShopItemImageUpload> TblProductMemberShopItemImageUpload { get; set; }
        public ICollection<TblProductMemberShopItemSize> TblProductMemberShopItemSize { get; set; }
        public ICollection<TblProductOrganisationFile> TblProductOrganisationFile { get; set; }
        public ICollection<TblProductPricing> TblProductPricing { get; set; }
        public ICollection<TblProductProdSelJoin> TblProductProdSelJoin { get; set; }
        public ICollection<TblProductUpgrade> TblProductUpgradeTargetProduct { get; set; }
        public ICollection<TblProductUpgrade> TblProductUpgradeUpgradeProduct { get; set; }
        public ICollection<TblProductWaitlist> TblProductWaitlist { get; set; }
        public ICollection<TblSeasonSeatMap> TblSeasonSeatMap { get; set; }
        public ICollection<TblShoppingCartItem> TblShoppingCartItem { get; set; }
        public ICollection<TblSitWith> TblSitWith { get; set; }
        public ICollection<TblSubscription> TblSubscription { get; set; }
    }
}
