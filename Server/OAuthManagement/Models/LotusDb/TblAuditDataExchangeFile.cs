using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblAuditDataExchangeFile
    {
        public int AuditFileId { get; set; }
        public int FileId { get; set; }
        public int MessageTypeId { get; set; }
        public string Filename { get; set; }
        public string Location { get; set; }
        public long FileSize { get; set; }
        public int StatusId { get; set; }
        public int? LogId { get; set; }
        public string Md5checkSum { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public string AuditOperation { get; set; }
        public DateTime AuditDateTime { get; set; }
    }
}
