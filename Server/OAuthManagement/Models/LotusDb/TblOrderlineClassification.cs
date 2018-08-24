using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOrderlineClassification
    {
        public int OrderlineId { get; set; }
        public int OrganisationId { get; set; }
        public int OrderId { get; set; }
        public int OrderBaseClassificationId { get; set; }
        public int? MemberRank { get; set; }
        public int? ClassificationRank { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblOrder1 Order { get; set; }
        public TblOrderBaseClassification OrderBaseClassification { get; set; }
        public TblOrderLine Orderline { get; set; }
        public TblOrderlineClassification OrderlineNavigation { get; set; }
        public TblOrganisation Organisation { get; set; }
        public TblOrderlineClassification InverseOrderlineNavigation { get; set; }
    }
}
