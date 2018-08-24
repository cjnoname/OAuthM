using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblShoppingCartItem
    {
        public int CartItemId { get; set; }
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int ProductCategoryId { get; set; }
        public int PriceTypeId { get; set; }
        public int UnitQuantity { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public string ProductName { get; set; }
        public int? ShoppingCartProductType { get; set; }
        public int? ColorId { get; set; }
        public int? CustomValueId { get; set; }
        public int? ExtraCustomValueId { get; set; }
        public int? SizeId { get; set; }
        public string CustomizedText { get; set; }

        public TblPriceType PriceType { get; set; }
        public TblProduct Product { get; set; }
        public TblProductCategory ProductCategory { get; set; }
    }
}
