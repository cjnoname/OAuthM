using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class PwTblPasswordGroupPerCulture
    {
        public int PgcPgid { get; set; }
        public string PgcNcvcode { get; set; }
        public string PgcInitialPrompt { get; set; }
        public string PgcFailedPrompt { get; set; }

        public PwTblNeutralCultureValues PgcNcvcodeNavigation { get; set; }
        public PwTblPasswordGroups PgcPg { get; set; }
    }
}
