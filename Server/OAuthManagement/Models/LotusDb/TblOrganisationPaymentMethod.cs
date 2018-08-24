using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOrganisationPaymentMethod
    {
        public int OrganisationPaymentId { get; set; }
        public int PaymentMethodId { get; set; }
        public int OrganisationId { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public bool? IsUsableByMembers { get; set; }
        public DateTime CreatedDate { get; set; }
        public int SortOrder { get; set; }

        public TblOrganisation Organisation { get; set; }
        public TblPaymentMethod PaymentMethod { get; set; }
    }
}
