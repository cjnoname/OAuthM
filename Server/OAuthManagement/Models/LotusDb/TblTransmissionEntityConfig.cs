using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblTransmissionEntityConfig
    {
        public int TransmissionEntityConfigId { get; set; }
        public int OrganisationId { get; set; }
        public int TransmissionEntityId { get; set; }
        public int RegularSleepTime { get; set; }
        public int GoToSleepAfterSuccesssiveFailedSubmitCount { get; set; }
        public string TransmitBetweenStartTime { get; set; }
        public string TransmitBetweenEndTime { get; set; }
        public string DoNotTransmitBetweenStartTime { get; set; }
        public string DoNotTransmitBetweenEndTime { get; set; }
        public int LimitBatchSize { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblOrganisation Organisation { get; set; }
        public TblTransmissionEntity TransmissionEntity { get; set; }
    }
}
