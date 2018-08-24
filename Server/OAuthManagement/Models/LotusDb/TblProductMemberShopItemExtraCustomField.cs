using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblProductMemberShopItemExtraCustomField
    {
        public int ProductMemberShopItemExtraCustomFieldId { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int RowIndex { get; set; }

        public TblProduct Product { get; set; }
    }
}
