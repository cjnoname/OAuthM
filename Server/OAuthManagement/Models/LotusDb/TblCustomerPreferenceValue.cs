using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblCustomerPreferenceValue
    {
        public int PreferenceValueId { get; set; }
        public int CustomerId { get; set; }
        public int PreferenceId { get; set; }
        public bool? CustomerSelected { get; set; }
        public int Weight { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblCustomer Customer { get; set; }
        public TblCustomerPreference Preference { get; set; }
    }
}
