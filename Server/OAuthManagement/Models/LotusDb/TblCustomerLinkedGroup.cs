using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblCustomerLinkedGroup
    {
        public TblCustomerLinkedGroup()
        {
            TblCustomerLinkedGroupLinkedCustomer = new HashSet<TblCustomerLinkedGroupLinkedCustomer>();
        }

        public int CustomerLinkedGroupId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerLinkedGroupName { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public TblCustomer Customer { get; set; }
        public ICollection<TblCustomerLinkedGroupLinkedCustomer> TblCustomerLinkedGroupLinkedCustomer { get; set; }
    }
}
