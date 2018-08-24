using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblTransmissionEntity
    {
        public TblTransmissionEntity()
        {
            TblTransmissionEntityConfig = new HashSet<TblTransmissionEntityConfig>();
            TblTransmissionLog = new HashSet<TblTransmissionLog>();
        }

        public int TransmissionEntityId { get; set; }
        public string TransmissionEntityName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<TblTransmissionEntityConfig> TblTransmissionEntityConfig { get; set; }
        public ICollection<TblTransmissionLog> TblTransmissionLog { get; set; }
    }
}
