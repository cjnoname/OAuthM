using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblPaymentMasterSchedule
    {
        public short PaymentMasterScheduleId { get; set; }
        public int OrganisationId { get; set; }
        public int SeasonId { get; set; }
        public int PaymentGroup { get; set; }
        public string ScheduleName { get; set; }
        public DateTime EffectiveDate { get; set; }
        public short MasterMappingId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblMasterMapping MasterMapping { get; set; }
        public TblOrganisation Organisation { get; set; }
        public TblSeason Season { get; set; }
    }
}
