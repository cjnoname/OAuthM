using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOrganisationCustomerAttachment
    {
        public TblOrganisationCustomerAttachment()
        {
            TblOrganisationCustomerFileJoin = new HashSet<TblOrganisationCustomerFileJoin>();
        }

        public int FileId { get; set; }
        public string FileName { get; set; }
        public byte[] FileContent { get; set; }
        public int AttachmentTypeId { get; set; }
        public string ContentType { get; set; }
        public int? ContentLength { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<TblOrganisationCustomerFileJoin> TblOrganisationCustomerFileJoin { get; set; }
    }
}
