using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblCustomerPasswordReset
    {
        public int CustomerPasswordResetId { get; set; }
        public int CustomerId { get; set; }
        public string ResetToken { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime ExpiresDate { get; set; }
        public DateTime? ConsumedDate { get; set; }
        public string ActionType { get; set; }
    }
}
