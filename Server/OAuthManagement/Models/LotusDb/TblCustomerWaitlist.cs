using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblCustomerWaitlist
    {
        public int CustomerWaitlistId { get; set; }
        public int CustomerId { get; set; }
        public int WaitlistId { get; set; }
        public int NumberOfTickets { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public bool? IsSubscribed { get; set; }

        public TblCustomer Customer { get; set; }
        public TblWaitlist Waitlist { get; set; }
    }
}
