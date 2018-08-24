using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblPriceType
    {
        public TblPriceType()
        {
            TblForeignBarcode = new HashSet<TblForeignBarcode>();
            TblOrderLineParentPriceType = new HashSet<TblOrderLine>();
            TblOrderLinePriceType = new HashSet<TblOrderLine>();
            TblPriceTypeMapParentPriceType = new HashSet<TblPriceTypeMap>();
            TblPriceTypeMapPriceType = new HashSet<TblPriceTypeMap>();
            TblPriceTypeMembershipProduct = new HashSet<TblPriceTypeMembershipProduct>();
            TblProductPricing = new HashSet<TblProductPricing>();
            TblShoppingCartItem = new HashSet<TblShoppingCartItem>();
            TblSubscription = new HashSet<TblSubscription>();
        }

        public int PriceTypeId { get; set; }
        public int OrganisationId { get; set; }
        public string PriceTypeCode { get; set; }
        public string PriceTypeName { get; set; }
        public string Description { get; set; }
        public int? AdmitQuantity { get; set; }
        public bool? GuestPriceType { get; set; }
        public bool Archived { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public string ExtRefCode { get; set; }
        public short? DisplayIndex { get; set; }
        public int? ExtRefType { get; set; }
        public string MappingCode { get; set; }
        public bool? IsDefaultForMerchandise { get; set; }

        public TblOrganisation Organisation { get; set; }
        public ICollection<TblForeignBarcode> TblForeignBarcode { get; set; }
        public ICollection<TblOrderLine> TblOrderLineParentPriceType { get; set; }
        public ICollection<TblOrderLine> TblOrderLinePriceType { get; set; }
        public ICollection<TblPriceTypeMap> TblPriceTypeMapParentPriceType { get; set; }
        public ICollection<TblPriceTypeMap> TblPriceTypeMapPriceType { get; set; }
        public ICollection<TblPriceTypeMembershipProduct> TblPriceTypeMembershipProduct { get; set; }
        public ICollection<TblProductPricing> TblProductPricing { get; set; }
        public ICollection<TblShoppingCartItem> TblShoppingCartItem { get; set; }
        public ICollection<TblSubscription> TblSubscription { get; set; }
    }
}
