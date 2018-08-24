using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblDeliveryType
    {
        public TblDeliveryType()
        {
            TblShowVenueDispatchTimes = new HashSet<TblShowVenueDispatchTimes>();
        }

        public int DeliveryTypeId { get; set; }
        public string DeliveryType { get; set; }
        public string DeliveryTypeName { get; set; }
        public string DeliveryTypeDesc { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<TblShowVenueDispatchTimes> TblShowVenueDispatchTimes { get; set; }
    }
}
