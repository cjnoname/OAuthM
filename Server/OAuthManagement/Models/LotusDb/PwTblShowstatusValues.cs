using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class PwTblShowstatusValues
    {
        public PwTblShowstatusValues()
        {
            PwTblShows = new HashSet<PwTblShows>();
        }

        public string SsvName { get; set; }
        public string SsvDescription { get; set; }

        public ICollection<PwTblShows> PwTblShows { get; set; }
    }
}
