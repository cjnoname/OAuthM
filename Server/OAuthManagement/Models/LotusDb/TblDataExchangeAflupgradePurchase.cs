using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblDataExchangeAflupgradePurchase
    {
        public int BarcodeId { get; set; }
        public string Barcode { get; set; }
        public bool IsReturn { get; set; }
        public string DatabaseSource { get; set; }
        public string EventGroupCode { get; set; }
        public string TicketType { get; set; }
        public string PaxMasterEventCode { get; set; }
        public int FileId { get; set; }
        public int? LogId { get; set; }
        public int? EntitlementGroupId { get; set; }
        public int? DefaultEntitlementId { get; set; }
        public int? EntitlementPasswordId { get; set; }
        public int? ProtectionGroupEntitlementId { get; set; }
        public int? ProtectionGroupId { get; set; }
        public int? EntitlementUsageId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public byte[] Tstamp { get; set; }
        public string ForeignEventCode { get; set; }
    }
}
