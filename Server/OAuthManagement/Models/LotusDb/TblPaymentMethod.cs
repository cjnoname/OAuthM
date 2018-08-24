using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblPaymentMethod
    {
        public TblPaymentMethod()
        {
            TblOrderPaymentHistory = new HashSet<TblOrderPaymentHistory>();
            TblOrganisationPaymentMethod = new HashSet<TblOrganisationPaymentMethod>();
        }

        public int PaymentMethodId { get; set; }
        public string PaymentMethodName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public bool IsOtherPaymentMethod { get; set; }

        public ICollection<TblOrderPaymentHistory> TblOrderPaymentHistory { get; set; }
        public ICollection<TblOrganisationPaymentMethod> TblOrganisationPaymentMethod { get; set; }
    }
}
