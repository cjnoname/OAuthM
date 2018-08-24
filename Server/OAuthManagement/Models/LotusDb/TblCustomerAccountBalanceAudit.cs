using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblCustomerAccountBalanceAudit
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int PaymentId { get; set; }
        public int Amount { get; set; }
        public DateTime TransactionDateTime { get; set; }
    }
}
