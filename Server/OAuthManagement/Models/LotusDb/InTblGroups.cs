using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class InTblGroups
    {
        public InTblGroups()
        {
            InTblSeatmapReportAccess = new HashSet<InTblSeatmapReportAccess>();
            InTblShowsAccess = new HashSet<InTblShowsAccess>();
            InTblUsersGroups = new HashSet<InTblUsersGroups>();
            InTblVenueSeatmapSettings = new HashSet<InTblVenueSeatmapSettings>();
            InTblVenueSectionGroup = new HashSet<InTblVenueSectionGroup>();
            InTblWatchlistsAccess = new HashSet<InTblWatchlistsAccess>();
        }

        public int Id { get; set; }
        public int? Type { get; set; }
        public string Groupname { get; set; }
        public string Busid1 { get; set; }
        public string Busid2 { get; set; }
        public string WebPortal { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public DateTime? DtCreate { get; set; }
        public DateTime? DtModify { get; set; }

        public InTblGroupTypes TypeNavigation { get; set; }
        public ICollection<InTblSeatmapReportAccess> InTblSeatmapReportAccess { get; set; }
        public ICollection<InTblShowsAccess> InTblShowsAccess { get; set; }
        public ICollection<InTblUsersGroups> InTblUsersGroups { get; set; }
        public ICollection<InTblVenueSeatmapSettings> InTblVenueSeatmapSettings { get; set; }
        public ICollection<InTblVenueSectionGroup> InTblVenueSectionGroup { get; set; }
        public ICollection<InTblWatchlistsAccess> InTblWatchlistsAccess { get; set; }
    }
}
