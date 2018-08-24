using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblBusinessContact
    {
        public TblBusinessContact()
        {
            TblShowVenuePromoterContact = new HashSet<TblShowVenue>();
            TblShowVenueVenueContact = new HashSet<TblShowVenue>();
        }

        public int BusinessContactId { get; set; }
        public int BusinessId { get; set; }
        public int? BusinessContactRoleId { get; set; }
        public string ContactName { get; set; }
        public string TelephoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblBusiness Business { get; set; }
        public TblBusinessContactRole BusinessContactRole { get; set; }
        public ICollection<TblShowVenue> TblShowVenuePromoterContact { get; set; }
        public ICollection<TblShowVenue> TblShowVenueVenueContact { get; set; }
    }
}
