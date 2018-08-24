using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSourceSeatAttribute
    {
        public int SourceSeatAttributeId { get; set; }
        public int SeatId { get; set; }
        public int? ProductId { get; set; }
        public int? SourcePerformanceId { get; set; }
        public int? OrganisationCustomerId { get; set; }
        public int? SourceSeatAttributeIssueTypeId { get; set; }
        public int? ParentTransactionDate { get; set; }
        public int? ParentTransactionNum { get; set; }
        public int? TransactionDate { get; set; }
        public int? TransactionNum { get; set; }
        public string Afile { get; set; }
        public int? AccountNumber { get; set; }
        public string ParentProductCode { get; set; }
        public string ProductCode { get; set; }
        public string PcatCode { get; set; }
        public string PriceTypeCode { get; set; }
        public string PriceTypeType { get; set; }
        public DateTime? TransDateTime { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public string SourcePerformanceCreationKey { get; set; }
        public DateTime? SourceExportRunDatetime { get; set; }
        public string Comment { get; set; }

        public TblOrganisationCustomer OrganisationCustomer { get; set; }
        public TblPackage Product { get; set; }
        public TblSeat Seat { get; set; }
        public TblSourcePerformance SourcePerformance { get; set; }
        public TblSourceSeatAttributeIssueType SourceSeatAttributeIssueType { get; set; }
    }
}
