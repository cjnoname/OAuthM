using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblProductSource
    {
        public TblProductSource()
        {
            TblProduct = new HashSet<TblProduct>();
        }

        public short SourceId { get; set; }
        public string ProductSourceName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public int? AllocationType { get; set; }
        public bool? IsGaseatingSource { get; set; }

        public ICollection<TblProduct> TblProduct { get; set; }
    }
}
