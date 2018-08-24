using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblMasterMapping
    {
        public TblMasterMapping()
        {
            TblPaymentMasterSchedule = new HashSet<TblPaymentMasterSchedule>();
        }

        public short MasterMappingId { get; set; }
        public int OrganisationId { get; set; }
        public string MappingGroup { get; set; }
        public string MappingName { get; set; }
        public string MappingDescription { get; set; }
        public string MappingValue { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblOrganisation Organisation { get; set; }
        public ICollection<TblPaymentMasterSchedule> TblPaymentMasterSchedule { get; set; }
    }
}
