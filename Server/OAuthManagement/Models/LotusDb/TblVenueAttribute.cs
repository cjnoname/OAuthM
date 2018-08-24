using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblVenueAttribute
    {
        public int AttributeId { get; set; }
        public int VenueId { get; set; }
        public string AttributeName { get; set; }
        public string AttributeValue { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblVenue Venue { get; set; }
    }
}
