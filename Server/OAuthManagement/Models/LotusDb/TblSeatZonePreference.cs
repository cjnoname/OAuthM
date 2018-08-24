using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSeatZonePreference
    {
        public TblSeatZonePreference()
        {
            TblMembership = new HashSet<TblMembership>();
        }

        public int SeatZonePreferenceId { get; set; }
        public int OrganisationId { get; set; }
        public string SeatZonePreferenceName { get; set; }
        public string SeatZonePreferenceDescription { get; set; }
        public bool IsDefault { get; set; }
        public bool? Archived { get; set; }

        public TblOrganisation Organisation { get; set; }
        public ICollection<TblMembership> TblMembership { get; set; }
    }
}
