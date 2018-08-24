using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class PwTblNeutralCultureValues
    {
        public PwTblNeutralCultureValues()
        {
            PwTblPasswordGroupPerCulture = new HashSet<PwTblPasswordGroupPerCulture>();
            PwTblShowCultureAttributes = new HashSet<PwTblShowCultureAttributes>();
            PwTblShowPerCulture = new HashSet<PwTblShowPerCulture>();
            PwTblVenueAttributesPerCulture = new HashSet<PwTblVenueAttributesPerCulture>();
            PwTblVenuesPerCulture = new HashSet<PwTblVenuesPerCulture>();
            PwTblVenueshowsPerCulture = new HashSet<PwTblVenueshowsPerCulture>();
        }

        public string NcvCode { get; set; }
        public string NcvEnglishName { get; set; }
        public bool NcvDefault { get; set; }
        public string NcvSpecificRegionCode { get; set; }

        public ICollection<PwTblPasswordGroupPerCulture> PwTblPasswordGroupPerCulture { get; set; }
        public ICollection<PwTblShowCultureAttributes> PwTblShowCultureAttributes { get; set; }
        public ICollection<PwTblShowPerCulture> PwTblShowPerCulture { get; set; }
        public ICollection<PwTblVenueAttributesPerCulture> PwTblVenueAttributesPerCulture { get; set; }
        public ICollection<PwTblVenuesPerCulture> PwTblVenuesPerCulture { get; set; }
        public ICollection<PwTblVenueshowsPerCulture> PwTblVenueshowsPerCulture { get; set; }
    }
}
