using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblPromoter
    {
        public TblPromoter()
        {
            TblGroupPromoter = new HashSet<TblGroupPromoter>();
            TblShowVenue = new HashSet<TblShowVenue>();
        }

        public int PromoterId { get; set; }
        public int? BusinessId { get; set; }
        public string PromoterName { get; set; }
        public string PromoterCode { get; set; }
        public string Description { get; set; }
        public bool Archived { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblBusiness Business { get; set; }
        public ICollection<TblGroupPromoter> TblGroupPromoter { get; set; }
        public ICollection<TblShowVenue> TblShowVenue { get; set; }
    }
}
