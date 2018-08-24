using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblFile
    {
        public TblFile()
        {
            TblEventWorksFile = new HashSet<TblEventWorksFile>();
            TblOrganisationFile = new HashSet<TblOrganisationFile>();
        }

        public int FileId { get; set; }
        public string Description { get; set; }
        public string OriginalFileName { get; set; }
        public string FileName { get; set; }
        public int Size { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public ICollection<TblEventWorksFile> TblEventWorksFile { get; set; }
        public ICollection<TblOrganisationFile> TblOrganisationFile { get; set; }
    }
}
