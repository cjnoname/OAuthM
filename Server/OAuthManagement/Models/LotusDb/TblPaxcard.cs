using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblPaxcard
    {
        public TblPaxcard()
        {
            TblPaxcardAllocation = new HashSet<TblPaxcardAllocation>();
            TblSubscription = new HashSet<TblSubscription>();
        }

        public int PaxcardId { get; set; }
        public int OrganisationId { get; set; }
        public int? OrganisationYearCode { get; set; }
        public int PaxcardNumber { get; set; }
        public string PaxcardBarcode { get; set; }
        public int PaxcardTypeNumber { get; set; }
        public string PaxcardTypeName { get; set; }
        public int? SeasonParentTransactionDate { get; set; }
        public int? SeasonParentTransactionNumber { get; set; }
        public bool? IsReturned { get; set; }
        public bool? IsForeign { get; set; }
        public DateTime? IssuedDate { get; set; }
        public string Afile { get; set; }
        public int? AccountNumber { get; set; }
        public int? OrganisationCustomerId { get; set; }
        public int? ExtractedBy { get; set; }
        public DateTime? ExtractedDate { get; set; }
        public DateTime? RequestProcessedDate { get; set; }
        public int? RequestFail { get; set; }
        public string ResponseMessage { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblOrganisation Organisation { get; set; }
        public TblOrganisationCustomer OrganisationCustomer { get; set; }
        public ICollection<TblPaxcardAllocation> TblPaxcardAllocation { get; set; }
        public ICollection<TblSubscription> TblSubscription { get; set; }
    }
}
