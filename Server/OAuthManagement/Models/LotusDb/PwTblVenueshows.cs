using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class PwTblVenueshows
    {
        public PwTblVenueshows()
        {
            PwTblHiddenVenueAttributes = new HashSet<PwTblHiddenVenueAttributes>();
            PwTblPerformances = new HashSet<PwTblPerformances>();
            PwTblVenueAttributes = new HashSet<PwTblVenueAttributes>();
            PwTblVenueshowsPerCulture = new HashSet<PwTblVenueshowsPerCulture>();
        }

        public int VsId { get; set; }
        public int VsShid { get; set; }
        public string VsVncode { get; set; }
        public bool VsSellByArea { get; set; }

        public PwTblShows VsSh { get; set; }
        public PwTblVenues VsVncodeNavigation { get; set; }
        public ICollection<PwTblHiddenVenueAttributes> PwTblHiddenVenueAttributes { get; set; }
        public ICollection<PwTblPerformances> PwTblPerformances { get; set; }
        public ICollection<PwTblVenueAttributes> PwTblVenueAttributes { get; set; }
        public ICollection<PwTblVenueshowsPerCulture> PwTblVenueshowsPerCulture { get; set; }
    }
}
