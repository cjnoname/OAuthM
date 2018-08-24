using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblProductCategoryCapacity
    {
        public int ProductId { get; set; }
        public int ProductCategoryId { get; set; }
        public int Capacity { get; set; }
        public int Allocated { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public bool? IsWaitlistExcessOrders { get; set; }

        public TblProduct Product { get; set; }
        public TblProductCategory ProductCategory { get; set; }
    }
}
