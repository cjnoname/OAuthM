using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOrderClassification
    {
        public int OrderId { get; set; }
        public int OrganisationId { get; set; }
        public int OrderBaseClassificationId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public int? ModifiedBy { get; set; }

        public TblOrder1 Order { get; set; }
        public TblOrderBaseClassification OrderBaseClassification { get; set; }
        public TblOrganisation Organisation { get; set; }
    }
}
