using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class PwTblShowTypeValues
    {
        public PwTblShowTypeValues()
        {
            PwTblShows = new HashSet<PwTblShows>();
        }

        public string ShvType { get; set; }

        public ICollection<PwTblShows> PwTblShows { get; set; }
    }
}
