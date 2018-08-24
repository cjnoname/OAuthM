using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblCustomerHold
    {
        public TblCustomerHold()
        {
            TblCustomerHoldSeat = new HashSet<TblCustomerHoldSeat>();
        }

        public int CustomerHoldId { get; set; }
        public int CustomerId { get; set; }
        public DateTime PurchaseTransDate { get; set; }
        public int PurchaseTransNum { get; set; }
        public DateTime HoldTransDate { get; set; }
        public int HoldTransNum { get; set; }
        public string ShowCode { get; set; }
        public string VenueCode { get; set; }
        public string PerfCode { get; set; }
        public string Area { get; set; }
        public string PurchasedRzstring { get; set; }
        public DateTime HoldExpiry { get; set; }
        public string HoldPtype { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModfiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblCustomer Customer { get; set; }
        public ICollection<TblCustomerHoldSeat> TblCustomerHoldSeat { get; set; }
    }
}
