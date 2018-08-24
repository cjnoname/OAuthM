using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblProductMemberShopItemImageUpload
    {
        public int ProductMemberShopItemUploadId { get; set; }
        public int ProductId { get; set; }
        public string UniqueId { get; set; }
        public byte[] ImageFull { get; set; }
        public byte[] ImageResized { get; set; }
        public byte[] ImageThumbnail { get; set; }
        public string ContentType { get; set; }
        public string FileExtension { get; set; }

        public TblProduct Product { get; set; }
    }
}
