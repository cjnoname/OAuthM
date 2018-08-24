using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblDataExchangeMessageType
    {
        public TblDataExchangeMessageType()
        {
            TblDataExchangeFile = new HashSet<TblDataExchangeFile>();
        }

        public int MessageTypeId { get; set; }
        public string MessageTypeName { get; set; }
        public int? TransportId { get; set; }
        public string HostDirectory { get; set; }
        public string LocalDirectory { get; set; }
        public bool IsDownload { get; set; }
        public string ConfigMapping { get; set; }
        public string FileMask { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public byte[] Tstamp { get; set; }
        public bool? UseHashValidation { get; set; }
        public string Email { get; set; }

        public TblDataExchangeTransport Transport { get; set; }
        public ICollection<TblDataExchangeFile> TblDataExchangeFile { get; set; }
    }
}
