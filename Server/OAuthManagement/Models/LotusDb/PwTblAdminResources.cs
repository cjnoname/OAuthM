using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class PwTblAdminResources
    {
        public string ArcId { get; set; }
        public string ArcContainerName { get; set; }
        public string ArcDescription { get; set; }
        public int ArcRoleBitMask { get; set; }
        public bool ArcIsContainer { get; set; }
    }
}
