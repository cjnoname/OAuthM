using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblCustomerType
    {
        public TblCustomerType()
        {
            TblCustomerCustomerType = new HashSet<TblCustomerCustomerType>();
            TblCustomerTypeAttribute = new HashSet<TblCustomerTypeAttribute>();
            TblGroupCustomerType = new HashSet<TblGroupCustomerType>();
        }

        public int CustomerTypeId { get; set; }
        public string CustomerTypeName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<TblCustomerCustomerType> TblCustomerCustomerType { get; set; }
        public ICollection<TblCustomerTypeAttribute> TblCustomerTypeAttribute { get; set; }
        public ICollection<TblGroupCustomerType> TblGroupCustomerType { get; set; }
    }
}
