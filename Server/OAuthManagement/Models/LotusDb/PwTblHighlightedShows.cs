using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class PwTblHighlightedShows
    {
        public int HsId { get; set; }
        public int HsHrid { get; set; }
        public int HsShid { get; set; }
        public int HsPriority { get; set; }

        public PwTblHighlightedRegions HsHr { get; set; }
        public PwTblShows HsSh { get; set; }
    }
}
