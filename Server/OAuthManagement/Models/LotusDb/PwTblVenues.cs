using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class PwTblVenues
    {
        public PwTblVenues()
        {
            PwTblVenueAttributes = new HashSet<PwTblVenueAttributes>();
            PwTblVenuesPerCulture = new HashSet<PwTblVenuesPerCulture>();
            PwTblVenueshows = new HashSet<PwTblVenueshows>();
        }

        public string VnCode { get; set; }
        public string VnOwnerCode { get; set; }
        public string VnWebAddress { get; set; }
        public int? VnOffsetFromBaseTime { get; set; }
        public string VnRegex { get; set; }
        public bool? VnVisible { get; set; }
        public string VnSoftixRegionCode { get; set; }
        public bool? VnEntirelyHidden { get; set; }
        public int? VnGeoFenceRadius { get; set; }

        public ICollection<PwTblVenueAttributes> PwTblVenueAttributes { get; set; }
        public ICollection<PwTblVenuesPerCulture> PwTblVenuesPerCulture { get; set; }
        public ICollection<PwTblVenueshows> PwTblVenueshows { get; set; }
    }
}
