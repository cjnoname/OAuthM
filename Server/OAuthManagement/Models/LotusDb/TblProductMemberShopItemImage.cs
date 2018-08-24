using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblProductMemberShopItemImage
    {
        public int ProductMemberShopItemImageId { get; set; }
        public int ProductId { get; set; }
        public string UniqueId { get; set; }
        public string Name { get; set; }
        public int RowIndex { get; set; }
        public byte[] ImageFull { get; set; }
        public byte[] ImageResized { get; set; }
        public byte[] ImageThumbnail { get; set; }
        public int Size { get; set; }
        public string ContentType { get; set; }
        public string FileExtension { get; set; }

        public TblProduct Product { get; set; }
    }
}
