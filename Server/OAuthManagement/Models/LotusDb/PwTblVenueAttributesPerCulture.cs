using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class PwTblVenueAttributesPerCulture
    {
        public int VacVaid { get; set; }
        public string VacNcvcode { get; set; }
        public string VacCategoryTitle { get; set; }
        public string VacName { get; set; }
        public string VacDescription { get; set; }

        public PwTblNeutralCultureValues VacNcvcodeNavigation { get; set; }
        public PwTblVenueAttributes VacVa { get; set; }
    }
}
