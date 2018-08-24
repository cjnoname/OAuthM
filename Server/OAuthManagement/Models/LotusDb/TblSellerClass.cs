using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSellerClass
    {
        public TblSellerClass()
        {
            TblShowVenueBookingFee = new HashSet<TblShowVenueBookingFee>();
        }

        public int SellerClassId { get; set; }
        public string SellerClassDesc { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<TblShowVenueBookingFee> TblShowVenueBookingFee { get; set; }
    }
}
