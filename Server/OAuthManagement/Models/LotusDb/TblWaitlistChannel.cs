using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblWaitlistChannel
    {
        public TblWaitlistChannel()
        {
            TblWaitlist = new HashSet<TblWaitlist>();
        }

        public int WaitlistChannelId { get; set; }
        public string WaitlistChannelName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public bool? IsValidateId { get; set; }
        public bool? EnableSelectionOfTickets { get; set; }
        public string CustomerTypeName { get; set; }
        public string AttributeName { get; set; }
        public string EntitlementGroupName { get; set; }

        public ICollection<TblWaitlist> TblWaitlist { get; set; }
    }
}
