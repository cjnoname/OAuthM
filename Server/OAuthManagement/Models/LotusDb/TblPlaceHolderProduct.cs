﻿using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblPlaceHolderProduct
    {
        public int ProductId { get; set; }
        public DateTime? DisplayTo { get; set; }
        public bool? Mms { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblProduct Product { get; set; }
    }
}
