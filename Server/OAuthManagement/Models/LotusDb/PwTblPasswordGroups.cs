using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class PwTblPasswordGroups
    {
        public PwTblPasswordGroups()
        {
            PwTblPasswordGroupPerCulture = new HashSet<PwTblPasswordGroupPerCulture>();
            PwTblPasswords = new HashSet<PwTblPasswords>();
        }

        public int PgId { get; set; }
        public string PgName { get; set; }
        public DateTime PgDateCreated { get; set; }
        public DateTime PgDateModified { get; set; }

        public ICollection<PwTblPasswordGroupPerCulture> PwTblPasswordGroupPerCulture { get; set; }
        public ICollection<PwTblPasswords> PwTblPasswords { get; set; }
    }
}
