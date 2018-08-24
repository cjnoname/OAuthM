using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOrderGuestInfo
    {
        public int OrderLineId { get; set; }
        public bool? PartAlloc { get; set; }
        public bool? SitWith { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblOrderLine OrderLine { get; set; }
    }
}
