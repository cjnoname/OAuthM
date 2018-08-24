using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblMembershipOrganisation
    {
        public TblMembershipOrganisation()
        {
            TblMemberRollover = new HashSet<TblMemberRollover>();
            TblMembershipOrganisationContent = new HashSet<TblMembershipOrganisationContent>();
            TblMembershipPortalAttributeValue = new HashSet<TblMembershipPortalAttributeValue>();
            TblSeatingGroup = new HashSet<TblSeatingGroup>();
        }

        public int OrganisationId { get; set; }
        public bool? AllowGuests { get; set; }
        public short UseNonStandardBookingForm { get; set; }
        public string BookingFormBlurb { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public bool? AllowNewMembers { get; set; }
        public int? CustomerListId { get; set; }
        public int? DefaultMembershipProductId { get; set; }
        public string Afile { get; set; }
        public string MemberNumberPrefix { get; set; }
        public int? MemberNumberSequenceNo { get; set; }
        public bool? AllowMemberChangeDetails { get; set; }
        public bool? EnforceTicketEntitlement { get; set; }
        public bool? UsePrimaryAccounts { get; set; }
        public string TicketAdvertisingBlurb { get; set; }
        public string WaitlistBlurb { get; set; }
        public string BenefitBlurb { get; set; }
        public string ContactUsBlurb { get; set; }
        public short? AcceptPartPayments { get; set; }
        public int? PartPaymentProductId { get; set; }
        public bool? AllowSeatingPreferences { get; set; }
        public string NewsletterBlurb { get; set; }
        public bool? EnableFastRenewals { get; set; }
        public int? OrderProcessTypeId { get; set; }
        public string RenewalsBlurb { get; set; }
        public string SeatingPreferencesBlurb { get; set; }
        public bool? MemberEditOnAllocate { get; set; }
        public bool MenuDirection { get; set; }
        public DateTime? AcceptPartPaymentsUntil { get; set; }
        public bool? ApplyPartPaymentsToRenewalOrder { get; set; }
        public bool? ApplyPartPaymentsToNewOrder { get; set; }
        public bool? UseDirectProcessing { get; set; }
        public int? MembershipOrganisationTypeId { get; set; }
        public short? UseAlternateOrderForm { get; set; }
        public short? UsePrepayments { get; set; }
        public int? MaxBasketOrderLines { get; set; }
        public int? MaxRenewalOrderLines { get; set; }
        public bool? DisableOrderConfirmEmail { get; set; }
        public string ExtRefCode { get; set; }
        public bool? HidePageTitle { get; set; }
        public bool? RecordDeletion { get; set; }
        public bool? HideGuestOptions { get; set; }
        public bool? ShowOrderPaymentSummaryInfo { get; set; }
        public bool? AllowPaxcard { get; set; }
        public int? EnableRollingRenew { get; set; }
        public bool? ForeignBarcode { get; set; }
        public bool? UseOneQtyPerOrderLine { get; set; }
        public bool? MandatoryChannelValidation { get; set; }
        public bool? FullInitCheckedDefaultValue { get; set; }
        public bool? FullInitDisabledDefaultValue { get; set; }
        public bool? PartInitCheckedDefaultValue { get; set; }
        public bool? PartInitDisabledDefaultValue { get; set; }
        public bool? AllowSubsequentPartPrepayments { get; set; }
        public bool? DoNotSaveFailedOrders { get; set; }
        public bool? MemberShopEnabled { get; set; }
        public bool? MemberShopUpSellItems { get; set; }
        public bool? IsCrmenabled { get; set; }
        public bool? IsMembershipsSiteEnabled { get; set; }
        public bool? IsLoginRequired { get; set; }

        public TblCustomerList CustomerList { get; set; }
        public TblMembershipProduct DefaultMembershipProduct { get; set; }
        public TblMembershipOrganisationType MembershipOrganisationType { get; set; }
        public TblOrderProcessType OrderProcessType { get; set; }
        public TblOrganisation Organisation { get; set; }
        public ICollection<TblMemberRollover> TblMemberRollover { get; set; }
        public ICollection<TblMembershipOrganisationContent> TblMembershipOrganisationContent { get; set; }
        public ICollection<TblMembershipPortalAttributeValue> TblMembershipPortalAttributeValue { get; set; }
        public ICollection<TblSeatingGroup> TblSeatingGroup { get; set; }
    }
}
