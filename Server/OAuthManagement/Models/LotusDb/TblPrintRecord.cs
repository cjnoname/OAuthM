using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblPrintRecord
    {
        public int PrintTransactionId { get; set; }
        public int OrderId { get; set; }
        public int? PreviousPrintTransactionId { get; set; }
        public int? TransactionId { get; set; }
        public string SellerPrinted { get; set; }
        public bool? IsPickup { get; set; }
        public bool? IsReprint { get; set; }
        public bool? IsEticket { get; set; }
        public string EticketEmail { get; set; }
        public bool? IsPaxCard { get; set; }
        public string PaxOrganisationCode { get; set; }
        public int? FirstPaxCard { get; set; }
        public int? PaxCardYear { get; set; }
        public int? NumberOfPaxCards { get; set; }
        public bool? IsPtrans { get; set; }
        public int? TopsPrinter { get; set; }
        public int? PointNumber { get; set; }
        public string PtransGranted { get; set; }
        public int? PrintByOfflineSeller { get; set; }
        public decimal? PrintSellerCommission { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public DateTime? TransactionDateTime { get; set; }

        public TblOrder Order { get; set; }
        public TblOriginPrintRecordMap PreviousPrintTransaction { get; set; }
        public TblOriginPrintRecordMap PrintTransaction { get; set; }
    }
}
