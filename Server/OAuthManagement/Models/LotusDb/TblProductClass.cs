using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblProductClass
    {
        public TblProductClass()
        {
            TblProduct = new HashSet<TblProduct>();
        }

        public int ProductClassId { get; set; }
        public string ProductClassName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<TblProduct> TblProduct { get; set; }
    }
}
