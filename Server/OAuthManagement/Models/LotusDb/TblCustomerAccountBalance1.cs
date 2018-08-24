using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblCustomerAccountBalance1
    {
        public int CustomerAccountBalanceId { get; set; }
        public int CustomerId { get; set; }
        public int AccountBalance { get; set; }
        public int Fees { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
