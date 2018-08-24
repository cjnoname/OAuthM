using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblPriceTypeMap
    {
        public int PriceTypeMapId { get; set; }
        public int ParentPriceTypeId { get; set; }
        public int PriceTypeId { get; set; }
        public int Quantity { get; set; }
        public bool Archived { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblPriceType ParentPriceType { get; set; }
        public TblPriceType PriceType { get; set; }
    }
}
