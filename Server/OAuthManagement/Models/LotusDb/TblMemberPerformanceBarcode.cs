using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblMemberPerformanceBarcode
    {
        public int MemberPerformanceBarcodeId { get; set; }
        public int OrganisationId { get; set; }
        public int OrganisationCustomerId { get; set; }
        public int VenueId { get; set; }
        public int SeasonId { get; set; }
        public int ProductId { get; set; }
        public int? OrderlineId { get; set; }
        public int? SubscriptionAllocationId { get; set; }
        public int? SeatingSourceTransactionDate { get; set; }
        public int? SeatingSourceTransactionNumber { get; set; }
        public string Barcode { get; set; }
        public bool? IsReturned { get; set; }
        public bool? Attended { get; set; }
        public DateTime? AttendedDate { get; set; }
        public DateTime? RequestProcessedDate { get; set; }
        public string ResponseMessage { get; set; }
        public int? RequestFail { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public DateTime? AttendanceRequestProcessedDate { get; set; }
        public string AttendanceResponseMessage { get; set; }
        public int? AttendanceRequestFail { get; set; }
        public string Aisle { get; set; }
        public string Door { get; set; }

        public TblOrganisation Organisation { get; set; }
        public TblOrganisationCustomer OrganisationCustomer { get; set; }
        public TblProduct Product { get; set; }
        public TblSeason Season { get; set; }
        public TblVenue Venue { get; set; }
    }
}
