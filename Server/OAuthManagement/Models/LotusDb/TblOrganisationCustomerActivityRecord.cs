using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOrganisationCustomerActivityRecord
    {
        public int OrganisationCustomerActivityRecordId { get; set; }
        public int OrganisationCustomerId { get; set; }
        public int OrganisationId { get; set; }
        public int ActivityRecordId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblOrganisationCustomer OrganisationCustomer { get; set; }
    }
}
