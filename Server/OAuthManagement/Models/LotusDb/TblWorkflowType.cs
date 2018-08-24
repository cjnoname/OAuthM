using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblWorkflowType
    {
        public TblWorkflowType()
        {
            TblWorkflowOrganisation = new HashSet<TblWorkflowOrganisation>();
        }

        public int WorkflowTypeId { get; set; }
        public string WorkflowTypeName { get; set; }
        public string WorkflowTypeDescription { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<TblWorkflowOrganisation> TblWorkflowOrganisation { get; set; }
    }
}
