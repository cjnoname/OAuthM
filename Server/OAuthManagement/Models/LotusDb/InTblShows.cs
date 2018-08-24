using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class InTblShows
    {
        public InTblShows()
        {
            InTblPerformances = new HashSet<InTblPerformances>();
            InTblShowsAccess = new HashSet<InTblShowsAccess>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string S18ShowName { get; set; }
        public string WpShowName { get; set; }
        public DateTime? DtArchive { get; set; }
        public DateTime? DtCreate { get; set; }
        public DateTime? DtModify { get; set; }

        public ICollection<InTblPerformances> InTblPerformances { get; set; }
        public ICollection<InTblShowsAccess> InTblShowsAccess { get; set; }
    }
}
