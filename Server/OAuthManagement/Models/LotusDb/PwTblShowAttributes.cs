using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class PwTblShowAttributes
    {
        public int SaId { get; set; }
        public int SaShid { get; set; }
        public string SaName { get; set; }
        public string SaValue { get; set; }

        public PwTblShows SaSh { get; set; }
    }
}
