using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblBusiness
    {
        public TblBusiness()
        {
            TblBusinessContact = new HashSet<TblBusinessContact>();
            TblPromoter = new HashSet<TblPromoter>();
            TblSysGroup = new HashSet<TblSysGroup>();
            TblVenueManager = new HashSet<TblVenueManager>();
        }

        public int BusinessId { get; set; }
        public int? BusinessAddressId { get; set; }
        public string BusinessName { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string BusinessUrl { get; set; }
        public string BusinessNumber { get; set; }
        public string TaxIdnumber { get; set; }
        public string TelephoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<TblBusinessContact> TblBusinessContact { get; set; }
        public ICollection<TblPromoter> TblPromoter { get; set; }
        public ICollection<TblSysGroup> TblSysGroup { get; set; }
        public ICollection<TblVenueManager> TblVenueManager { get; set; }
    }
}
