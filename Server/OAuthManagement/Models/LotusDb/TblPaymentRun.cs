using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblPaymentRun
    {
        public int Id { get; set; }
        public int RunId { get; set; }
        public string PaymentType { get; set; }
        public int OrderId { get; set; }
        public bool PartPaymentRun { get; set; }
        public int CreatedBy { get; set; }
        public int CreatedDate { get; set; }
    }
}
