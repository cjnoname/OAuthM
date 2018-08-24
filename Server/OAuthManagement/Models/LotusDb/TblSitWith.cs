using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSitWith
    {
        public int SitWithId { get; set; }
        public int ProductId { get; set; }
        public int ProductCategoryId { get; set; }
        public int RequestingMemberId { get; set; }
        public int SitWithMemberId { get; set; }
        public DateTime RequestDate { get; set; }
        public short Status { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblProduct Product { get; set; }
        public TblProductCategory ProductCategory { get; set; }
    }
}
