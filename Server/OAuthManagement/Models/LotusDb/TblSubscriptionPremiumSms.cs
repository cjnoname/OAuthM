using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSubscriptionPremiumSms
    {
        public int SubscriptionId { get; set; }
        public int PhoneTypeId { get; set; }
        public string PhoneNumber { get; set; }
        public string ServiceType { get; set; }
        public string Configuration { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public byte[] Tstamp { get; set; }

        public TblPhoneType PhoneType { get; set; }
        public TblSubscription1 Subscription { get; set; }
    }
}
