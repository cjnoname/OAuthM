using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblVenue
    {
        public TblVenue()
        {
            TblMemberPerformanceBarcode = new HashSet<TblMemberPerformanceBarcode>();
            TblOrderLineVenuePrefJoin = new HashSet<TblOrderLineVenuePrefJoin>();
            TblPaxcardAllocation = new HashSet<TblPaxcardAllocation>();
            TblPerformance = new HashSet<TblPerformance>();
            TblSeasonSeatMap = new HashSet<TblSeasonSeatMap>();
            TblSeatingPreference = new HashSet<TblSeatingPreference>();
            TblShowVenue = new HashSet<TblShowVenue>();
            TblSourcePerformancePackageJoin = new HashSet<TblSourcePerformancePackageJoin>();
            TblSubscriptionAllocation = new HashSet<TblSubscriptionAllocation>();
            TblSubscriptionPackageVenue = new HashSet<TblSubscriptionPackageVenue>();
            TblVenueAttribute = new HashSet<TblVenueAttribute>();
            TblVenueGroup = new HashSet<TblVenueGroup>();
        }

        public int VenueId { get; set; }
        public string VenueCode { get; set; }
        public string VenueName { get; set; }
        public string VenueDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool Archive { get; set; }
        public byte[] Tstamp { get; set; }
        public int? VenueAddressId { get; set; }
        public int? RegionId { get; set; }
        public bool? UseTurnstile { get; set; }

        public TblRegion Region { get; set; }
        public TblAddress VenueAddress { get; set; }
        public ICollection<TblMemberPerformanceBarcode> TblMemberPerformanceBarcode { get; set; }
        public ICollection<TblOrderLineVenuePrefJoin> TblOrderLineVenuePrefJoin { get; set; }
        public ICollection<TblPaxcardAllocation> TblPaxcardAllocation { get; set; }
        public ICollection<TblPerformance> TblPerformance { get; set; }
        public ICollection<TblSeasonSeatMap> TblSeasonSeatMap { get; set; }
        public ICollection<TblSeatingPreference> TblSeatingPreference { get; set; }
        public ICollection<TblShowVenue> TblShowVenue { get; set; }
        public ICollection<TblSourcePerformancePackageJoin> TblSourcePerformancePackageJoin { get; set; }
        public ICollection<TblSubscriptionAllocation> TblSubscriptionAllocation { get; set; }
        public ICollection<TblSubscriptionPackageVenue> TblSubscriptionPackageVenue { get; set; }
        public ICollection<TblVenueAttribute> TblVenueAttribute { get; set; }
        public ICollection<TblVenueGroup> TblVenueGroup { get; set; }
    }
}
