﻿using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblMembershipTicketGenerationLog
    {
        public int LogId { get; set; }
        public int? SubscriptionId { get; set; }
        public int? TicketTypeId { get; set; }
        public bool DeliveryStatus { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblSubscription Subscription { get; set; }
        public TblTicketType TicketType { get; set; }
    }
}
