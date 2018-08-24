using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblTimeZoneOffset
    {
        public DateTime UtcstartDateTime { get; set; }
        public DateTime UtcendDateTime { get; set; }
        public string TimeZoneName { get; set; }
        public bool IsDaylightSavingTime { get; set; }
        public short Offset { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
    }
}
