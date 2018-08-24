using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOrderBaseClassification
    {
        public TblOrderBaseClassification()
        {
            TblOrderBaseClassificationGroup = new HashSet<TblOrderBaseClassificationGroup>();
            TblOrderClassification = new HashSet<TblOrderClassification>();
            TblOrderlineClassification = new HashSet<TblOrderlineClassification>();
        }

        public int OrderBaseClassificationId { get; set; }
        public string OrderClassificationName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<TblOrderBaseClassificationGroup> TblOrderBaseClassificationGroup { get; set; }
        public ICollection<TblOrderClassification> TblOrderClassification { get; set; }
        public ICollection<TblOrderlineClassification> TblOrderlineClassification { get; set; }
    }
}
