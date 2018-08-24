using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblPriceMarketingType
    {
        public TblPriceMarketingType()
        {
            TblStandardPriceType = new HashSet<TblStandardPriceType>();
        }

        public int PriceMarketingTypeId { get; set; }
        public string PriceMarketingCode { get; set; }
        public string PriceMarketingDescription { get; set; }
        public bool Archived { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<TblStandardPriceType> TblStandardPriceType { get; set; }
    }
}
