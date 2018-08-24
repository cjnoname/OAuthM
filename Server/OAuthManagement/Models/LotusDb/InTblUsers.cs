using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class InTblUsers
    {
        public InTblUsers()
        {
            InTblSeatmapReportAccess = new HashSet<InTblSeatmapReportAccess>();
            InTblUsersGroups = new HashSet<InTblUsersGroups>();
            InTblWatchlists = new HashSet<InTblWatchlists>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Passwd { get; set; }
        public decimal? Locked { get; set; }
        public DateTime? LastLogin { get; set; }
        public DateTime? PasswdExpires { get; set; }
        public decimal? PasswdFailCount { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int? LatestWatchlistId { get; set; }

        public ICollection<InTblSeatmapReportAccess> InTblSeatmapReportAccess { get; set; }
        public ICollection<InTblUsersGroups> InTblUsersGroups { get; set; }
        public ICollection<InTblWatchlists> InTblWatchlists { get; set; }
    }
}
