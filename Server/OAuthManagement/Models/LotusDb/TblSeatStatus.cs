using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSeatStatus
    {
        public TblSeatStatus()
        {
            TblSeatAttribute = new HashSet<TblSeatAttribute>();
        }

        public int SeatStatusId { get; set; }
        public int OrganisationId { get; set; }
        public int SeasonSeatMapId { get; set; }
        public string SeatStatusName { get; set; }
        public bool? IsLocked { get; set; }
        public int? PermissionLevel { get; set; }
        public int? WorkflowStatus { get; set; }
        public string SourceSeatStatusCode { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblOrganisation Organisation { get; set; }
        public TblSeasonSeatMap SeasonSeatMap { get; set; }
        public ICollection<TblSeatAttribute> TblSeatAttribute { get; set; }
    }
}
