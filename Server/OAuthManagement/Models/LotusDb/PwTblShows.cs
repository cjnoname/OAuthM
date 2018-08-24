using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class PwTblShows
    {
        public PwTblShows()
        {
            InverseShParent = new HashSet<PwTblShows>();
            PwTblCategoriesAndShows = new HashSet<PwTblCategoriesAndShows>();
            PwTblHighlightedShows = new HashSet<PwTblHighlightedShows>();
            PwTblShowAttributes = new HashSet<PwTblShowAttributes>();
            PwTblShowCultureAttributes = new HashSet<PwTblShowCultureAttributes>();
            PwTblShowPerCulture = new HashSet<PwTblShowPerCulture>();
            PwTblSlots = new HashSet<PwTblSlots>();
            PwTblVenueshows = new HashSet<PwTblVenueshows>();
        }

        public int ShId { get; set; }
        public int? ShParentId { get; set; }
        public string ShShvtype { get; set; }
        public string ShSoftixCode { get; set; }
        public DateTime? ShAppearsDate { get; set; }
        public DateTime? ShDisappearsDate { get; set; }
        public string ShSoftixTitle { get; set; }
        public bool ShIsSoldOut { get; set; }
        public string ShSsvname { get; set; }
        public int ShPriority { get; set; }
        public string ShFriendlyName { get; set; }
        public short ShPosition { get; set; }
        public string ShOwncode { get; set; }
        public string ShMarketingTypes { get; set; }

        public PwTblShows ShParent { get; set; }
        public PwTblShowTypeValues ShShvtypeNavigation { get; set; }
        public PwTblShowstatusValues ShSsvnameNavigation { get; set; }
        public ICollection<PwTblShows> InverseShParent { get; set; }
        public ICollection<PwTblCategoriesAndShows> PwTblCategoriesAndShows { get; set; }
        public ICollection<PwTblHighlightedShows> PwTblHighlightedShows { get; set; }
        public ICollection<PwTblShowAttributes> PwTblShowAttributes { get; set; }
        public ICollection<PwTblShowCultureAttributes> PwTblShowCultureAttributes { get; set; }
        public ICollection<PwTblShowPerCulture> PwTblShowPerCulture { get; set; }
        public ICollection<PwTblSlots> PwTblSlots { get; set; }
        public ICollection<PwTblVenueshows> PwTblVenueshows { get; set; }
    }
}
