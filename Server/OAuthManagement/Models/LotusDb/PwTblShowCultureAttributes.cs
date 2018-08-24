using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class PwTblShowCultureAttributes
    {
        public int ScaId { get; set; }
        public int ScaShid { get; set; }
        public string ScaNcvcode { get; set; }
        public string ScaName { get; set; }
        public string ScaValue { get; set; }

        public PwTblNeutralCultureValues ScaNcvcodeNavigation { get; set; }
        public PwTblShows ScaSh { get; set; }
    }
}
