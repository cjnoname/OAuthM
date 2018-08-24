using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblVenueManager
    {
        public TblVenueManager()
        {
            TblVenueGroup = new HashSet<TblVenueGroup>();
        }

        public int VenueManagerId { get; set; }
        public int? BusinessId { get; set; }
        public string VenueManagerName { get; set; }
        public string VenueManagerCode { get; set; }
        public string VenueManagerDescription { get; set; }
        public bool Archived { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblBusiness Business { get; set; }
        public ICollection<TblVenueGroup> TblVenueGroup { get; set; }
    }
}
