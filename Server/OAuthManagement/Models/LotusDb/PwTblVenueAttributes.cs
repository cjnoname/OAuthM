using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class PwTblVenueAttributes
    {
        public PwTblVenueAttributes()
        {
            PwTblHiddenVenueAttributes = new HashSet<PwTblHiddenVenueAttributes>();
            PwTblVenueAttributesPerCulture = new HashSet<PwTblVenueAttributesPerCulture>();
        }

        public int VaId { get; set; }
        public int? VaVsid { get; set; }
        public string VaVncode { get; set; }
        public string VaIconImagePath { get; set; }
        public string VaName { get; set; }

        public PwTblVenues VaVncodeNavigation { get; set; }
        public PwTblVenueshows VaVs { get; set; }
        public ICollection<PwTblHiddenVenueAttributes> PwTblHiddenVenueAttributes { get; set; }
        public ICollection<PwTblVenueAttributesPerCulture> PwTblVenueAttributesPerCulture { get; set; }
    }
}
