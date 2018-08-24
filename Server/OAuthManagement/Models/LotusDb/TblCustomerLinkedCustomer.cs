using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblCustomerLinkedCustomer
    {
        public TblCustomerLinkedCustomer()
        {
            TblCustomerLinkedGroupLinkedCustomer = new HashSet<TblCustomerLinkedGroupLinkedCustomer>();
        }

        public int CustomerLinkedCustomerId { get; set; }
        public int CustomerId { get; set; }
        public int LinkedCustomerId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ActivatedDate { get; set; }
        public bool? Enabled { get; set; }
        public int? CustomerLinkedCustomerTypeId { get; set; }
        public int? OrganisationId { get; set; }

        public TblCustomer Customer { get; set; }
        public TblCustomer LinkedCustomer { get; set; }
        public TblOrganisation Organisation { get; set; }
        public ICollection<TblCustomerLinkedGroupLinkedCustomer> TblCustomerLinkedGroupLinkedCustomer { get; set; }
    }
}
