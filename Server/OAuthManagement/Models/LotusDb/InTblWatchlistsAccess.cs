using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class InTblWatchlistsAccess
    {
        public int WatchlistId { get; set; }
        public int GroupId { get; set; }

        public InTblGroups Group { get; set; }
        public InTblWatchlists Watchlist { get; set; }
    }
}
