using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSeatingPreference
    {
        public TblSeatingPreference()
        {
            TblOrderLineVenuePrefJoin = new HashSet<TblOrderLineVenuePrefJoin>();
        }

        public int SeatingPreferenceId { get; set; }
        public int OrganisationId { get; set; }
        public int ProductCategoryId { get; set; }
        public int VenueId { get; set; }
        public short DisplayIndex { get; set; }
        public string OriginBaa { get; set; }
        public string Description { get; set; }
        public bool Archived { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblOrganisation Organisation { get; set; }
        public TblProductCategory ProductCategory { get; set; }
        public TblVenue Venue { get; set; }
        public ICollection<TblOrderLineVenuePrefJoin> TblOrderLineVenuePrefJoin { get; set; }
    }
}
