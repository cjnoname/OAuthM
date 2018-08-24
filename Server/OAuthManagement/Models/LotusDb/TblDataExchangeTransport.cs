using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblDataExchangeTransport
    {
        public TblDataExchangeTransport()
        {
            TblDataExchangeMessageType = new HashSet<TblDataExchangeMessageType>();
        }

        public int TransportId { get; set; }
        public string TransportName { get; set; }
        public string TransportType { get; set; }
        public string ConnectXml { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public byte[] Tstamp { get; set; }
        public bool IsDisabled { get; set; }

        public ICollection<TblDataExchangeMessageType> TblDataExchangeMessageType { get; set; }
    }
}
