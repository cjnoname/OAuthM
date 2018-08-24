using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblShoppingCart
    {
        public int CartId { get; set; }
        public int OrganisationId { get; set; }
        public int? OrganisationCustomerId { get; set; }
        public DateTime ReceivedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblOrganisation Organisation { get; set; }
        public TblOrganisationCustomer OrganisationCustomer { get; set; }
    }
}
