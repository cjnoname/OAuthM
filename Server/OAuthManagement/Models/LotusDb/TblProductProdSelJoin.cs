﻿using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblProductProdSelJoin
    {
        public int ProductSelectionId { get; set; }
        public int ProductId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public bool? SelectedByDefault { get; set; }

        public TblProduct Product { get; set; }
        public TblProductSelection ProductSelection { get; set; }
    }
}