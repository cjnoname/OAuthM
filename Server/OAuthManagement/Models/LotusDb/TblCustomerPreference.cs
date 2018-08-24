using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblCustomerPreference
    {
        public TblCustomerPreference()
        {
            PwTblCategoriesAndShows = new HashSet<PwTblCategoriesAndShows>();
            PwTblHighlightedRegionsHrControlCategory = new HashSet<PwTblHighlightedRegions>();
            PwTblHighlightedRegionsHrUserCategory = new HashSet<PwTblHighlightedRegions>();
            TblCustomerPreferenceValue = new HashSet<TblCustomerPreferenceValue>();
        }

        public int PreferenceId { get; set; }
        public string PreferenceName { get; set; }
        public bool IsVisible { get; set; }
        public int PublishLevel { get; set; }
        public string Label { get; set; }
        public int ParentId { get; set; }
        public int DisplayOrder { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<PwTblCategoriesAndShows> PwTblCategoriesAndShows { get; set; }
        public ICollection<PwTblHighlightedRegions> PwTblHighlightedRegionsHrControlCategory { get; set; }
        public ICollection<PwTblHighlightedRegions> PwTblHighlightedRegionsHrUserCategory { get; set; }
        public ICollection<TblCustomerPreferenceValue> TblCustomerPreferenceValue { get; set; }
    }
}
