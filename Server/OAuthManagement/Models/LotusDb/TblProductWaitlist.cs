using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblProductWaitlist
    {
        public int ProductWaitlistId { get; set; }
        public int ProductId { get; set; }
        public int OrganisationId { get; set; }
        public int OrganisationCustomerId { get; set; }
        public int Tickets { get; set; }
        public bool? Sms { get; set; }
        public bool? Mms { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblOrganisation Organisation { get; set; }
        public TblOrganisationCustomer OrganisationCustomer { get; set; }
        public TblProduct Product { get; set; }
    }
}
