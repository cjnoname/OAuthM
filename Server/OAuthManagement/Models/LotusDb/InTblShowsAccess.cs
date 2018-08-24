using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class InTblShowsAccess
    {
        public int ShowId { get; set; }
        public int GroupId { get; set; }

        public InTblGroups Group { get; set; }
        public InTblShows Show { get; set; }
    }
}
