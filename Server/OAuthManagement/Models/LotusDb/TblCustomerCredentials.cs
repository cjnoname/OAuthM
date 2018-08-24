using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblCustomerCredentials
    {
        public int CustomerCredentialsId { get; set; }
        public int CustomerId { get; set; }
        public string ProviderName { get; set; }
        public string ProviderCustomerIdentifier { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public bool IsEnabled { get; set; }

        public TblCustomer Customer { get; set; }
    }
}
