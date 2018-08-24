using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class InTblPerformances
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ecanon { get; set; }
        public int ShowId { get; set; }
        public decimal? Disabled { get; set; }

        public InTblShows Show { get; set; }
    }
}
