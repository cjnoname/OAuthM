using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class PwTblAdminUsersRoles
    {
        public int AurId { get; set; }
        public int AurAuid { get; set; }
        public int AurArid { get; set; }

        public PwTblAdminRoles AurAr { get; set; }
        public PwTblAdminUsers AurAu { get; set; }
    }
}
