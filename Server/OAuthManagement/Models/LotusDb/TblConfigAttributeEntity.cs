using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblConfigAttributeEntity
    {
        public TblConfigAttributeEntity()
        {
            TblConfigAttributeStore = new HashSet<TblConfigAttributeStore>();
            TblConfigAttributeUserControl = new HashSet<TblConfigAttributeUserControl>();
            TblConfigAttributeValue = new HashSet<TblConfigAttributeValue>();
        }

        public int EntityId { get; set; }
        public string EntityCode { get; set; }
        public string EntityName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<TblConfigAttributeStore> TblConfigAttributeStore { get; set; }
        public ICollection<TblConfigAttributeUserControl> TblConfigAttributeUserControl { get; set; }
        public ICollection<TblConfigAttributeValue> TblConfigAttributeValue { get; set; }
    }
}
