using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOrderSalesChannel
    {
        public string OrderSalesChannelId { get; set; }
        public string Description { get; set; }
        public int Sort { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
