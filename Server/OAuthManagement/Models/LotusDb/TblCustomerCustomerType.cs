using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblCustomerCustomerType
    {
        public TblCustomerCustomerType()
        {
            TblCustomerTypeAttributeValue = new HashSet<TblCustomerTypeAttributeValue>();
        }

        public int CustomerCustomerTypeId { get; set; }
        public int CustomerTypeId { get; set; }
        public int CustomerId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public TblCustomer Customer { get; set; }
        public TblCustomerType CustomerType { get; set; }
        public ICollection<TblCustomerTypeAttributeValue> TblCustomerTypeAttributeValue { get; set; }
    }
}
