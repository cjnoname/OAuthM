using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblShowItem
    {
        public TblShowItem()
        {
            TblProtectionItem = new HashSet<TblProtectionItem>();
            TblTicketLimit = new HashSet<TblTicketLimit>();
        }

        public int ShowItemId { get; set; }
        public int ShowItemTypeId { get; set; }
        public int ItemId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public DateTime? ExclusiveStartDate { get; set; }
        public DateTime? ExclusiveEndDate { get; set; }

        public TblShowItemType ShowItemType { get; set; }
        public ICollection<TblProtectionItem> TblProtectionItem { get; set; }
        public ICollection<TblTicketLimit> TblTicketLimit { get; set; }
    }
}
