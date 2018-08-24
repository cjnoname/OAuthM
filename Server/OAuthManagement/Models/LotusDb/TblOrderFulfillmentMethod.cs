using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOrderFulfillmentMethod
    {
        public TblOrderFulfillmentMethod()
        {
            TblProduct = new HashSet<TblProduct>();
        }

        public int OrderFulfilmentMethodId { get; set; }
        public string OrderFulfilmentMethodName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<TblProduct> TblProduct { get; set; }
    }
}
