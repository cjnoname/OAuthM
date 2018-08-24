using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOrderLineChoiceAttribute
    {
        public TblOrderLineChoiceAttribute()
        {
            TblOrderLineAttributeValue = new HashSet<TblOrderLineAttributeValue>();
        }

        public int ChoiceId { get; set; }
        public int CommonAttributeId { get; set; }
        public int? DisplayOrder { get; set; }
        public bool? IsEnabled { get; set; }
        public string ChoiceLabel { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblOrderLineCommonAttribute CommonAttribute { get; set; }
        public ICollection<TblOrderLineAttributeValue> TblOrderLineAttributeValue { get; set; }
    }
}
