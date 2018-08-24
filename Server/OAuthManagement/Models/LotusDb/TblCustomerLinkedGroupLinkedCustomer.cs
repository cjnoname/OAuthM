using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblCustomerLinkedGroupLinkedCustomer
    {
        public int CustomerLinkedGroupId { get; set; }
        public int CustomerLinkedCustomerId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }

        public TblCustomerLinkedCustomer CustomerLinkedCustomer { get; set; }
        public TblCustomerLinkedGroup CustomerLinkedGroup { get; set; }
    }
}
