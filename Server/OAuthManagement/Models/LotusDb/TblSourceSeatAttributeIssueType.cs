using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSourceSeatAttributeIssueType
    {
        public TblSourceSeatAttributeIssueType()
        {
            TblSourceSeatAttribute = new HashSet<TblSourceSeatAttribute>();
            TblSourceSeatAttributeAudit = new HashSet<TblSourceSeatAttributeAudit>();
        }

        public int SourceSeatAttributeIssueTypeId { get; set; }
        public string SourceSeatAttributeIssueTypeName { get; set; }
        public string SourceSeatAttributeIssueTypeCode { get; set; }
        public bool? IsError { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<TblSourceSeatAttribute> TblSourceSeatAttribute { get; set; }
        public ICollection<TblSourceSeatAttributeAudit> TblSourceSeatAttributeAudit { get; set; }
    }
}
