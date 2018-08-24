using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class InTblUsersGroups
    {
        public int UserId { get; set; }
        public int GroupId { get; set; }

        public InTblGroups Group { get; set; }
        public InTblUsers User { get; set; }
    }
}
