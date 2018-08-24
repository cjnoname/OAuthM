using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSysGroupType
    {
        public TblSysGroupType()
        {
            TblSysGroup = new HashSet<TblSysGroup>();
        }

        public int GroupTypeId { get; set; }
        public string GroupTypeName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<TblSysGroup> TblSysGroup { get; set; }
    }
}
