using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblShowTag
    {
        public int ShowTagId { get; set; }
        public int ShowVenueId { get; set; }
        public int? ShowTagParentId { get; set; }
        public string ShowTag { get; set; }
        public string Description { get; set; }
        public string DescriptionVenue { get; set; }
        public string ShowType { get; set; }
        public string Owner1 { get; set; }
        public string Owner2 { get; set; }
        public string Owner3 { get; set; }
        public string Owner4 { get; set; }
        public bool IsPrimary { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public byte[] Tstamp { get; set; }

        public TblShowVenue ShowVenue { get; set; }
    }
}
