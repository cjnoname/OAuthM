﻿using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOrderProcessType
    {
        public TblOrderProcessType()
        {
            TblMembershipOrganisation = new HashSet<TblMembershipOrganisation>();
        }

        public int OrderProcessTypeId { get; set; }
        public string OrderProcessTypeName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<TblMembershipOrganisation> TblMembershipOrganisation { get; set; }
    }
}
