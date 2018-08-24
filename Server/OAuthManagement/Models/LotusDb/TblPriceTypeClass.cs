using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblPriceTypeClass
    {
        public TblPriceTypeClass()
        {
            TblStandardPriceType = new HashSet<TblStandardPriceType>();
        }

        public int PriceTypeClassId { get; set; }
        public string PriceTypeClassCode { get; set; }
        public string PriceTypeClassName { get; set; }
        public bool Archived { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<TblStandardPriceType> TblStandardPriceType { get; set; }
    }
}
