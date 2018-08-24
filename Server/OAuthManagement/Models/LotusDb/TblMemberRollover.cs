using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblMemberRollover
    {
        public int MemberRolloverId { get; set; }
        public int OrganisationCustomerId { get; set; }
        public int OrganisationId { get; set; }
        public int SeasonId { get; set; }
        public int SubscriptionId { get; set; }
        public int? PriceTypeId { get; set; }
        public bool? IsSubscribed { get; set; }
        public int? PaymentOption { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public int? RunNumber { get; set; }
        public string FailureMsg { get; set; }
        public string DynamicPricingPriceTypeCode { get; set; }
        public string PaymentOptionCode { get; set; }

        public TblMembershipOrganisation Organisation { get; set; }
        public TblMember OrganisationCustomer { get; set; }
        public TblSeason Season { get; set; }
    }
}
