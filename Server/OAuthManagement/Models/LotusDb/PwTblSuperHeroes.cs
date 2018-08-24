using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class PwTblSuperHeroes
    {
        public int SuperHeroId { get; set; }
        public int OpenDelay { get; set; }
        public int CloseDelay { get; set; }
        public DateTime ActivateAtUtc { get; set; }
        public DateTime DeactivateAtUtc { get; set; }
        public string TimeZoneId { get; set; }
        public int MaxNbrActivations { get; set; }
        public string RegionId { get; set; }
        public string HtmlOpen { get; set; }
        public string HtmlClosed { get; set; }
        public bool Enabled { get; set; }
        public string SuperHeroName { get; set; }
    }
}
