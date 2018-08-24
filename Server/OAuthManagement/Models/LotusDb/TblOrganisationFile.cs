using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOrganisationFile
    {
        public TblOrganisationFile()
        {
            TblProductOrganisationFile = new HashSet<TblProductOrganisationFile>();
        }

        public int OrganisationFileId { get; set; }
        public int FileId { get; set; }
        public int OrganisationId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public int OrganisationFileTypeId { get; set; }
        public int? AdvertiseDisplayIndex { get; set; }
        public int? AdvertiseIsLive { get; set; }
        public string Url { get; set; }

        public TblFile File { get; set; }
        public TblOrganisation Organisation { get; set; }
        public ICollection<TblProductOrganisationFile> TblProductOrganisationFile { get; set; }
    }
}
