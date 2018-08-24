using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblAllocationProcessOrganisationJoin
    {
        public int OrganisationId { get; set; }
        public int ProcessingLevel { get; set; }
        public DateTime? EndDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public bool? Live { get; set; }
        public int FilterId { get; set; }
        public int? TypeId { get; set; }

        public TblAllocationFilterDefinition Filter { get; set; }
        public TblOrganisation Organisation { get; set; }
    }
}
