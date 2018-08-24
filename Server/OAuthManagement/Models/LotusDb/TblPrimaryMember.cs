using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblPrimaryMember
    {
        public int PrimaryOrganisationCustomerId { get; set; }
        public int SecondaryOrganisationCustomerId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblMember PrimaryOrganisationCustomer { get; set; }
        public TblMember SecondaryOrganisationCustomer { get; set; }
    }
}
