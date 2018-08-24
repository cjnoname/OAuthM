using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblCustomerAddress
    {
        public int RecordId { get; set; }
        public int CustomerId { get; set; }
        public int AddressId { get; set; }
        public bool? IsPrimary { get; set; }
        public bool? IsNoLongerAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblAddress Address { get; set; }
        public TblCustomer Customer { get; set; }
    }
}
