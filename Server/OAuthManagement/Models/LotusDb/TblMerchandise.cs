using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblMerchandise
    {
        public int ProductId { get; set; }
        public bool AddOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public bool? ExcludeInAutoRollover { get; set; }

        public TblProduct Product { get; set; }
    }
}
