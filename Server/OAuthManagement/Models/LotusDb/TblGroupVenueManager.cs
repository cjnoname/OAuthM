using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblGroupVenueManager
    {
        public int RecordId { get; set; }
        public int VenueManagerId { get; set; }
        public int AccessLevelId { get; set; }
        public int GroupId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblSysAccessLevel AccessLevel { get; set; }
        public TblSysGroup Group { get; set; }
    }
}
