﻿using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblCustomerLinkedCustomerAparna
    {
        public int CustomerLinkedCustomerId { get; set; }
        public int CustomerId { get; set; }
        public int LinkedCustomerId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ActivatedDate { get; set; }
        public bool Enabled { get; set; }
    }
}
