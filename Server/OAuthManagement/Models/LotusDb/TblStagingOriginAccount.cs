using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblStagingOriginAccount
    {
        public decimal RandomUrn { get; set; }
        public string AfileCode { get; set; }
        public int Anum { get; set; }
        public int? AccountTypeCode { get; set; }
        public string AccountTypeName { get; set; }
        public string FullName { get; set; }
        public string SortName { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string CompanyName2 { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Apartment { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string CountryCode { get; set; }
        public string PhoneAreaCode { get; set; }
        public string HomePhone { get; set; }
        public string OtherPhones { get; set; }
        public string DeadFlag { get; set; }
        public string DoNotMailFlag { get; set; }
        public string LeftAddressFlag { get; set; }
        public decimal? PrepaidFunds { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? AlteredDate { get; set; }
        public DateTime? LastTransactedDate { get; set; }
        public DateTime? MemberSince { get; set; }
        public string EmailAddress { get; set; }
        public int? AdmitQty { get; set; }
        public int? SubsQty { get; set; }
        public int? SubsPrevQty { get; set; }
        public decimal? SalesAmt { get; set; }
        public string PrimaryAfileCode { get; set; }
        public int? PrimaryAnum { get; set; }
        public string SubDataFlag { get; set; }
        public string SubName { get; set; }
        public string SubAddress1 { get; set; }
        public string SubAddress2 { get; set; }
        public string SubAddress3 { get; set; }
        public string SubCity { get; set; }
        public string SubZip { get; set; }
        public string SubCountryCode { get; set; }
        public string SiteSpecificAttribute { get; set; }
        public string SubSiteSpecificAttribute { get; set; }
        public string AccountComment { get; set; }
        public string SubComment1 { get; set; }
        public string SubComment2 { get; set; }
        public string SubComment3 { get; set; }
        public string SubComment4 { get; set; }
        public string SubComment5 { get; set; }
        public string SubComment6 { get; set; }
        public string GroupFlag { get; set; }
        public string GroupCategory { get; set; }
        public string MembershipId { get; set; }
        public string MembershipCategory { get; set; }
        public int? MembershipEntitlement { get; set; }
        public string MembershipFinancialFlag { get; set; }
        public string TicketekAdminOnlyFlag { get; set; }
        public string SentToAcxiomFlag { get; set; }
        public string Dummy { get; set; }
    }
}
