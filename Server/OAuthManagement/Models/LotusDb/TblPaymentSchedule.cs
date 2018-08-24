using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblPaymentSchedule
    {
        public TblPaymentSchedule()
        {
            InversePreviousPaymentRun = new HashSet<TblPaymentSchedule>();
        }

        public int PaymentRunId { get; set; }
        public int OrganisationId { get; set; }
        public int SeasonId { get; set; }
        public int? PaymentRunNumber { get; set; }
        public DateTime? PaymentDate { get; set; }
        public decimal? PaymentPercentage { get; set; }
        public bool? FinalPayment { get; set; }
        public int? PreviousPaymentRunId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public byte[] Tstamp { get; set; }

        public TblOrganisation Organisation { get; set; }
        public TblPaymentSchedule PreviousPaymentRun { get; set; }
        public TblSeason Season { get; set; }
        public ICollection<TblPaymentSchedule> InversePreviousPaymentRun { get; set; }
    }
}
