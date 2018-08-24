using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class PwTblHighlightedRegions
    {
        public PwTblHighlightedRegions()
        {
            PwTblHighlightedShows = new HashSet<PwTblHighlightedShows>();
        }

        public int HrId { get; set; }
        public int HrControlCategoryId { get; set; }
        public int HrUserCategoryId { get; set; }
        public string HrRegionId { get; set; }
        public byte[] Timestamp { get; set; }

        public TblCustomerPreference HrControlCategory { get; set; }
        public TblCustomerPreference HrUserCategory { get; set; }
        public ICollection<PwTblHighlightedShows> PwTblHighlightedShows { get; set; }
    }
}
