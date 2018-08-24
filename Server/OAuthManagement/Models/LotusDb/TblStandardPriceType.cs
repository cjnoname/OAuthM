using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblStandardPriceType
    {
        public TblStandardPriceType()
        {
            TblPriceTable = new HashSet<TblPriceTable>();
        }

        public int PriceTypeId { get; set; }
        public int PriceTypeClassId { get; set; }
        public int PriceMarketingTypeId { get; set; }
        public string PriceTypeCode { get; set; }
        public string PriceTypeName { get; set; }
        public string Description { get; set; }
        public string TicketPrintName { get; set; }
        public int? TotalAdmitQuantity { get; set; }
        public int? AdultAdmitQuantity { get; set; }
        public int? ChildAdmitQuantity { get; set; }
        public int? MaxChildAge { get; set; }
        public int? MinChildAge { get; set; }
        public bool IsDefault { get; set; }
        public bool IsStandard { get; set; }
        public bool Archived { get; set; }
        public bool PaxLight { get; set; }
        public bool WheelChairMap { get; set; }
        public bool SingleBfee { get; set; }
        public bool SingleTix { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public int? ShowVenuePriceTableId { get; set; }

        public TblPriceMarketingType PriceMarketingType { get; set; }
        public TblPriceTypeClass PriceTypeClass { get; set; }
        public TblShowVenuePriceTable ShowVenuePriceTable { get; set; }
        public ICollection<TblPriceTable> TblPriceTable { get; set; }
    }
}
