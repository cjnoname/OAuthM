using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class PwTblAdminRoles
    {
        public PwTblAdminRoles()
        {
            PwTblAdminUsersRoles = new HashSet<PwTblAdminUsersRoles>();
        }

        public int ArId { get; set; }
        public string ArName { get; set; }
        public int ArBitMask { get; set; }

        public ICollection<PwTblAdminUsersRoles> PwTblAdminUsersRoles { get; set; }
    }
}
