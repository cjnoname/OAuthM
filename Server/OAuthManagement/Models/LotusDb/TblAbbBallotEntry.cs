using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblAbbBallotEntry
    {
        public int BallotEntryId { get; set; }
        public string BallotCode { get; set; }
        public int CustomerId { get; set; }
        public int EntitlementUsageId { get; set; }
        public int EntitlementPasswordId { get; set; }
        public string EventCode { get; set; }
        public int ProtectionGroupId { get; set; }
        public int EntitlementId { get; set; }
        public int Admits { get; set; }
        public int? Ranking { get; set; }
        public double? RandomNumber { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }
    }
}
