using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSeasonSeatMap
    {
        public TblSeasonSeatMap()
        {
            TblSeasonSeatMapSection = new HashSet<TblSeasonSeatMapSection>();
            TblSeatStatus = new HashSet<TblSeatStatus>();
        }

        public int SeasonSeatMapId { get; set; }
        public int VenueId { get; set; }
        public int OrganisationId { get; set; }
        public int SeasonId { get; set; }
        public string SeasonSeatMapName { get; set; }
        public string SeasonSeatMapCode { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public int? ProductId { get; set; }
        public bool? Archived { get; set; }

        public TblOrganisation Organisation { get; set; }
        public TblProduct Product { get; set; }
        public TblSeason Season { get; set; }
        public TblVenue Venue { get; set; }
        public ICollection<TblSeasonSeatMapSection> TblSeasonSeatMapSection { get; set; }
        public ICollection<TblSeatStatus> TblSeatStatus { get; set; }
    }
}
