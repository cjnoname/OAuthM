using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblShowVenue
    {
        public TblShowVenue()
        {
            TblNotification = new HashSet<TblNotification>();
            TblOnSaleTime = new HashSet<TblOnSaleTime>();
            TblShowInformation = new HashSet<TblShowInformation>();
            TblShowTag = new HashSet<TblShowTag>();
            TblShowTime = new HashSet<TblShowTime>();
            TblShowVenueBookingFee = new HashSet<TblShowVenueBookingFee>();
            TblShowVenueDispatchTimes = new HashSet<TblShowVenueDispatchTimes>();
            TblShowVenuePerformance = new HashSet<TblShowVenuePerformance>();
            TblShowVenuePriceCategory = new HashSet<TblShowVenuePriceCategory>();
            TblShowVenuePriceTable = new HashSet<TblShowVenuePriceTable>();
            TblShowVenueTicketFormat = new HashSet<TblShowVenueTicketFormat>();
            TblShowVenueTicketLine = new HashSet<TblShowVenueTicketLine>();
            TblVenuePolicy = new HashSet<TblVenuePolicy>();
            TblVenueSeatMap = new HashSet<TblVenueSeatMap>();
        }

        public int ShowVenueId { get; set; }
        public int PromoterId { get; set; }
        public int VenueId { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public byte[] Tstamp { get; set; }
        public string ShowTitle { get; set; }
        public int? PromoterContactId { get; set; }
        public int? VenueContactId { get; set; }

        public TblPromoter Promoter { get; set; }
        public TblBusinessContact PromoterContact { get; set; }
        public TblVenue Venue { get; set; }
        public TblBusinessContact VenueContact { get; set; }
        public ICollection<TblNotification> TblNotification { get; set; }
        public ICollection<TblOnSaleTime> TblOnSaleTime { get; set; }
        public ICollection<TblShowInformation> TblShowInformation { get; set; }
        public ICollection<TblShowTag> TblShowTag { get; set; }
        public ICollection<TblShowTime> TblShowTime { get; set; }
        public ICollection<TblShowVenueBookingFee> TblShowVenueBookingFee { get; set; }
        public ICollection<TblShowVenueDispatchTimes> TblShowVenueDispatchTimes { get; set; }
        public ICollection<TblShowVenuePerformance> TblShowVenuePerformance { get; set; }
        public ICollection<TblShowVenuePriceCategory> TblShowVenuePriceCategory { get; set; }
        public ICollection<TblShowVenuePriceTable> TblShowVenuePriceTable { get; set; }
        public ICollection<TblShowVenueTicketFormat> TblShowVenueTicketFormat { get; set; }
        public ICollection<TblShowVenueTicketLine> TblShowVenueTicketLine { get; set; }
        public ICollection<TblVenuePolicy> TblVenuePolicy { get; set; }
        public ICollection<TblVenueSeatMap> TblVenueSeatMap { get; set; }
    }
}
