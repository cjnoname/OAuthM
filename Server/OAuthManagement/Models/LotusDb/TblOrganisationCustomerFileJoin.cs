using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOrganisationCustomerFileJoin
    {
        public int AttachmentJoinId { get; set; }
        public int FileId { get; set; }
        public int ActivityRecordJoinId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblActivityRecordJoin ActivityRecordJoin { get; set; }
        public TblOrganisationCustomerAttachment File { get; set; }
    }
}
