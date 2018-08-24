using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblPartPaymentSchedule
    {
        public int PartPaymentScheduleId { get; set; }
        public int OrganisationId { get; set; }
        public int SeasonId { get; set; }
        public string PaymentGroup { get; set; }
        public int PaymentScheduleNumber { get; set; }
        public int PartPaymentNumber { get; set; }
        public DateTime? PaymentDate { get; set; }
        public decimal? PaymentPercentage { get; set; }
        public bool? FinalPayment { get; set; }
        public string PaymentDescription { get; set; }
        public string OrderClassification { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public byte[] Tstamp { get; set; }

        public TblOrganisation Organisation { get; set; }
        public TblSeason Season { get; set; }
    }
}
