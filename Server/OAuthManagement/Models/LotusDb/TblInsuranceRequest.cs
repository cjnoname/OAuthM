using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblInsuranceRequest
    {
        public int InsuranceRequestId { get; set; }
        public int TransactionNumber { get; set; }
        public int TransactionDate { get; set; }
        public string RequestXml { get; set; }
        public int InsuranceTransactionNumber { get; set; }
        public int InsuranceTransactionDate { get; set; }
        public string DemandString { get; set; }
        public bool? RequestFail { get; set; }
        public string ContractNumber { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public string RequestFailMessage { get; set; }
    }
}
