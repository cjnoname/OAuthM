using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblRegion
    {
        public TblRegion()
        {
            TblVenue = new HashSet<TblVenue>();
        }

        public int RegionId { get; set; }
        public string RegionCode { get; set; }
        public string Name { get; set; }
        public string TimezoneName { get; set; }
        public int CountryId { get; set; }

        public TblCountry Country { get; set; }
        public ICollection<TblVenue> TblVenue { get; set; }
    }
}
