using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class PwTblHiddenVenueAttributes
    {
        public int HvaVsid { get; set; }
        public int HvaVaidToHide { get; set; }

        public PwTblVenueAttributes HvaVaidToHideNavigation { get; set; }
        public PwTblVenueshows HvaVs { get; set; }
    }
}
