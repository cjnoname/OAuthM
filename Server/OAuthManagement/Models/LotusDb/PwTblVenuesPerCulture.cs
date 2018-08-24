using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class PwTblVenuesPerCulture
    {
        public string VcVncode { get; set; }
        public string VcNcvcode { get; set; }
        public string VcName { get; set; }
        public int VcPaid { get; set; }
        public string VcRegionName { get; set; }
        public string VcSeatingMap { get; set; }

        public PwTblNeutralCultureValues VcNcvcodeNavigation { get; set; }
        public PwTblVenues VcVncodeNavigation { get; set; }
    }
}
