using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblActivityType
    {
        public TblActivityType()
        {
            TblActivityTypeAttribute = new HashSet<TblActivityTypeAttribute>();
            TblCustomerActivityRecord = new HashSet<TblCustomerActivityRecord>();
        }

        public int ActivityTypeId { get; set; }
        public string ActivityTypeName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<TblActivityTypeAttribute> TblActivityTypeAttribute { get; set; }
        public ICollection<TblCustomerActivityRecord> TblCustomerActivityRecord { get; set; }
    }
}
