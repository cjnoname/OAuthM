using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOrderLineMemberShopItem
    {
        public int OrderLineMemberShopItemId { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int OrderLineId { get; set; }
        public DateTime? FullfillDate { get; set; }
        public int? ColorId { get; set; }
        public int? SizeId { get; set; }
        public int? CustomFieldId { get; set; }
        public int? ExtraCustomFieldId { get; set; }
        public string CustomizedText { get; set; }

        public TblOrder1 Order { get; set; }
        public TblOrderLine OrderLine { get; set; }
        public TblProduct Product { get; set; }
    }
}
