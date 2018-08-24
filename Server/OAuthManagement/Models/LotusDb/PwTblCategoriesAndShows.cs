using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class PwTblCategoriesAndShows
    {
        public int CtshCtid { get; set; }
        public int CtshShid { get; set; }
        public int? CtshPosition { get; set; }
        public int CtshPriority { get; set; }

        public TblCustomerPreference CtshCt { get; set; }
        public PwTblShows CtshSh { get; set; }
    }
}
