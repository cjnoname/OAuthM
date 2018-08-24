using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblWorkflowOrganisation
    {
        public int OrganisationId { get; set; }
        public int WorkflowGroupTypeId { get; set; }
        public int WorkflowTypeId { get; set; }
        public int WorkflowId { get; set; }
        public int ProcessingLevel { get; set; }
        public bool? Live { get; set; }
        public DateTime? EndDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblOrganisation Organisation { get; set; }
        public TblWorkflowGroupType WorkflowGroupType { get; set; }
        public TblWorkflowType WorkflowType { get; set; }
    }
}
