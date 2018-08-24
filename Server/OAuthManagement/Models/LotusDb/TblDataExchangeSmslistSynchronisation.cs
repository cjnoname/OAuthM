using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblDataExchangeSmslistSynchronisation
    {
        public int RecordId { get; set; }
        public string PhoneNumber { get; set; }
        public int? CustomerId { get; set; }
        public DateTime ExternalModifiedDate { get; set; }
        public bool IsSubscribed { get; set; }
        public int SubscriptionId { get; set; }
        public int FileId { get; set; }
        public int? CustomerSubscriptionId { get; set; }
        public int? SubscriptionChoiceId { get; set; }
        public int? CustomerPhoneId { get; set; }
        public int? LogId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
