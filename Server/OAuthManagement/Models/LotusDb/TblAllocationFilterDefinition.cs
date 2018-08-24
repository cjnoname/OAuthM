using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblAllocationFilterDefinition
    {
        public TblAllocationFilterDefinition()
        {
            TblAllocationFilterDetails = new HashSet<TblAllocationFilterDetails>();
            TblAllocationProcessOrganisationJoin = new HashSet<TblAllocationProcessOrganisationJoin>();
        }

        public int FilterId { get; set; }
        public string FilterName { get; set; }
        public string FilterDescription { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<TblAllocationFilterDetails> TblAllocationFilterDetails { get; set; }
        public ICollection<TblAllocationProcessOrganisationJoin> TblAllocationProcessOrganisationJoin { get; set; }
    }
}
