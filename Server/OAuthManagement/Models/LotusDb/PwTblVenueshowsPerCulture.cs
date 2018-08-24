using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class PwTblVenueshowsPerCulture
    {
        public int VscVsid { get; set; }
        public string VscNcvcode { get; set; }
        public string VscCategoryNameOverride { get; set; }
        public string VscSeatingMap { get; set; }

        public PwTblNeutralCultureValues VscNcvcodeNavigation { get; set; }
        public PwTblVenueshows VscVs { get; set; }
    }
}
