using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSubscriptionPackageVenue
    {
        public int PackageId { get; set; }
        public int VenueId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblPackage Package { get; set; }
        public TblVenue Venue { get; set; }
    }
}
