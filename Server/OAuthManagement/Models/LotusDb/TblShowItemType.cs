using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblShowItemType
    {
        public TblShowItemType()
        {
            TblShowItem = new HashSet<TblShowItem>();
        }

        public int ShowItemTypeId { get; set; }
        public string ShowItemTypeName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<TblShowItem> TblShowItem { get; set; }
    }
}
