using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblTransmissionCredential
    {
        public int TransmissionCredentialId { get; set; }
        public int ApplicationId { get; set; }
        public int OrganisationId { get; set; }
        public int IntegrationSourceId { get; set; }
        public string UserName { get; set; }
        public byte[] Password { get; set; }
        public string SecurityToken { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblSysApplication Application { get; set; }
        public TblTransmissionIntegrationSource IntegrationSource { get; set; }
        public TblOrganisation Organisation { get; set; }
    }
}
