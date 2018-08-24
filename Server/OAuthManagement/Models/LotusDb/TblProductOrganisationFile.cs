using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblProductOrganisationFile
    {
        public int ProductOrganisationFileId { get; set; }
        public int OrganisationFileId { get; set; }
        public int ProductId { get; set; }
        public string ProductFileType { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public int? ProductFileUsageType { get; set; }

        public TblOrganisationFile OrganisationFile { get; set; }
        public TblProduct Product { get; set; }
    }
}
