using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblAllocationFilterDetails
    {
        public int OrgFilterDetailsId { get; set; }
        public int FilterId { get; set; }
        public string SelectSproc { get; set; }
        public string ProcessSproc { get; set; }
        public string WorkflowStatus { get; set; }
        public string OrderClassification { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public int? IsAuto { get; set; }
        public string ProcessGroup { get; set; }
        public int? IsGroupAllocation { get; set; }
        public int? Timeout { get; set; }

        public TblAllocationFilterDefinition Filter { get; set; }
    }
}
