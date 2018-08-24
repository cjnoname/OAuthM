using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblCustomerActivityRecord
    {
        public TblCustomerActivityRecord()
        {
            TblActivityRecordJoin = new HashSet<TblActivityRecordJoin>();
            TblActivityTypeAttributeValue = new HashSet<TblActivityTypeAttributeValue>();
        }

        public int ActivityRecordId { get; set; }
        public int CustomerId { get; set; }
        public int ActivityTypeId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblActivityType ActivityType { get; set; }
        public TblCustomer Customer { get; set; }
        public ICollection<TblActivityRecordJoin> TblActivityRecordJoin { get; set; }
        public ICollection<TblActivityTypeAttributeValue> TblActivityTypeAttributeValue { get; set; }
    }
}
