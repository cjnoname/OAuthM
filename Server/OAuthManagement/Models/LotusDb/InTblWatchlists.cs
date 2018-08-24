using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class InTblWatchlists
    {
        public InTblWatchlists()
        {
            InTblWatchlistsAccess = new HashSet<InTblWatchlistsAccess>();
        }

        public int Id { get; set; }
        public int? UserId { get; set; }
        public string Name { get; set; }
        public string Perflist { get; set; }

        public InTblUsers User { get; set; }
        public ICollection<InTblWatchlistsAccess> InTblWatchlistsAccess { get; set; }
    }
}
