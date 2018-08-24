using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblDataExchangeStatus
    {
        public TblDataExchangeStatus()
        {
            TblDataExchangeFile = new HashSet<TblDataExchangeFile>();
        }

        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<TblDataExchangeFile> TblDataExchangeFile { get; set; }
    }
}
