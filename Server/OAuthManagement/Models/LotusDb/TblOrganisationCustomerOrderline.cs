using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOrganisationCustomerOrderline
    {
        public int OrganisationCustomerOrderlineId { get; set; }
        public int OrganisationCustomerId { get; set; }
        public string OrderId { get; set; }
        public string OrderlineId { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public TblOrganisationCustomer OrganisationCustomer { get; set; }
    }
}
