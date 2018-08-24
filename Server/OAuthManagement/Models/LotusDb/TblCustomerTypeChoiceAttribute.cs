using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblCustomerTypeChoiceAttribute
    {
        public TblCustomerTypeChoiceAttribute()
        {
            TblCustomerTypeAttributeValue = new HashSet<TblCustomerTypeAttributeValue>();
        }

        public int ChoiceId { get; set; }
        public int CommonAttributeId { get; set; }
        public string ChoiceName { get; set; }
        public int? DisplayOrder { get; set; }
        public string DisplayLabel { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblCustomerTypeCommonAttribute CommonAttribute { get; set; }
        public ICollection<TblCustomerTypeAttributeValue> TblCustomerTypeAttributeValue { get; set; }
    }
}
