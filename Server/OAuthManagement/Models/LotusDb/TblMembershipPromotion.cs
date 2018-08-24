using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblMembershipPromotion
    {
        public int MembershipPromotionId { get; set; }
        public int OrganisationId { get; set; }
        public int MembershipProductId { get; set; }
        public string PromotionCode { get; set; }
        public string Description { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public int? DurationMonths { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblMembershipProduct MembershipProduct { get; set; }
        public TblOrganisation Organisation { get; set; }
    }
}
