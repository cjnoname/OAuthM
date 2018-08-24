﻿using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblDataExchangeVelocityEntitlementPassword
    {
        public int Epid { get; set; }
        public string EntitlementPassword { get; set; }
        public int? EntitlementPasswordId { get; set; }
        public int? EntitlementGroupId { get; set; }
        public string EntitlementGroupCode { get; set; }
        public int EnableFlag { get; set; }
        public int? FileId { get; set; }
        public int? LogId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DefaultEntitlementId { get; set; }
        public int? DisabledReasonId { get; set; }
        public int? EntitlementUsageId { get; set; }
        public byte[] Tstamp { get; set; }
    }
}
