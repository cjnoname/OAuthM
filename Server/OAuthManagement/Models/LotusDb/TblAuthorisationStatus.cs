using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblAuthorisationStatus
    {
        public TblAuthorisationStatus()
        {
            TblBillingRecord = new HashSet<TblBillingRecord>();
            TblInventoryTransaction = new HashSet<TblInventoryTransaction>();
        }

        public string AuthorisationStatusId { get; set; }
        public string Description { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<TblBillingRecord> TblBillingRecord { get; set; }
        public ICollection<TblInventoryTransaction> TblInventoryTransaction { get; set; }
    }
}
