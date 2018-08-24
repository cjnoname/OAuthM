using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSeatZone
    {
        public int OrganisationId { get; set; }
        public int SeasonId { get; set; }
        public string SeatZoneName { get; set; }
        public string SeatZoneDescription { get; set; }
        public string BestAvailableArea { get; set; }
        public string Section { get; set; }
        public bool? Archived { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public int SeatZoneId { get; set; }

        public TblOrganisation Organisation { get; set; }
        public TblSeason Season { get; set; }
    }
}
