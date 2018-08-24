using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblThirdPartyPaymentDetail
    {
        public int ThirdPartyPaymentDetailId { get; set; }
        public int CustomerId { get; set; }
        public int? OrganisationCustomerId { get; set; }
        public int? OrganisationId { get; set; }
        public string ProviderReference { get; set; }
        public string OrderId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
    }
}
