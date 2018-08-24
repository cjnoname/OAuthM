using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblPhoneType
    {
        public TblPhoneType()
        {
            TblPhone = new HashSet<TblPhone>();
            TblSubscriptionPremiumSms = new HashSet<TblSubscriptionPremiumSms>();
        }

        public int PhoneTypeId { get; set; }
        public string PhoneTypeName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<TblPhone> TblPhone { get; set; }
        public ICollection<TblSubscriptionPremiumSms> TblSubscriptionPremiumSms { get; set; }
    }
}
