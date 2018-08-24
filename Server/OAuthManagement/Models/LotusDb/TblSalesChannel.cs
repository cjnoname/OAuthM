using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSalesChannel
    {
        public TblSalesChannel()
        {
            TblOnSaleTime = new HashSet<TblOnSaleTime>();
        }

        public int SalesChannelId { get; set; }
        public string Description { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<TblOnSaleTime> TblOnSaleTime { get; set; }
    }
}
