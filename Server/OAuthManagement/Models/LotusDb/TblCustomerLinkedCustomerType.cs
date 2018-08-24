﻿using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblCustomerLinkedCustomerType
    {
        public int CustomerLinkedCustomerTypeId { get; set; }
        public string CustomerLinkedCustomerTypeName { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
