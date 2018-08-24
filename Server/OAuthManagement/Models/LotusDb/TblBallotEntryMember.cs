using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblBallotEntryMember
    {
        public int BallotEntryMemberId { get; set; }
        public int BallotEntryId { get; set; }
        public int? EntitlementUsageId { get; set; }
        public string MemberIdentifier { get; set; }
        public string PriceType { get; set; }
        public int? RegistrationTransactionDate { get; set; }
        public int? RegistrationTransactionNumber { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public bool? IsReturned { get; set; }
        public bool? IsEntitlementUsageCancelled { get; set; }
        public int Admits { get; set; }
        public string OfferCode { get; set; }

        public TblBallotEntry BallotEntry { get; set; }
    }
}
