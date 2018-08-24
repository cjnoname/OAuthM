using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TicketExtension
    {
        public int TransactionDate { get; set; }
        public int TransactionNumber { get; set; }
        public int Paxnumber { get; set; }
        public string CustomerFirstName { get; set; }
        public string MobilePhoneNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public byte[] Tstamp { get; set; }
        public string CustomerSalutation { get; set; }
        public string CustomerLastName { get; set; }
        public string IdentityNumberType { get; set; }
        public string IdentityNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? TransactionCustomerId { get; set; }
        public int? ClaimantCustomerId { get; set; }
        public bool? Checkin { get; set; }
        public bool? FindMyFriendsOptin { get; set; }
        public int? PerformanceId { get; set; }

        public TblCustomer ClaimantCustomer { get; set; }
        public TblCustomer TransactionCustomer { get; set; }
    }
}
