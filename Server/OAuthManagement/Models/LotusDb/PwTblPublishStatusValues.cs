using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class PwTblPublishStatusValues
    {
        public PwTblPublishStatusValues()
        {
            PwTblShowPerCulture = new HashSet<PwTblShowPerCulture>();
        }

        public byte PsvId { get; set; }
        public string PsvName { get; set; }
        public string PsvDescription { get; set; }
        public byte PsvOrder { get; set; }

        public ICollection<PwTblShowPerCulture> PwTblShowPerCulture { get; set; }
    }
}
