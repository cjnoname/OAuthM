using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblPriceTable
    {
        public int ShowVenuePriceTableId { get; set; }
        public int ShowVenuePriceCategoryId { get; set; }
        public int PriceTypeId { get; set; }
        public string Intersection { get; set; }
        public int? PrivilegeLevel { get; set; }
        public bool? WebAccess { get; set; }
        public decimal? PromoterNetPrice { get; set; }
        public decimal? InsideCharge { get; set; }
        public decimal? Tax { get; set; }
        public decimal? TicketPrice { get; set; }
        public decimal? BookingFee { get; set; }
        public string TicketPrintPrice { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public byte[] Tstamp { get; set; }
        public string PromotionCode { get; set; }

        public TblStandardPriceType PriceType { get; set; }
        public TblShowVenuePriceCategory ShowVenuePriceCategory { get; set; }
        public TblShowVenuePriceTable ShowVenuePriceTable { get; set; }
    }
}
