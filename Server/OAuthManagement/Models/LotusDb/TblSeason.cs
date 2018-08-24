using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSeason
    {
        public TblSeason()
        {
            InversePreviousSeason = new HashSet<TblSeason>();
            TblForeignBarcode = new HashSet<TblForeignBarcode>();
            TblMemberPerformanceBarcode = new HashSet<TblMemberPerformanceBarcode>();
            TblMemberRollover = new HashSet<TblMemberRollover>();
            TblOrderDeletion = new HashSet<TblOrderDeletion>();
            TblPartPaymentSchedule = new HashSet<TblPartPaymentSchedule>();
            TblPaymentMasterSchedule = new HashSet<TblPaymentMasterSchedule>();
            TblPaymentSchedule = new HashSet<TblPaymentSchedule>();
            TblProduct = new HashSet<TblProduct>();
            TblSeasonSeatMap = new HashSet<TblSeasonSeatMap>();
            TblSeatZone = new HashSet<TblSeatZone>();
            TblSourcePerformance = new HashSet<TblSourcePerformance>();
        }

        public int SeasonId { get; set; }
        public int OrganisationId { get; set; }
        public string SeasonDescription { get; set; }
        public string SeasonCode { get; set; }
        public DateTime? SeasonEndDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public int? PreviousSeasonId { get; set; }
        public bool? IsCurrent { get; set; }
        public string PrepayEventCode { get; set; }
        public int? OrganisationYearCode { get; set; }
        public string MerchandiseEventCode { get; set; }

        public TblOrganisation Organisation { get; set; }
        public TblSeason PreviousSeason { get; set; }
        public ICollection<TblSeason> InversePreviousSeason { get; set; }
        public ICollection<TblForeignBarcode> TblForeignBarcode { get; set; }
        public ICollection<TblMemberPerformanceBarcode> TblMemberPerformanceBarcode { get; set; }
        public ICollection<TblMemberRollover> TblMemberRollover { get; set; }
        public ICollection<TblOrderDeletion> TblOrderDeletion { get; set; }
        public ICollection<TblPartPaymentSchedule> TblPartPaymentSchedule { get; set; }
        public ICollection<TblPaymentMasterSchedule> TblPaymentMasterSchedule { get; set; }
        public ICollection<TblPaymentSchedule> TblPaymentSchedule { get; set; }
        public ICollection<TblProduct> TblProduct { get; set; }
        public ICollection<TblSeasonSeatMap> TblSeasonSeatMap { get; set; }
        public ICollection<TblSeatZone> TblSeatZone { get; set; }
        public ICollection<TblSourcePerformance> TblSourcePerformance { get; set; }
    }
}
