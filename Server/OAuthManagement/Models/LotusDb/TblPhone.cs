using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblPhone
    {
        public TblPhone()
        {
            TblCustomerPhone = new HashSet<TblCustomerPhone>();
        }

        public int PhoneId { get; set; }
        public int PhoneTypeId { get; set; }
        public string InternationalCode { get; set; }
        public string AreaCode { get; set; }
        public string PhoneNumber { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblPhoneType PhoneType { get; set; }
        public ICollection<TblCustomerPhone> TblCustomerPhone { get; set; }
    }
}
