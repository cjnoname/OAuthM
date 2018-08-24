using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class InTblGroupTypes
    {
        public InTblGroupTypes()
        {
            InTblGroups = new HashSet<InTblGroups>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? IsManaged { get; set; }

        public ICollection<InTblGroups> InTblGroups { get; set; }
    }
}
