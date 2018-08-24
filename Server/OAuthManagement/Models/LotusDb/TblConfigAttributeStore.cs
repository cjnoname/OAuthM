using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblConfigAttributeStore
    {
        public int ApplicationId { get; set; }
        public int EntityId { get; set; }
        public string AttributeGroupName { get; set; }
        public string DisplayGroupName { get; set; }
        public string Description { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblSysApplication Application { get; set; }
        public TblConfigAttributeEntity Entity { get; set; }
    }
}
