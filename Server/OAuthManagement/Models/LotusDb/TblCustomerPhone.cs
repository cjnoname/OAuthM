using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblCustomerPhone
    {
        public int RecordId { get; set; }
        public int CustomerId { get; set; }
        public int? PhoneId { get; set; }
        public bool IsPrimary { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblCustomer Customer { get; set; }
        public TblPhone Phone { get; set; }
    }
}
