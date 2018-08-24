using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblTransmissionLog
    {
        public int TransmissionLogId { get; set; }
        public int OrganisationId { get; set; }
        public int TransmissionEntityId { get; set; }
        public DateTime LastBatchTransmissionDate { get; set; }
        public string Message { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public DateTime? TransmissionEndDate { get; set; }

        public TblOrganisation Organisation { get; set; }
        public TblTransmissionEntity TransmissionEntity { get; set; }
    }
}
