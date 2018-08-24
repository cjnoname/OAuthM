using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class PwTblAdminUsers
    {
        public PwTblAdminUsers()
        {
            PwTblAdminUsersRoles = new HashSet<PwTblAdminUsersRoles>();
        }

        public int AuId { get; set; }
        public string AuUserName { get; set; }
        public string AuPassword { get; set; }

        public ICollection<PwTblAdminUsersRoles> PwTblAdminUsersRoles { get; set; }
    }
}
