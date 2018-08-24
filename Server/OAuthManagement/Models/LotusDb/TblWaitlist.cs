using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblWaitlist
    {
        public TblWaitlist()
        {
            TblCustomerWaitlist = new HashSet<TblCustomerWaitlist>();
        }

        public int WaitlistId { get; set; }
        public int WaitlistChannelId { get; set; }
        public string WaitlistName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsVisible { get; set; }
        public int? NumberOfTickets { get; set; }
        public int? MaxTicketsPerCustomer { get; set; }
        public int NumberOfTicketsWaitlisted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblWaitlistChannel WaitlistChannel { get; set; }
        public ICollection<TblCustomerWaitlist> TblCustomerWaitlist { get; set; }
    }
}
