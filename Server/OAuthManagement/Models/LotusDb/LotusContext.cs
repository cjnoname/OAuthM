using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OAuthManagement.Models.LotusDb
{
    public partial class LotusContext : DbContext
    {
        public LotusContext(DbContextOptions<LotusContext> options) : base(options)
        {
        }

        public virtual DbSet<BaseTable> BaseTable { get; set; }
        public virtual DbSet<InTblAuditLog> InTblAuditLog { get; set; }
        public virtual DbSet<InTblGroups> InTblGroups { get; set; }
        public virtual DbSet<InTblGroupTypes> InTblGroupTypes { get; set; }
        public virtual DbSet<InTblJournalMonitor> InTblJournalMonitor { get; set; }
        public virtual DbSet<InTblPerformances> InTblPerformances { get; set; }
        public virtual DbSet<InTblSalesHistory> InTblSalesHistory { get; set; }
        public virtual DbSet<InTblSeatmapReportAccess> InTblSeatmapReportAccess { get; set; }
        public virtual DbSet<InTblShows> InTblShows { get; set; }
        public virtual DbSet<InTblShowsAccess> InTblShowsAccess { get; set; }
        public virtual DbSet<InTblUsers> InTblUsers { get; set; }
        public virtual DbSet<InTblUsersGroups> InTblUsersGroups { get; set; }
        public virtual DbSet<InTblVenueSeatmapSettings> InTblVenueSeatmapSettings { get; set; }
        public virtual DbSet<InTblVenueSectionGroup> InTblVenueSectionGroup { get; set; }
        public virtual DbSet<InTblWatchlists> InTblWatchlists { get; set; }
        public virtual DbSet<InTblWatchlistsAccess> InTblWatchlistsAccess { get; set; }
        public virtual DbSet<Logs> Logs { get; set; }
        public virtual DbSet<Logs1> Logs1 { get; set; }
        public virtual DbSet<Member> Member { get; set; }
        public virtual DbSet<MemberAparna> MemberAparna { get; set; }
        public virtual DbSet<MemberTest> MemberTest { get; set; }
        public virtual DbSet<MosaicGroup> MosaicGroup { get; set; }
        public virtual DbSet<MosaicLink> MosaicLink { get; set; }
        public virtual DbSet<MosaicType> MosaicType { get; set; }
        public virtual DbSet<PwTblAdminResources> PwTblAdminResources { get; set; }
        public virtual DbSet<PwTblAdminRoles> PwTblAdminRoles { get; set; }
        public virtual DbSet<PwTblAdminUsers> PwTblAdminUsers { get; set; }
        public virtual DbSet<PwTblAdminUsersRoles> PwTblAdminUsersRoles { get; set; }
        public virtual DbSet<PwTblCategoriesAndShows> PwTblCategoriesAndShows { get; set; }
        public virtual DbSet<PwTblFiles> PwTblFiles { get; set; }
        public virtual DbSet<PwTblHiddenVenueAttributes> PwTblHiddenVenueAttributes { get; set; }
        public virtual DbSet<PwTblHighlightedRegions> PwTblHighlightedRegions { get; set; }
        public virtual DbSet<PwTblHighlightedShows> PwTblHighlightedShows { get; set; }
        public virtual DbSet<PwTblNeutralCultureValues> PwTblNeutralCultureValues { get; set; }
        public virtual DbSet<PwTblPasswordGroupPerCulture> PwTblPasswordGroupPerCulture { get; set; }
        public virtual DbSet<PwTblPasswordGroups> PwTblPasswordGroups { get; set; }
        public virtual DbSet<PwTblPasswords> PwTblPasswords { get; set; }
        public virtual DbSet<PwTblPerformances> PwTblPerformances { get; set; }
        public virtual DbSet<PwTblPhysicalAddresses> PwTblPhysicalAddresses { get; set; }
        public virtual DbSet<PwTblPublishStatusValues> PwTblPublishStatusValues { get; set; }
        public virtual DbSet<PwTblScheduledBoxContent> PwTblScheduledBoxContent { get; set; }
        public virtual DbSet<PwTblSeasonPerformances> PwTblSeasonPerformances { get; set; }
        public virtual DbSet<PwTblSeasonPerformancesCulture> PwTblSeasonPerformancesCulture { get; set; }
        public virtual DbSet<PwTblSessionState> PwTblSessionState { get; set; }
        public virtual DbSet<PwTblSharedStore> PwTblSharedStore { get; set; }
        public virtual DbSet<PwTblShowAttributes> PwTblShowAttributes { get; set; }
        public virtual DbSet<PwTblShowCultureAttributes> PwTblShowCultureAttributes { get; set; }
        public virtual DbSet<PwTblShowPerCulture> PwTblShowPerCulture { get; set; }
        public virtual DbSet<PwTblShows> PwTblShows { get; set; }
        public virtual DbSet<PwTblShowstatusValues> PwTblShowstatusValues { get; set; }
        public virtual DbSet<PwTblShowTypeValues> PwTblShowTypeValues { get; set; }
        public virtual DbSet<PwTblSlotPerformancePriceCategoryMappings> PwTblSlotPerformancePriceCategoryMappings { get; set; }
        public virtual DbSet<PwTblSlotPerformances> PwTblSlotPerformances { get; set; }
        public virtual DbSet<PwTblSlots> PwTblSlots { get; set; }
        public virtual DbSet<PwTblSlotsCulture> PwTblSlotsCulture { get; set; }
        public virtual DbSet<PwTblSuperHeroes> PwTblSuperHeroes { get; set; }
        public virtual DbSet<PwTblVenueAttributes> PwTblVenueAttributes { get; set; }
        public virtual DbSet<PwTblVenueAttributesPerCulture> PwTblVenueAttributesPerCulture { get; set; }
        public virtual DbSet<PwTblVenues> PwTblVenues { get; set; }
        public virtual DbSet<PwTblVenueshows> PwTblVenueshows { get; set; }
        public virtual DbSet<PwTblVenueshowsPerCulture> PwTblVenueshowsPerCulture { get; set; }
        public virtual DbSet<PwTblVenuesPerCulture> PwTblVenuesPerCulture { get; set; }
        public virtual DbSet<TblAbbBallotEntry> TblAbbBallotEntry { get; set; }
        public virtual DbSet<TblAbbBallotLog> TblAbbBallotLog { get; set; }
        public virtual DbSet<TblActivityRecordJoin> TblActivityRecordJoin { get; set; }
        public virtual DbSet<TblActivityType> TblActivityType { get; set; }
        public virtual DbSet<TblActivityTypeAttribute> TblActivityTypeAttribute { get; set; }
        public virtual DbSet<TblActivityTypeAttributeValue> TblActivityTypeAttributeValue { get; set; }
        public virtual DbSet<TblActivityTypeChoiceAttribute> TblActivityTypeChoiceAttribute { get; set; }
        public virtual DbSet<TblActivityTypeCommonAttribute> TblActivityTypeCommonAttribute { get; set; }
        public virtual DbSet<TblAddress> TblAddress { get; set; }
        public virtual DbSet<TblAddressType> TblAddressType { get; set; }
        public virtual DbSet<TblAllocationFilterDefinition> TblAllocationFilterDefinition { get; set; }
        public virtual DbSet<TblAllocationFilterDetails> TblAllocationFilterDetails { get; set; }
        public virtual DbSet<TblAllocationProcessOrganisationJoin> TblAllocationProcessOrganisationJoin { get; set; }
        public virtual DbSet<TblAttributeDataType> TblAttributeDataType { get; set; }
        public virtual DbSet<TblAuditDataExchangeFile> TblAuditDataExchangeFile { get; set; }
        public virtual DbSet<TblAuthorisationStatus> TblAuthorisationStatus { get; set; }
        public virtual DbSet<TblAutomaticRenewalPaymentMethod> TblAutomaticRenewalPaymentMethod { get; set; }
        public virtual DbSet<TblBallot> TblBallot { get; set; }
        public virtual DbSet<TblBallotAction> TblBallotAction { get; set; }
        public virtual DbSet<TblBallotEntry> TblBallotEntry { get; set; }
        public virtual DbSet<TblBallotEntryCustomer> TblBallotEntryCustomer { get; set; }
        public virtual DbSet<TblBallotEntryMember> TblBallotEntryMember { get; set; }
        public virtual DbSet<TblBallotGroup> TblBallotGroup { get; set; }
        public virtual DbSet<TblBallotGroupAction> TblBallotGroupAction { get; set; }
        public virtual DbSet<TblBallotGroupBallot> TblBallotGroupBallot { get; set; }
        public virtual DbSet<TblBallotGroupEntry> TblBallotGroupEntry { get; set; }
        public virtual DbSet<TblBallotGroupEntryBallotEntry> TblBallotGroupEntryBallotEntry { get; set; }
        public virtual DbSet<TblBallotGroupEntryGroup> TblBallotGroupEntryGroup { get; set; }
        public virtual DbSet<TblBallotGroupRule> TblBallotGroupRule { get; set; }
        public virtual DbSet<TblBallotPriorityBand> TblBallotPriorityBand { get; set; }
        public virtual DbSet<TblBallotProcessStatus> TblBallotProcessStatus { get; set; }
        public virtual DbSet<TblBallotSeatingAllocation> TblBallotSeatingAllocation { get; set; }
        public virtual DbSet<TblBallotSeatingChoice> TblBallotSeatingChoice { get; set; }
        public virtual DbSet<TblBankAccount> TblBankAccount { get; set; }
        public virtual DbSet<TblBillingRecord> TblBillingRecord { get; set; }
        public virtual DbSet<TblBuildMessage> TblBuildMessage { get; set; }
        public virtual DbSet<TblBuildType> TblBuildType { get; set; }
        public virtual DbSet<TblBusiness> TblBusiness { get; set; }
        public virtual DbSet<TblBusinessContact> TblBusinessContact { get; set; }
        public virtual DbSet<TblBusinessContactRole> TblBusinessContactRole { get; set; }
        public virtual DbSet<TblCardType> TblCardType { get; set; }
        public virtual DbSet<TblConcurrentPackage> TblConcurrentPackage { get; set; }
        public virtual DbSet<TblConfigAttribute> TblConfigAttribute { get; set; }
        public virtual DbSet<TblConfigAttributeControl> TblConfigAttributeControl { get; set; }
        public virtual DbSet<TblConfigAttributeEntity> TblConfigAttributeEntity { get; set; }
        public virtual DbSet<TblConfigAttributeGroup> TblConfigAttributeGroup { get; set; }
        public virtual DbSet<TblConfigAttributeList> TblConfigAttributeList { get; set; }
        public virtual DbSet<TblConfigAttributeOperation> TblConfigAttributeOperation { get; set; }
        public virtual DbSet<TblConfigAttributeStore> TblConfigAttributeStore { get; set; }
        public virtual DbSet<TblConfigAttributeUrl> TblConfigAttributeUrl { get; set; }
        public virtual DbSet<TblConfigAttributeUserControl> TblConfigAttributeUserControl { get; set; }
        public virtual DbSet<TblConfigAttributeValue> TblConfigAttributeValue { get; set; }
        public virtual DbSet<TblContact> TblContact { get; set; }
        public virtual DbSet<TblCountry> TblCountry { get; set; }
        public virtual DbSet<TblCreditCardDetails> TblCreditCardDetails { get; set; }
        public virtual DbSet<TblCustomer> TblCustomer { get; set; }
        public virtual DbSet<TblCustomerAccountBalance> TblCustomerAccountBalance { get; set; }
        public virtual DbSet<TblCustomerAccountBalance1> TblCustomerAccountBalance1 { get; set; }
        public virtual DbSet<TblCustomerAccountBalanceAudit> TblCustomerAccountBalanceAudit { get; set; }
        public virtual DbSet<TblCustomerAccountBalanceJournal> TblCustomerAccountBalanceJournal { get; set; }
        public virtual DbSet<TblCustomerActivityRecord> TblCustomerActivityRecord { get; set; }
        public virtual DbSet<TblCustomerAddress> TblCustomerAddress { get; set; }
        public virtual DbSet<TblCustomerCredentials> TblCustomerCredentials { get; set; }
        public virtual DbSet<TblCustomerCreditCard> TblCustomerCreditCard { get; set; }
        public virtual DbSet<TblCustomerCustomerType> TblCustomerCustomerType { get; set; }
        public virtual DbSet<TblCustomerHold> TblCustomerHold { get; set; }
        public virtual DbSet<TblCustomerHoldSeat> TblCustomerHoldSeat { get; set; }
        public virtual DbSet<TblCustomerHoldSeatStatus> TblCustomerHoldSeatStatus { get; set; }
        public virtual DbSet<TblCustomerLinkedCustomer> TblCustomerLinkedCustomer { get; set; }
        public virtual DbSet<TblCustomerLinkedCustomerAparna> TblCustomerLinkedCustomerAparna { get; set; }
        public virtual DbSet<TblCustomerLinkedCustomerType> TblCustomerLinkedCustomerType { get; set; }
        public virtual DbSet<TblCustomerLinkedGroup> TblCustomerLinkedGroup { get; set; }
        public virtual DbSet<TblCustomerLinkedGroupLinkedCustomer> TblCustomerLinkedGroupLinkedCustomer { get; set; }
        public virtual DbSet<TblCustomerList> TblCustomerList { get; set; }
        public virtual DbSet<TblCustomerPasswordReset> TblCustomerPasswordReset { get; set; }
        public virtual DbSet<TblCustomerPhone> TblCustomerPhone { get; set; }
        public virtual DbSet<TblCustomerPreference> TblCustomerPreference { get; set; }
        public virtual DbSet<TblCustomerPreferenceValue> TblCustomerPreferenceValue { get; set; }
        public virtual DbSet<TblCustomerSubscription> TblCustomerSubscription { get; set; }
        public virtual DbSet<TblCustomerTransactionPermission> TblCustomerTransactionPermission { get; set; }
        public virtual DbSet<TblCustomerType> TblCustomerType { get; set; }
        public virtual DbSet<TblCustomerTypeAttribute> TblCustomerTypeAttribute { get; set; }
        public virtual DbSet<TblCustomerTypeAttributeValue> TblCustomerTypeAttributeValue { get; set; }
        public virtual DbSet<TblCustomerTypeChoiceAttribute> TblCustomerTypeChoiceAttribute { get; set; }
        public virtual DbSet<TblCustomerTypeCommonAttribute> TblCustomerTypeCommonAttribute { get; set; }
        public virtual DbSet<TblCustomerWaitlist> TblCustomerWaitlist { get; set; }
        public virtual DbSet<TblDataExchangeAflupgradePurchase> TblDataExchangeAflupgradePurchase { get; set; }
        public virtual DbSet<TblDataExchangeAxcessOneBarcode> TblDataExchangeAxcessOneBarcode { get; set; }
        public virtual DbSet<TblDataExchangeFile> TblDataExchangeFile { get; set; }
        public virtual DbSet<TblDataExchangeMccbarcode> TblDataExchangeMccbarcode { get; set; }
        public virtual DbSet<TblDataExchangeMessageType> TblDataExchangeMessageType { get; set; }
        public virtual DbSet<TblDataExchangeNewArchticsBarcode> TblDataExchangeNewArchticsBarcode { get; set; }
        public virtual DbSet<TblDataExchangeSmslistSynchronisation> TblDataExchangeSmslistSynchronisation { get; set; }
        public virtual DbSet<TblDataExchangeStatus> TblDataExchangeStatus { get; set; }
        public virtual DbSet<TblDataExchangeTransport> TblDataExchangeTransport { get; set; }
        public virtual DbSet<TblDataExchangeVelocityEntitlementPassword> TblDataExchangeVelocityEntitlementPassword { get; set; }
        public virtual DbSet<TblDeliveryType> TblDeliveryType { get; set; }
        public virtual DbSet<TblDistributionChannel> TblDistributionChannel { get; set; }
        public virtual DbSet<TblEnquiryEdit> TblEnquiryEdit { get; set; }
        public virtual DbSet<TblEnquiryFilter> TblEnquiryFilter { get; set; }
        public virtual DbSet<TblEnquiryFilterParam> TblEnquiryFilterParam { get; set; }
        public virtual DbSet<TblEntitlement> TblEntitlement { get; set; }
        public virtual DbSet<TblEntitlementDependency> TblEntitlementDependency { get; set; }
        public virtual DbSet<TblEntitlementDisabledReason> TblEntitlementDisabledReason { get; set; }
        public virtual DbSet<TblEntitlementGroup> TblEntitlementGroup { get; set; }
        public virtual DbSet<TblEntitlementPassword> TblEntitlementPassword { get; set; }
        public virtual DbSet<TblEntitlementUsage> TblEntitlementUsage { get; set; }
        public virtual DbSet<TblEventType> TblEventType { get; set; }
        public virtual DbSet<TblEventWorksAudit> TblEventWorksAudit { get; set; }
        public virtual DbSet<TblEventWorksFile> TblEventWorksFile { get; set; }
        public virtual DbSet<TblEzyTicketGenerationLog> TblEzyTicketGenerationLog { get; set; }
        public virtual DbSet<TblEzyTicketReplacementType> TblEzyTicketReplacementType { get; set; }
        public virtual DbSet<TblFile> TblFile { get; set; }
        public virtual DbSet<TblForeignBarcode> TblForeignBarcode { get; set; }
        public virtual DbSet<TblGiftCard> TblGiftCard { get; set; }
        public virtual DbSet<TblGiftVoucherBarcodeMap> TblGiftVoucherBarcodeMap { get; set; }
        public virtual DbSet<TblGroupCustomerList> TblGroupCustomerList { get; set; }
        public virtual DbSet<TblGroupCustomerType> TblGroupCustomerType { get; set; }
        public virtual DbSet<TblGroupOrganisation> TblGroupOrganisation { get; set; }
        public virtual DbSet<TblGroupPromoter> TblGroupPromoter { get; set; }
        public virtual DbSet<TblGroupVenueManager> TblGroupVenueManager { get; set; }
        public virtual DbSet<TblInsurancePremium> TblInsurancePremium { get; set; }
        public virtual DbSet<TblInsuranceRequest> TblInsuranceRequest { get; set; }
        public virtual DbSet<TblInventoryTransaction> TblInventoryTransaction { get; set; }
        public virtual DbSet<TblInventoryTransactionSource> TblInventoryTransactionSource { get; set; }
        public virtual DbSet<TblLinkedFees> TblLinkedFees { get; set; }
        public virtual DbSet<TblMandatoryProduct> TblMandatoryProduct { get; set; }
        public virtual DbSet<TblMasterMapping> TblMasterMapping { get; set; }
        public virtual DbSet<TblMember> TblMember { get; set; }
        public virtual DbSet<TblMemberPerformanceBarcode> TblMemberPerformanceBarcode { get; set; }
        public virtual DbSet<TblMemberRanking> TblMemberRanking { get; set; }
        public virtual DbSet<TblMemberRollover> TblMemberRollover { get; set; }
        public virtual DbSet<TblMembership> TblMembership { get; set; }
        public virtual DbSet<TblMembershipContentType> TblMembershipContentType { get; set; }
        public virtual DbSet<TblMembershipGroup> TblMembershipGroup { get; set; }
        public virtual DbSet<TblMembershipOrganisation> TblMembershipOrganisation { get; set; }
        public virtual DbSet<TblMembershipOrganisationContent> TblMembershipOrganisationContent { get; set; }
        public virtual DbSet<TblMembershipOrganisationType> TblMembershipOrganisationType { get; set; }
        public virtual DbSet<TblMembershipPortalAttribute> TblMembershipPortalAttribute { get; set; }
        public virtual DbSet<TblMembershipPortalAttributeType> TblMembershipPortalAttributeType { get; set; }
        public virtual DbSet<TblMembershipPortalAttributeValue> TblMembershipPortalAttributeValue { get; set; }
        public virtual DbSet<TblMembershipProduct> TblMembershipProduct { get; set; }
        public virtual DbSet<TblMembershipProductPackageJoin> TblMembershipProductPackageJoin { get; set; }
        public virtual DbSet<TblMembershipPromotion> TblMembershipPromotion { get; set; }
        public virtual DbSet<TblMembershipSeat> TblMembershipSeat { get; set; }
        public virtual DbSet<TblMembershipTicketGenerationLog> TblMembershipTicketGenerationLog { get; set; }
        public virtual DbSet<TblMemGroupMembershipJoin> TblMemGroupMembershipJoin { get; set; }
        public virtual DbSet<TblMenuItem> TblMenuItem { get; set; }
        public virtual DbSet<TblMenuItemLink> TblMenuItemLink { get; set; }
        public virtual DbSet<TblMenuItemOperation> TblMenuItemOperation { get; set; }
        public virtual DbSet<TblMenuItemTarget> TblMenuItemTarget { get; set; }
        public virtual DbSet<TblMerchandise> TblMerchandise { get; set; }
        public virtual DbSet<TblNotification> TblNotification { get; set; }
        public virtual DbSet<TblNotificationBuild> TblNotificationBuild { get; set; }
        public virtual DbSet<TblNotificationBuildResult> TblNotificationBuildResult { get; set; }
        public virtual DbSet<TblNotificationPart> TblNotificationPart { get; set; }
        public virtual DbSet<TblOnSaleTime> TblOnSaleTime { get; set; }
        public virtual DbSet<TblOrder> TblOrder { get; set; }
        public virtual DbSet<TblOrder1> TblOrder1 { get; set; }
        public virtual DbSet<TblOrderBaseClassification> TblOrderBaseClassification { get; set; }
        public virtual DbSet<TblOrderBaseClassificationGroup> TblOrderBaseClassificationGroup { get; set; }
        public virtual DbSet<TblOrderClassification> TblOrderClassification { get; set; }
        public virtual DbSet<TblOrderDelegation> TblOrderDelegation { get; set; }
        public virtual DbSet<TblOrderDeletion> TblOrderDeletion { get; set; }
        public virtual DbSet<TblOrderFulfillmentMethod> TblOrderFulfillmentMethod { get; set; }
        public virtual DbSet<TblOrderGuestInfo> TblOrderGuestInfo { get; set; }
        public virtual DbSet<TblOrderItemStatus> TblOrderItemStatus { get; set; }
        public virtual DbSet<TblOrderLine> TblOrderLine { get; set; }
        public virtual DbSet<TblOrderLineAllocation> TblOrderLineAllocation { get; set; }
        public virtual DbSet<TblOrderLineAttribute> TblOrderLineAttribute { get; set; }
        public virtual DbSet<TblOrderLineAttributeValue> TblOrderLineAttributeValue { get; set; }
        public virtual DbSet<TblOrderLineChoiceAttribute> TblOrderLineChoiceAttribute { get; set; }
        public virtual DbSet<TblOrderlineClassification> TblOrderlineClassification { get; set; }
        public virtual DbSet<TblOrderLineCommonAttribute> TblOrderLineCommonAttribute { get; set; }
        public virtual DbSet<TblOrderLineMemberShopItem> TblOrderLineMemberShopItem { get; set; }
        public virtual DbSet<TblOrderLinePaymentHistory> TblOrderLinePaymentHistory { get; set; }
        public virtual DbSet<TblOrderLineVenuePrefJoin> TblOrderLineVenuePrefJoin { get; set; }
        public virtual DbSet<TblOrderPaymentDetail> TblOrderPaymentDetail { get; set; }
        public virtual DbSet<TblOrderPaymentHistory> TblOrderPaymentHistory { get; set; }
        public virtual DbSet<TblOrderProcessType> TblOrderProcessType { get; set; }
        public virtual DbSet<TblOrderRolloverAudit> TblOrderRolloverAudit { get; set; }
        public virtual DbSet<TblOrderSalesChannel> TblOrderSalesChannel { get; set; }
        public virtual DbSet<TblOrderSubscriptionInfo> TblOrderSubscriptionInfo { get; set; }
        public virtual DbSet<TblOrganisation> TblOrganisation { get; set; }
        public virtual DbSet<TblOrganisationAttribute> TblOrganisationAttribute { get; set; }
        public virtual DbSet<TblOrganisationAttributeValue> TblOrganisationAttributeValue { get; set; }
        public virtual DbSet<TblOrganisationCardType> TblOrganisationCardType { get; set; }
        public virtual DbSet<TblOrganisationChoiceAttribute> TblOrganisationChoiceAttribute { get; set; }
        public virtual DbSet<TblOrganisationCommonAttribute> TblOrganisationCommonAttribute { get; set; }
        public virtual DbSet<TblOrganisationCustomer> TblOrganisationCustomer { get; set; }
        public virtual DbSet<TblOrganisationCustomerActivityRecord> TblOrganisationCustomerActivityRecord { get; set; }
        public virtual DbSet<TblOrganisationCustomerAttachment> TblOrganisationCustomerAttachment { get; set; }
        public virtual DbSet<TblOrganisationCustomerFeature> TblOrganisationCustomerFeature { get; set; }
        public virtual DbSet<TblOrganisationCustomerFileJoin> TblOrganisationCustomerFileJoin { get; set; }
        public virtual DbSet<TblOrganisationCustomerOrderline> TblOrganisationCustomerOrderline { get; set; }
        public virtual DbSet<TblOrganisationCustomerOrderlineItem> TblOrganisationCustomerOrderlineItem { get; set; }
        public virtual DbSet<TblOrganisationFeature> TblOrganisationFeature { get; set; }
        public virtual DbSet<TblOrganisationFile> TblOrganisationFile { get; set; }
        public virtual DbSet<TblOrganisationPaymentMethod> TblOrganisationPaymentMethod { get; set; }
        public virtual DbSet<TblOriginAccount> TblOriginAccount { get; set; }
        public virtual DbSet<TblOriginBillingRecordMap> TblOriginBillingRecordMap { get; set; }
        public virtual DbSet<TblOriginInventoryTransactionMap> TblOriginInventoryTransactionMap { get; set; }
        public virtual DbSet<TblOriginOrderMap> TblOriginOrderMap { get; set; }
        public virtual DbSet<TblOriginPrintRecordMap> TblOriginPrintRecordMap { get; set; }
        public virtual DbSet<TblOriginShippingRecordMap> TblOriginShippingRecordMap { get; set; }
        public virtual DbSet<TblOriginTaxInvoiceMap> TblOriginTaxInvoiceMap { get; set; }
        public virtual DbSet<TblOwner> TblOwner { get; set; }
        public virtual DbSet<TblPackage> TblPackage { get; set; }
        public virtual DbSet<TblPackageMembershipProductOverride> TblPackageMembershipProductOverride { get; set; }
        public virtual DbSet<TblPackageUmbrellaJoin> TblPackageUmbrellaJoin { get; set; }
        public virtual DbSet<TblPartPaymentSchedule> TblPartPaymentSchedule { get; set; }
        public virtual DbSet<TblPaxcard> TblPaxcard { get; set; }
        public virtual DbSet<TblPaxcardAllocation> TblPaxcardAllocation { get; set; }
        public virtual DbSet<TblPaxvenueGate> TblPaxvenueGate { get; set; }
        public virtual DbSet<TblPaymentMasterSchedule> TblPaymentMasterSchedule { get; set; }
        public virtual DbSet<TblPaymentMethod> TblPaymentMethod { get; set; }
        public virtual DbSet<TblPaymentRun> TblPaymentRun { get; set; }
        public virtual DbSet<TblPaymentSchedule> TblPaymentSchedule { get; set; }
        public virtual DbSet<TblPerformance> TblPerformance { get; set; }
        public virtual DbSet<TblPerformancePriceTable> TblPerformancePriceTable { get; set; }
        public virtual DbSet<TblPerformancePriceType> TblPerformancePriceType { get; set; }
        public virtual DbSet<TblPhone> TblPhone { get; set; }
        public virtual DbSet<TblPhoneNumberType> TblPhoneNumberType { get; set; }
        public virtual DbSet<TblPhoneType> TblPhoneType { get; set; }
        public virtual DbSet<TblPinpadUsage> TblPinpadUsage { get; set; }
        public virtual DbSet<TblPlaceHolderProduct> TblPlaceHolderProduct { get; set; }
        public virtual DbSet<TblPriceMarketingType> TblPriceMarketingType { get; set; }
        public virtual DbSet<TblPriceTable> TblPriceTable { get; set; }
        public virtual DbSet<TblPriceType> TblPriceType { get; set; }
        public virtual DbSet<TblPriceTypeClass> TblPriceTypeClass { get; set; }
        public virtual DbSet<TblPriceTypeMap> TblPriceTypeMap { get; set; }
        public virtual DbSet<TblPriceTypeMembershipProduct> TblPriceTypeMembershipProduct { get; set; }
        public virtual DbSet<TblPriceTypeRule> TblPriceTypeRule { get; set; }
        public virtual DbSet<TblPriceTypeRulePriceType> TblPriceTypeRulePriceType { get; set; }
        public virtual DbSet<TblPrimaryMember> TblPrimaryMember { get; set; }
        public virtual DbSet<TblPrintRecord> TblPrintRecord { get; set; }
        public virtual DbSet<TblProcessLock> TblProcessLock { get; set; }
        public virtual DbSet<TblProdSelProductJoin> TblProdSelProductJoin { get; set; }
        public virtual DbSet<TblProduct> TblProduct { get; set; }
        public virtual DbSet<TblProductCategory> TblProductCategory { get; set; }
        public virtual DbSet<TblProductCategoryCapacity> TblProductCategoryCapacity { get; set; }
        public virtual DbSet<TblProductClass> TblProductClass { get; set; }
        public virtual DbSet<TblProductGroup> TblProductGroup { get; set; }
        public virtual DbSet<TblProductMemberShopItem> TblProductMemberShopItem { get; set; }
        public virtual DbSet<TblProductMemberShopItemColor> TblProductMemberShopItemColor { get; set; }
        public virtual DbSet<TblProductMemberShopItemCustomField> TblProductMemberShopItemCustomField { get; set; }
        public virtual DbSet<TblProductMemberShopItemExtraCustomField> TblProductMemberShopItemExtraCustomField { get; set; }
        public virtual DbSet<TblProductMemberShopItemImage> TblProductMemberShopItemImage { get; set; }
        public virtual DbSet<TblProductMemberShopItemImageUpload> TblProductMemberShopItemImageUpload { get; set; }
        public virtual DbSet<TblProductMemberShopItemSize> TblProductMemberShopItemSize { get; set; }
        public virtual DbSet<TblProductOrganisationFile> TblProductOrganisationFile { get; set; }
        public virtual DbSet<TblProductPricing> TblProductPricing { get; set; }
        public virtual DbSet<TblProductPricingExtension> TblProductPricingExtension { get; set; }
        public virtual DbSet<TblProductProdGroupJoin> TblProductProdGroupJoin { get; set; }
        public virtual DbSet<TblProductProdSelJoin> TblProductProdSelJoin { get; set; }
        public virtual DbSet<TblProductSelection> TblProductSelection { get; set; }
        public virtual DbSet<TblProductSource> TblProductSource { get; set; }
        public virtual DbSet<TblProductType> TblProductType { get; set; }
        public virtual DbSet<TblProductUpgrade> TblProductUpgrade { get; set; }
        public virtual DbSet<TblProductWaitlist> TblProductWaitlist { get; set; }
        public virtual DbSet<TblProm> TblProm { get; set; }
        public virtual DbSet<TblPromoter> TblPromoter { get; set; }
        public virtual DbSet<TblProtectionGroup> TblProtectionGroup { get; set; }
        public virtual DbSet<TblProtectionGroupEntitlement> TblProtectionGroupEntitlement { get; set; }
        public virtual DbSet<TblProtectionGroupEntitlementPriceType> TblProtectionGroupEntitlementPriceType { get; set; }
        public virtual DbSet<TblProtectionItem> TblProtectionItem { get; set; }
        public virtual DbSet<TblProtectionItemSourcePriceType> TblProtectionItemSourcePriceType { get; set; }
        public virtual DbSet<TblQueryStringUniqueIdentifier> TblQueryStringUniqueIdentifier { get; set; }
        public virtual DbSet<TblRankingFactor> TblRankingFactor { get; set; }
        public virtual DbSet<TblRegion> TblRegion { get; set; }
        public virtual DbSet<TblRow> TblRow { get; set; }
        public virtual DbSet<TblSalesChannel> TblSalesChannel { get; set; }
        public virtual DbSet<TblSeason> TblSeason { get; set; }
        public virtual DbSet<TblSeasonSeatMap> TblSeasonSeatMap { get; set; }
        public virtual DbSet<TblSeasonSeatMapSection> TblSeasonSeatMapSection { get; set; }
        public virtual DbSet<TblSeat> TblSeat { get; set; }
        public virtual DbSet<TblSeatAttribute> TblSeatAttribute { get; set; }
        public virtual DbSet<TblSeatingGroup> TblSeatingGroup { get; set; }
        public virtual DbSet<TblSeatingGroupMemberJoin> TblSeatingGroupMemberJoin { get; set; }
        public virtual DbSet<TblSeatingPreference> TblSeatingPreference { get; set; }
        public virtual DbSet<TblSeatStatus> TblSeatStatus { get; set; }
        public virtual DbSet<TblSeatZone> TblSeatZone { get; set; }
        public virtual DbSet<TblSeatZonePreference> TblSeatZonePreference { get; set; }
        public virtual DbSet<TblSellerClass> TblSellerClass { get; set; }
        public virtual DbSet<TblSessionType> TblSessionType { get; set; }
        public virtual DbSet<TblSharedStore> TblSharedStore { get; set; }
        public virtual DbSet<TblShippingRecord> TblShippingRecord { get; set; }
        public virtual DbSet<TblShoppingCart> TblShoppingCart { get; set; }
        public virtual DbSet<TblShoppingCartItem> TblShoppingCartItem { get; set; }
        public virtual DbSet<TblShow> TblShow { get; set; }
        public virtual DbSet<TblShowInformation> TblShowInformation { get; set; }
        public virtual DbSet<TblShowItem> TblShowItem { get; set; }
        public virtual DbSet<TblShowItemType> TblShowItemType { get; set; }
        public virtual DbSet<TblShowTag> TblShowTag { get; set; }
        public virtual DbSet<TblShowTime> TblShowTime { get; set; }
        public virtual DbSet<TblShowType> TblShowType { get; set; }
        public virtual DbSet<TblShowVenue> TblShowVenue { get; set; }
        public virtual DbSet<TblShowVenueBookingFee> TblShowVenueBookingFee { get; set; }
        public virtual DbSet<TblShowVenueDispatchTimes> TblShowVenueDispatchTimes { get; set; }
        public virtual DbSet<TblShowVenuePerformance> TblShowVenuePerformance { get; set; }
        public virtual DbSet<TblShowVenuePriceCategory> TblShowVenuePriceCategory { get; set; }
        public virtual DbSet<TblShowVenuePriceTable> TblShowVenuePriceTable { get; set; }
        public virtual DbSet<TblShowVenueTicketFormat> TblShowVenueTicketFormat { get; set; }
        public virtual DbSet<TblShowVenueTicketLine> TblShowVenueTicketLine { get; set; }
        public virtual DbSet<TblSitWith> TblSitWith { get; set; }
        public virtual DbSet<TblSourcePerformance> TblSourcePerformance { get; set; }
        public virtual DbSet<TblSourcePerformancePackageJoin> TblSourcePerformancePackageJoin { get; set; }
        public virtual DbSet<TblSourceSeatAttribute> TblSourceSeatAttribute { get; set; }
        public virtual DbSet<TblSourceSeatAttributeAudit> TblSourceSeatAttributeAudit { get; set; }
        public virtual DbSet<TblSourceSeatAttributeIssueType> TblSourceSeatAttributeIssueType { get; set; }
        public virtual DbSet<TblStagingOriginAccount> TblStagingOriginAccount { get; set; }
        public virtual DbSet<TblStandardPriceType> TblStandardPriceType { get; set; }
        public virtual DbSet<TblSubscription> TblSubscription { get; set; }
        public virtual DbSet<TblSubscription1> TblSubscription1 { get; set; }
        public virtual DbSet<TblSubscriptionAllocation> TblSubscriptionAllocation { get; set; }
        public virtual DbSet<TblSubscriptionAllocationPreferred> TblSubscriptionAllocationPreferred { get; set; }
        public virtual DbSet<TblSubscriptionChoice> TblSubscriptionChoice { get; set; }
        public virtual DbSet<TblSubscriptionPackageVenue> TblSubscriptionPackageVenue { get; set; }
        public virtual DbSet<TblSubscriptionPremiumSms> TblSubscriptionPremiumSms { get; set; }
        public virtual DbSet<TblSubscriptionStatus> TblSubscriptionStatus { get; set; }
        public virtual DbSet<TblSysAccessLevel> TblSysAccessLevel { get; set; }
        public virtual DbSet<TblSysApplication> TblSysApplication { get; set; }
        public virtual DbSet<TblSysApplicationConfigAttribute> TblSysApplicationConfigAttribute { get; set; }
        public virtual DbSet<TblSysAuditLog> TblSysAuditLog { get; set; }
        public virtual DbSet<TblSysCategoryExceptionLog> TblSysCategoryExceptionLog { get; set; }
        public virtual DbSet<TblSysCategoryLog> TblSysCategoryLog { get; set; }
        public virtual DbSet<TblSysExceptionLog> TblSysExceptionLog { get; set; }
        public virtual DbSet<TblSysExceptionLogTest> TblSysExceptionLogTest { get; set; }
        public virtual DbSet<TblSysGroup> TblSysGroup { get; set; }
        public virtual DbSet<TblSysGroupType> TblSysGroupType { get; set; }
        public virtual DbSet<TblSysLog> TblSysLog { get; set; }
        public virtual DbSet<TblSysLoggingCategory> TblSysLoggingCategory { get; set; }
        public virtual DbSet<TblSysSecurityGroupTask> TblSysSecurityGroupTask { get; set; }
        public virtual DbSet<TblSysSecurityOperation> TblSysSecurityOperation { get; set; }
        public virtual DbSet<TblSysSecurityTask> TblSysSecurityTask { get; set; }
        public virtual DbSet<TblSysSecurityTaskOperation> TblSysSecurityTaskOperation { get; set; }
        public virtual DbSet<TblSysUser> TblSysUser { get; set; }
        public virtual DbSet<TblSysUserGroup> TblSysUserGroup { get; set; }
        public virtual DbSet<TblSysUserMonitor> TblSysUserMonitor { get; set; }
        public virtual DbSet<TblSysUserPreference> TblSysUserPreference { get; set; }
        public virtual DbSet<TblSysUserPreferenceChoice> TblSysUserPreferenceChoice { get; set; }
        public virtual DbSet<TblSysUserPreferenceUser> TblSysUserPreferenceUser { get; set; }
        public virtual DbSet<TblSysVersion> TblSysVersion { get; set; }
        public virtual DbSet<TblTagRegion> TblTagRegion { get; set; }
        public virtual DbSet<TblTaxInvoiceRecord> TblTaxInvoiceRecord { get; set; }
        public virtual DbSet<TblThirdPartyPaymentDetail> TblThirdPartyPaymentDetail { get; set; }
        public virtual DbSet<TblTicketLimit> TblTicketLimit { get; set; }
        public virtual DbSet<TblTicketLimitIdentifier> TblTicketLimitIdentifier { get; set; }
        public virtual DbSet<TblTicketLimitType> TblTicketLimitType { get; set; }
        public virtual DbSet<TblTicketLimitUsage> TblTicketLimitUsage { get; set; }
        public virtual DbSet<TblTicketType> TblTicketType { get; set; }
        public virtual DbSet<TblTimeZoneOffset> TblTimeZoneOffset { get; set; }
        public virtual DbSet<TblTransmissionCredential> TblTransmissionCredential { get; set; }
        public virtual DbSet<TblTransmissionEntity> TblTransmissionEntity { get; set; }
        public virtual DbSet<TblTransmissionEntityConfig> TblTransmissionEntityConfig { get; set; }
        public virtual DbSet<TblTransmissionIntegrationSource> TblTransmissionIntegrationSource { get; set; }
        public virtual DbSet<TblTransmissionLog> TblTransmissionLog { get; set; }
        public virtual DbSet<TblVenue> TblVenue { get; set; }
        public virtual DbSet<TblVenueAttribute> TblVenueAttribute { get; set; }
        public virtual DbSet<TblVenueGroup> TblVenueGroup { get; set; }
        public virtual DbSet<TblVenueManager> TblVenueManager { get; set; }
        public virtual DbSet<TblVenuePolicy> TblVenuePolicy { get; set; }
        public virtual DbSet<TblVenueSeatMap> TblVenueSeatMap { get; set; }
        public virtual DbSet<TblVoucher> TblVoucher { get; set; }
        public virtual DbSet<TblVoucher1> TblVoucher1 { get; set; }
        public virtual DbSet<TblVoucherStatus> TblVoucherStatus { get; set; }
        public virtual DbSet<TblVoucherTransaction> TblVoucherTransaction { get; set; }
        public virtual DbSet<TblWaitlist> TblWaitlist { get; set; }
        public virtual DbSet<TblWaitlistChannel> TblWaitlistChannel { get; set; }
        public virtual DbSet<TblWorkflowGroupType> TblWorkflowGroupType { get; set; }
        public virtual DbSet<TblWorkflowOrganisation> TblWorkflowOrganisation { get; set; }
        public virtual DbSet<TblWorkflowType> TblWorkflowType { get; set; }
        public virtual DbSet<Test1> Test1 { get; set; }
        public virtual DbSet<Test2> Test2 { get; set; }
        public virtual DbSet<TicketExtension> TicketExtension { get; set; }
        public virtual DbSet<ZztblOrderIdsToInsert> ZztblOrderIdsToInsert { get; set; }

        // Unable to generate entity type for table 'dbo.tblcustomer_aparna'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_ProductConfigurationMapping'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_ProductConfigurationMappingStaging'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LogTest'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_Brumbies'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_Brumbies_mod'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbloriginaccount1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_ABB_Ballot'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pw_tblAccountTransactionHistory'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.OrderlineSeats'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblSysUserOperationMonitor'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblcustomertest'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_AlternatePowerWebLogin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_AuditEntitlementUsage'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_AlternatePowerWebLoginSubscription'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_AlternatePowerWebLoginPreference'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblTRSmokeTest'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_AuditEntitlementPassword'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_ANZNewNumberAndOldNumberConfigFile'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RedShift_Attendance'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.myTable'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pw_tblPasswordProtectedShowVenues'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_OrderLoadStaging'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.environments'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.myTable_id'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_StagingANZMembersForSeedRank'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SampleSeller'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_LotusDeltaActivityType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_LotusDeltaActivityTypeAttribute'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_DeliveryTypesByPostcode'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_LotusDeltaActivityTypeAttributeValue'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VenueReplay'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_LotusDeltaActivityTypeChoiceAttribute'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.temp_VENUE_REPLAY'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_LotusDeltaActivityTypeCommonAttribute'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_LotusDeltaCustomerActivityRecord'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.temp_Owner_REPLAY'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.temp_PROM_REPLAY'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_LotusDeltaCustomerWebDetails'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_LotusDeltaCustomerSubscriptionIsNotSubscribed'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_OriginSeatStaging'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_OriginSeat'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_SeatingGroupVenuePrefJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Z_Bulldogs'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.zCampaign_Numeric'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblTempLotusExtractionTicketekRewardsOptIns'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.zCampaign_Unsubscribes_Numeric'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo._tmp_tbl_ForeignBarcodeAllocated'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.zCampaign_Mobile_Numeric'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_AuditInsurancePremium'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.edm_tblCampaignCustomerOfferLink'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.zCustomerExport'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.st_dates'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblLogError'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAuditActivityTypeAttributeValue'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAuditCustomer'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.z2Campaign_Numeric'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAuditCustomerAddress'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ztbl_AccessControlTicketLog_Staging'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_AuditBallotSeatingAllocation'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_AuditCustomerCreditCard'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAuditCustomerList'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_AuditCreditCardDetails'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAuditCustomerPhone'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_LotusDeltaMembershipOrganisation'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_AccessControlTicketLog'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAuditCustomerPreferenceValue'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAuditCustomerSubscription'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAuditVoucher'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAuditCustomerType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbladdresstype1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAuditCustomerTypeAttributeValue'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAuditGroupCustomerList'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAuditGroupCustomerType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_LoadProcessLog'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAuditGroupOrganisation'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAuditCustomerAccountBalance'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAuditOrganisation'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAuditOrganisationAttributeValue'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAuditOrganisationCustomer'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAuditSysApplication'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Paxcard'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAuditSysGroup'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ztbl_EntitlementUsage'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CustomerExtended'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_DataExchangeGatelinkMatchExportFile'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAuditSysJobQueue'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_CustomerAuthenticationLog'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ztbl_EntitlementPassword'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAuditSysSecurityGroupTask'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAuditSysSecurityOperation'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.temp_member_bridgingdata'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAuditSysSecurityTask'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.zCampaign'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAuditSysSecurityTaskOperation'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.zCampaign_Unsubscribes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAuditSysUser'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.zCampaign_Mobile'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_StagingSourceSeatAttribute'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.zztblTempOrderIDsToInsert'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblAuditSysUserGroup'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_OrderBaseClassificationGroupType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_OrderLinePrepaymentHistory'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_SourceSeatAttributeTemp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.OrderlineItemTicket'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.fulltext_catalogsx'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.temptablesize'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.zTempImageStaging'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.zTempImageList'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_AuditBallot'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_AuditBallotPriorityBand'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_AuditBallotSeatingChoice'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_RotationPenalties'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_AuditBallotEntry'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_CardTypeClone'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_AuditBallotEntryCustomer'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_AuditBallotEntryMember'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.test1_backup'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_SysProcessEventLog'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_LotusDeltaVoucher'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pw_tblPasswordProtectedPerformances'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_LotusDeltaVoucherStatus'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_CCOrderJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_LotusDeltaInsuranceRequest'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Employee'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_CCOrgCustJoin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_ShowItemAttribute'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblSysDataAccessProcedureInventory'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_StagingSeason'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblSysJobQueue'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_StagingRotationPenalties'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_StagingSeasonSeatmap'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_StagingSeasonSeatmapSection'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_LotusDelta_Voucher'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblSysQueryLog'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_StagingRow'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_LotusDelta_VoucherTransaction'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblTempLotusExtractionOptOuts'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_StagingSeat'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ztbl_EntitlementUsageBulk'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_LotusDeltaOriginAccount'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_LotusDeltaCustomer'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_LotusDeltaCustomerIDForExtraction'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_LotusDeltaCustomerAddress'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_OrgnisationCustomer_Keeplist'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_LotusDeltaCustomerPhone'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_LotusDeltaCustomerSubscription'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_LoadProcessLogAlloc'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_LotusDeltaCustomerPreferenceValue'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BaseTable1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_LotusDeltaCustomerPreference'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SampleTesting'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_LotusDeltaCustomerList'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.sample_testEventLog'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_LotusDeltaAddressType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_LotusDeltaPhoneType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ValidationEvents_Destination'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_LotusDeltaSubscriptionChoice'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_LotusDeltaSubscription'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_LotusDeltaSubscriptionPremiumSMS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pw_tblPasswordProtectedShows'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblSysStoredProcExceptions'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tblOrganisationCustomer_aparna'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ValidationEvents_Destination2'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=sqlserver.dev.local;Initial Catalog=Lotus;user=BIDataExtractor;password=Foobaz16");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaseTable>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ComputedCol)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasComputedColumnSql("([Color]+[Material])");

                entity.Property(e => e.Material)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<InTblAuditLog>(entity =>
            {
                entity.ToTable("in_tblAuditLog");

                entity.HasIndex(e => e.Dt)
                    .HasName("in_idx_AuditLogDt");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Application)
                    .HasColumnName("application")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Dt)
                    .HasColumnName("dt")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasColumnType("numeric(8, 0)");

                entity.Property(e => e.Info)
                    .HasColumnName("info")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Severity)
                    .HasColumnName("severity")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InTblGroups>(entity =>
            {
                entity.ToTable("in_tblGroups");

                entity.HasIndex(e => e.Groupname)
                    .HasName("uc_in_tblGroups_groupname")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Busid1)
                    .HasColumnName("busid1")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Busid2)
                    .HasColumnName("busid2")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.DtCreate)
                    .HasColumnName("dt_create")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DtModify)
                    .HasColumnName("dt_modify")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Groupname)
                    .IsRequired()
                    .HasColumnName("groupname")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.WebPortal)
                    .HasColumnName("web_portal")
                    .HasMaxLength(48)
                    .IsUnicode(false);

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.InTblGroups)
                    .HasForeignKey(d => d.Type)
                    .HasConstraintName("FK_in_tblGroups_in_tblGroupTypes");
            });

            modelBuilder.Entity<InTblGroupTypes>(entity =>
            {
                entity.ToTable("in_tblGroupTypes");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsManaged)
                    .HasColumnName("is_managed")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InTblJournalMonitor>(entity =>
            {
                entity.HasKey(e => e.MonitorName);

                entity.ToTable("in_tblJournalMonitor");

                entity.Property(e => e.MonitorName)
                    .HasColumnName("monitor_name")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.MjtFirst)
                    .HasColumnName("mjt_first")
                    .HasColumnType("char(14)");

                entity.Property(e => e.MjtLast)
                    .HasColumnName("mjt_last")
                    .HasColumnType("char(14)");
            });

            modelBuilder.Entity<InTblPerformances>(entity =>
            {
                entity.ToTable("in_tblPerformances");

                entity.HasIndex(e => e.Ecanon)
                    .HasName("uc_in_tblPerformances_ecanon")
                    .IsUnique();

                entity.HasIndex(e => e.Name)
                    .HasName("uc_in_tblPerformances_name")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Disabled)
                    .HasColumnName("disabled")
                    .HasColumnType("numeric(1, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ecanon)
                    .IsRequired()
                    .HasColumnName("ecanon")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ShowId).HasColumnName("show_id");

                entity.HasOne(d => d.Show)
                    .WithMany(p => p.InTblPerformances)
                    .HasForeignKey(d => d.ShowId)
                    .HasConstraintName("FK_in_tblPerformances_in_tblShows");
            });

            modelBuilder.Entity<InTblSalesHistory>(entity =>
            {
                entity.HasKey(e => new { e.Ecanon, e.Dt });

                entity.ToTable("in_tblSalesHistory");

                entity.Property(e => e.Ecanon)
                    .HasColumnName("ecanon")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Dt)
                    .HasColumnName("dt")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.BoxBfee)
                    .HasColumnName("box_bfee")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BoxComptix)
                    .HasColumnName("box_comptix")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BoxHfee)
                    .HasColumnName("box_hfee")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BoxIc)
                    .HasColumnName("box_ic")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BoxPrice)
                    .HasColumnName("box_price")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BoxTax)
                    .HasColumnName("box_tax")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BoxTix)
                    .HasColumnName("box_tix")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BoxValuetix)
                    .HasColumnName("box_valuetix")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BoxZptix)
                    .HasColumnName("box_zptix")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GrpBfee)
                    .HasColumnName("grp_bfee")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GrpComptix)
                    .HasColumnName("grp_comptix")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GrpHfee)
                    .HasColumnName("grp_hfee")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GrpIc)
                    .HasColumnName("grp_ic")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GrpPrice)
                    .HasColumnName("grp_price")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GrpTax)
                    .HasColumnName("grp_tax")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GrpTix)
                    .HasColumnName("grp_tix")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GrpValuetix)
                    .HasColumnName("grp_valuetix")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GrpZptix)
                    .HasColumnName("grp_zptix")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MobBfee)
                    .HasColumnName("mob_bfee")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MobComptix)
                    .HasColumnName("mob_comptix")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MobHfee)
                    .HasColumnName("mob_hfee")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MobIc)
                    .HasColumnName("mob_ic")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MobPrice)
                    .HasColumnName("mob_price")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MobTax)
                    .HasColumnName("mob_tax")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MobTix)
                    .HasColumnName("mob_tix")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MobValuetix)
                    .HasColumnName("mob_valuetix")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MobZptix)
                    .HasColumnName("mob_zptix")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OutBfee)
                    .HasColumnName("out_bfee")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OutComptix)
                    .HasColumnName("out_comptix")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OutHfee)
                    .HasColumnName("out_hfee")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OutIc)
                    .HasColumnName("out_ic")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OutPrice)
                    .HasColumnName("out_price")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OutTax)
                    .HasColumnName("out_tax")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OutTix)
                    .HasColumnName("out_tix")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OutValuetix)
                    .HasColumnName("out_valuetix")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OutZptix)
                    .HasColumnName("out_zptix")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TelBfee)
                    .HasColumnName("tel_bfee")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TelComptix)
                    .HasColumnName("tel_comptix")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TelHfee)
                    .HasColumnName("tel_hfee")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TelIc)
                    .HasColumnName("tel_ic")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TelPrice)
                    .HasColumnName("tel_price")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TelTax)
                    .HasColumnName("tel_tax")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TelTix)
                    .HasColumnName("tel_tix")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TelValuetix)
                    .HasColumnName("tel_valuetix")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TelZptix)
                    .HasColumnName("tel_zptix")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WwwBfee)
                    .HasColumnName("www_bfee")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WwwComptix)
                    .HasColumnName("www_comptix")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WwwHfee)
                    .HasColumnName("www_hfee")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WwwIc)
                    .HasColumnName("www_ic")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WwwPrice)
                    .HasColumnName("www_price")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WwwTax)
                    .HasColumnName("www_tax")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WwwTix)
                    .HasColumnName("www_tix")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WwwValuetix)
                    .HasColumnName("www_valuetix")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WwwZptix)
                    .HasColumnName("www_zptix")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<InTblSeatmapReportAccess>(entity =>
            {
                entity.HasKey(e => e.SeatmapReportAccessId);

                entity.ToTable("in_tblSeatmapReportAccess");

                entity.HasIndex(e => new { e.UserId, e.VenueId })
                    .HasName("UNQ_in_tblSeatmapReportAccess")
                    .IsUnique();

                entity.Property(e => e.SeatmapReportAccessId).HasColumnName("SeatmapReportAccessID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.VenueId).HasColumnName("VenueID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.InTblSeatmapReportAccess)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_in_tblSeatmapReportAccess_in_tblUsers");

                entity.HasOne(d => d.Venue)
                    .WithMany(p => p.InTblSeatmapReportAccess)
                    .HasForeignKey(d => d.VenueId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_in_tblSeatmapReportAccess_in_tblGroups");
            });

            modelBuilder.Entity<InTblShows>(entity =>
            {
                entity.ToTable("in_tblShows");

                entity.HasIndex(e => e.Name)
                    .HasName("uc_in_tblShows_name")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.DtArchive)
                    .HasColumnName("dt_archive")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DtCreate)
                    .HasColumnName("dt_create")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DtModify)
                    .HasColumnName("dt_modify")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(48)
                    .IsUnicode(false);

                entity.Property(e => e.S18ShowName)
                    .HasColumnName("s18_show_name")
                    .HasMaxLength(48)
                    .IsUnicode(false);

                entity.Property(e => e.WpShowName)
                    .HasColumnName("wp_show_name")
                    .HasMaxLength(48)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InTblShowsAccess>(entity =>
            {
                entity.HasKey(e => new { e.ShowId, e.GroupId });

                entity.ToTable("in_tblShowsAccess");

                entity.Property(e => e.ShowId).HasColumnName("show_id");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.InTblShowsAccess)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_in_tblShowsAccess_in_tblGroups");

                entity.HasOne(d => d.Show)
                    .WithMany(p => p.InTblShowsAccess)
                    .HasForeignKey(d => d.ShowId)
                    .HasConstraintName("FK_in_tblShowsAccess_in_tblShows");
            });

            modelBuilder.Entity<InTblUsers>(entity =>
            {
                entity.ToTable("in_tblUsers");

                entity.HasIndex(e => e.Username)
                    .HasName("uc_in_tblUsers_username")
                    .IsUnique();

                entity.HasIndex(e => new { e.LatestWatchlistId, e.Id })
                    .HasName("NCINEX_in_tblUsers_INC_latest_watchlist_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.LastLogin)
                    .HasColumnName("last_login")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.LatestWatchlistId).HasColumnName("latest_watchlist_id");

                entity.Property(e => e.Locked)
                    .HasColumnName("locked")
                    .HasColumnType("numeric(1, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Passwd)
                    .HasColumnName("passwd")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PasswdExpires)
                    .HasColumnName("passwd_expires")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PasswdFailCount)
                    .HasColumnName("passwd_fail_count")
                    .HasColumnType("numeric(2, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InTblUsersGroups>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.GroupId });

                entity.ToTable("in_tblUsersGroups");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.InTblUsersGroups)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_in_tblUsersGroups_in_tblGroups");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.InTblUsersGroups)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_in_tblUsersGroups_in_tblUsers");
            });

            modelBuilder.Entity<InTblVenueSeatmapSettings>(entity =>
            {
                entity.HasKey(e => e.VenueSeatmapSettingsId);

                entity.ToTable("in_tblVenueSeatmapSettings");

                entity.Property(e => e.VenueSeatmapSettingsId).HasColumnName("VenueSeatmapSettingsID");

                entity.Property(e => e.NoFillRowSpacingFactor).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.NoFillSeatSpacingFactor).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.VenueId).HasColumnName("VenueID");

                entity.HasOne(d => d.Venue)
                    .WithMany(p => p.InTblVenueSeatmapSettings)
                    .HasForeignKey(d => d.VenueId)
                    .HasConstraintName("FK_in_tblVenueSeatmapSettings_in_tblGroups");
            });

            modelBuilder.Entity<InTblVenueSectionGroup>(entity =>
            {
                entity.HasKey(e => e.VenueSectionGroupId);

                entity.ToTable("in_tblVenueSectionGroup");

                entity.Property(e => e.VenueSectionGroupId).HasColumnName("VenueSectionGroupID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.SectionGroupName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SectionNames).IsRequired();

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.InTblVenueSectionGroup)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_in_tblVenueSectionGroup_in_tblGroups");
            });

            modelBuilder.Entity<InTblWatchlists>(entity =>
            {
                entity.ToTable("in_tblWatchlists");

                entity.HasIndex(e => new { e.UserId, e.Name })
                    .HasName("uc_in_tblWatchlists_user_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Perflist)
                    .HasColumnName("perflist")
                    .HasColumnType("text");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.InTblWatchlists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_in_tblWatchlists_in_tblUsers");
            });

            modelBuilder.Entity<InTblWatchlistsAccess>(entity =>
            {
                entity.HasKey(e => new { e.WatchlistId, e.GroupId });

                entity.ToTable("in_tblWatchlistsAccess");

                entity.Property(e => e.WatchlistId).HasColumnName("watchlist_id");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.InTblWatchlistsAccess)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_in_tblWatchlistsAccess_in_tblGroups");

                entity.HasOne(d => d.Watchlist)
                    .WithMany(p => p.InTblWatchlistsAccess)
                    .HasForeignKey(d => d.WatchlistId)
                    .HasConstraintName("FK_in_tblWatchlistsAccess_in_tblWatchlists");
            });

            modelBuilder.Entity<Logs>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Department)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Logs1>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Department)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.HasKey(e => e.OrganisationCustomerId);

                entity.Property(e => e.OrganisationCustomerId)
                    .HasColumnName("OrganisationCustomerID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.ExternalReference).HasMaxLength(100);

                entity.Property(e => e.MemberNumber).HasMaxLength(200);

                entity.Property(e => e.MemberSince).HasColumnType("datetime");

                entity.Property(e => e.MembershipType).HasMaxLength(50);

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.PrimaryOrganisationCustomerId).HasColumnName("PrimaryOrganisationCustomerID");

                entity.Property(e => e.SourceCreatedDate).HasColumnType("datetime");

                entity.Property(e => e.SourceModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.UserName).HasMaxLength(200);
            });

            modelBuilder.Entity<MemberAparna>(entity =>
            {
                entity.HasKey(e => e.OrganisationCustomerId);

                entity.ToTable("Member_aparna");

                entity.Property(e => e.OrganisationCustomerId)
                    .HasColumnName("OrganisationCustomerID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ExternalReference).HasMaxLength(100);

                entity.Property(e => e.MemberNumber).HasMaxLength(200);

                entity.Property(e => e.MemberSince).HasColumnType("datetime");

                entity.Property(e => e.MembershipType).HasMaxLength(50);

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.PrimaryOrganisationCustomerId).HasColumnName("PrimaryOrganisationCustomerID");

                entity.Property(e => e.SourceCreatedDate).HasColumnType("datetime");

                entity.Property(e => e.SourceModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.UserName).HasMaxLength(200);
            });

            modelBuilder.Entity<MemberTest>(entity =>
            {
                entity.HasKey(e => e.OrganisationCustomerId);

                entity.ToTable("Member_test");

                entity.Property(e => e.OrganisationCustomerId)
                    .HasColumnName("OrganisationCustomerID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.ExternalReference).HasMaxLength(100);

                entity.Property(e => e.MemberNumber).HasMaxLength(200);

                entity.Property(e => e.MemberSince).HasColumnType("datetime");

                entity.Property(e => e.MembershipType).HasMaxLength(50);

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.PrimaryOrganisationCustomerId).HasColumnName("PrimaryOrganisationCustomerID");

                entity.Property(e => e.SourceCreatedDate).HasColumnType("datetime");

                entity.Property(e => e.SourceModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.UserName).HasMaxLength(200);
            });

            modelBuilder.Entity<MosaicGroup>(entity =>
            {
                entity.HasKey(e => e.MosaicGroup1);

                entity.ToTable("Mosaic_Group");

                entity.HasIndex(e => new { e.MosaicGroupName, e.MosaicGroup1 })
                    .HasName("NCINEX_Mosaic_Group_INC_Mosaic_GroupName");

                entity.Property(e => e.MosaicGroup1)
                    .HasColumnName("Mosaic_Group")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.MosaicGroupName)
                    .IsRequired()
                    .HasColumnName("Mosaic_GroupName")
                    .HasMaxLength(100);

                entity.Property(e => e.MosaicGroupTagline)
                    .IsRequired()
                    .HasColumnName("Mosaic_GroupTagline")
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<MosaicLink>(entity =>
            {
                entity.HasKey(e => e.Dpid);

                entity.ToTable("Mosaic_Link");

                entity.HasIndex(e => new { e.MosaicType, e.MosaicGroup, e.Dpid })
                    .HasName("NCINEX_Mosaic_Link_DPID_INC_Mosaic_Type_Mosaic_Group");

                entity.Property(e => e.Dpid)
                    .HasColumnName("DPID")
                    .ValueGeneratedNever();

                entity.Property(e => e.MosaicGroup)
                    .HasColumnName("Mosaic_Group")
                    .HasMaxLength(5);

                entity.Property(e => e.MosaicType)
                    .HasColumnName("Mosaic_Type")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<MosaicType>(entity =>
            {
                entity.HasKey(e => e.MosaicType1);

                entity.ToTable("Mosaic_Type");

                entity.HasIndex(e => new { e.MosaicTypeName, e.MosaicType1 })
                    .HasName("NCINEX_Mosaic_Type_INC_Mosaic_TypeName");

                entity.Property(e => e.MosaicType1)
                    .HasColumnName("Mosaic_Type")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.MosaicTypeName)
                    .IsRequired()
                    .HasColumnName("Mosaic_TypeName")
                    .HasMaxLength(100);

                entity.Property(e => e.MosaicTypeTagline)
                    .IsRequired()
                    .HasColumnName("Mosaic_TypeTagline")
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<PwTblAdminResources>(entity =>
            {
                entity.HasKey(e => e.ArcId);

                entity.ToTable("pw_tblAdminResources");

                entity.Property(e => e.ArcId)
                    .HasColumnName("arcId")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.ArcContainerName)
                    .HasColumnName("arcContainerName")
                    .HasMaxLength(50);

                entity.Property(e => e.ArcDescription)
                    .HasColumnName("arcDescription")
                    .HasMaxLength(50);

                entity.Property(e => e.ArcIsContainer).HasColumnName("arcIsContainer");

                entity.Property(e => e.ArcRoleBitMask)
                    .HasColumnName("arcRoleBitMask")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PwTblAdminRoles>(entity =>
            {
                entity.HasKey(e => e.ArId);

                entity.ToTable("pw_tblAdminRoles");

                entity.Property(e => e.ArId).HasColumnName("arId");

                entity.Property(e => e.ArBitMask)
                    .HasColumnName("arBitMask")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ArName)
                    .IsRequired()
                    .HasColumnName("arName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PwTblAdminUsers>(entity =>
            {
                entity.HasKey(e => e.AuId);

                entity.ToTable("pw_tblAdminUsers");

                entity.Property(e => e.AuId).HasColumnName("auId");

                entity.Property(e => e.AuPassword)
                    .IsRequired()
                    .HasColumnName("auPassword")
                    .HasMaxLength(50);

                entity.Property(e => e.AuUserName)
                    .IsRequired()
                    .HasColumnName("auUserName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PwTblAdminUsersRoles>(entity =>
            {
                entity.HasKey(e => e.AurId);

                entity.ToTable("pw_tblAdminUsersRoles");

                entity.Property(e => e.AurId).HasColumnName("aurId");

                entity.Property(e => e.AurArid).HasColumnName("aurARId");

                entity.Property(e => e.AurAuid).HasColumnName("aurAUId");

                entity.HasOne(d => d.AurAr)
                    .WithMany(p => p.PwTblAdminUsersRoles)
                    .HasForeignKey(d => d.AurArid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pw_tblAdminUsersRoles_pw_tblAdminRoles");

                entity.HasOne(d => d.AurAu)
                    .WithMany(p => p.PwTblAdminUsersRoles)
                    .HasForeignKey(d => d.AurAuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pw_tblAdminUsersRoles_pw_tblAdminUsers");
            });

            modelBuilder.Entity<PwTblCategoriesAndShows>(entity =>
            {
                entity.HasKey(e => new { e.CtshCtid, e.CtshShid });

                entity.ToTable("pw_tblCategoriesAndShows");

                entity.HasIndex(e => e.CtshShid)
                    .HasName("NCINDEX_pw_tblCategoriesAndShows_ctshSHId");

                entity.Property(e => e.CtshCtid).HasColumnName("ctshCTId");

                entity.Property(e => e.CtshShid).HasColumnName("ctshSHId");

                entity.Property(e => e.CtshPosition).HasColumnName("ctshPosition");

                entity.Property(e => e.CtshPriority)
                    .HasColumnName("ctshPriority")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.CtshCt)
                    .WithMany(p => p.PwTblCategoriesAndShows)
                    .HasForeignKey(d => d.CtshCtid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pw_tblCategoriesAndShows_tblCustomerPreference");

                entity.HasOne(d => d.CtshSh)
                    .WithMany(p => p.PwTblCategoriesAndShows)
                    .HasForeignKey(d => d.CtshShid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pw_tblCategoriesAndShows_pw_tblShows");
            });

            modelBuilder.Entity<PwTblFiles>(entity =>
            {
                entity.HasKey(e => e.FlId);

                entity.ToTable("pw_tblFiles");

                entity.HasIndex(e => e.FlOriginalName)
                    .HasName("IX_pw_tblFiles");

                entity.Property(e => e.FlId).HasColumnName("flId");

                entity.Property(e => e.FlData)
                    .IsRequired()
                    .HasColumnName("flData")
                    .HasColumnType("image");

                entity.Property(e => e.FlDateEntered)
                    .HasColumnName("flDateEntered")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FlDescription)
                    .IsRequired()
                    .HasColumnName("flDescription")
                    .HasMaxLength(500);

                entity.Property(e => e.FlExtension)
                    .IsRequired()
                    .HasColumnName("flExtension")
                    .HasMaxLength(10);

                entity.Property(e => e.FlExternalDescription)
                    .IsRequired()
                    .HasColumnName("flExternalDescription")
                    .HasMaxLength(1000);

                entity.Property(e => e.FlExternalUse).HasColumnName("flExternalUse");

                entity.Property(e => e.FlOriginalName)
                    .IsRequired()
                    .HasColumnName("flOriginalName")
                    .HasMaxLength(200);

                entity.Property(e => e.FlReferenceCount).HasColumnName("flReferenceCount");
            });

            modelBuilder.Entity<PwTblHiddenVenueAttributes>(entity =>
            {
                entity.HasKey(e => new { e.HvaVsid, e.HvaVaidToHide });

                entity.ToTable("pw_tblHiddenVenueAttributes");

                entity.Property(e => e.HvaVsid).HasColumnName("hvaVSId");

                entity.Property(e => e.HvaVaidToHide).HasColumnName("hvaVAIdToHide");

                entity.HasOne(d => d.HvaVaidToHideNavigation)
                    .WithMany(p => p.PwTblHiddenVenueAttributes)
                    .HasForeignKey(d => d.HvaVaidToHide)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pw_tblHiddenVenueAttributes_pw_tblVenueAttributes");

                entity.HasOne(d => d.HvaVs)
                    .WithMany(p => p.PwTblHiddenVenueAttributes)
                    .HasForeignKey(d => d.HvaVsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pw_tblHiddenVenueAttributes_pw_tblVenueshows");
            });

            modelBuilder.Entity<PwTblHighlightedRegions>(entity =>
            {
                entity.HasKey(e => e.HrId);

                entity.ToTable("pw_tblHighlightedRegions");

                entity.HasIndex(e => new { e.HrControlCategoryId, e.HrUserCategoryId, e.HrRegionId })
                    .HasName("IX_ControlCategoryId_UserCategoryId_RegionId");

                entity.Property(e => e.HrId).HasColumnName("hrId");

                entity.Property(e => e.HrControlCategoryId).HasColumnName("hrControlCategoryId");

                entity.Property(e => e.HrRegionId)
                    .IsRequired()
                    .HasColumnName("hrRegionId")
                    .HasMaxLength(100);

                entity.Property(e => e.HrUserCategoryId).HasColumnName("hrUserCategoryId");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.HasOne(d => d.HrControlCategory)
                    .WithMany(p => p.PwTblHighlightedRegionsHrControlCategory)
                    .HasForeignKey(d => d.HrControlCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pw_tblHighlightedRegions_tblCustomerPreference (Control Category)");

                entity.HasOne(d => d.HrUserCategory)
                    .WithMany(p => p.PwTblHighlightedRegionsHrUserCategory)
                    .HasForeignKey(d => d.HrUserCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pw_tblHighlightedRegions_pw_tblHighlightedRegions");
            });

            modelBuilder.Entity<PwTblHighlightedShows>(entity =>
            {
                entity.HasKey(e => e.HsId);

                entity.ToTable("pw_tblHighlightedShows");

                entity.Property(e => e.HsId).HasColumnName("hsId");

                entity.Property(e => e.HsHrid).HasColumnName("hsHRId");

                entity.Property(e => e.HsPriority).HasColumnName("hsPriority");

                entity.Property(e => e.HsShid).HasColumnName("hsSHId");

                entity.HasOne(d => d.HsHr)
                    .WithMany(p => p.PwTblHighlightedShows)
                    .HasForeignKey(d => d.HsHrid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pw_tblHighlightedShows_pw_tblHighlightedRegions");

                entity.HasOne(d => d.HsSh)
                    .WithMany(p => p.PwTblHighlightedShows)
                    .HasForeignKey(d => d.HsShid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pw_tblHighlightedShows_pw_tblShows");
            });

            modelBuilder.Entity<PwTblNeutralCultureValues>(entity =>
            {
                entity.HasKey(e => e.NcvCode);

                entity.ToTable("pw_tblNeutralCultureValues");

                entity.Property(e => e.NcvCode)
                    .HasColumnName("ncvCode")
                    .HasMaxLength(6)
                    .ValueGeneratedNever();

                entity.Property(e => e.NcvDefault).HasColumnName("ncvDefault");

                entity.Property(e => e.NcvEnglishName)
                    .IsRequired()
                    .HasColumnName("ncvEnglishName")
                    .HasMaxLength(200);

                entity.Property(e => e.NcvSpecificRegionCode)
                    .IsRequired()
                    .HasColumnName("ncvSpecificRegionCode")
                    .HasMaxLength(8);
            });

            modelBuilder.Entity<PwTblPasswordGroupPerCulture>(entity =>
            {
                entity.HasKey(e => new { e.PgcPgid, e.PgcNcvcode });

                entity.ToTable("pw_tblPasswordGroupPerCulture");

                entity.Property(e => e.PgcPgid).HasColumnName("pgcPGId");

                entity.Property(e => e.PgcNcvcode)
                    .HasColumnName("pgcNCVCode")
                    .HasMaxLength(6);

                entity.Property(e => e.PgcFailedPrompt)
                    .IsRequired()
                    .HasColumnName("pgcFailedPrompt")
                    .HasMaxLength(200);

                entity.Property(e => e.PgcInitialPrompt)
                    .IsRequired()
                    .HasColumnName("pgcInitialPrompt")
                    .HasMaxLength(200);

                entity.HasOne(d => d.PgcNcvcodeNavigation)
                    .WithMany(p => p.PwTblPasswordGroupPerCulture)
                    .HasForeignKey(d => d.PgcNcvcode)
                    .HasConstraintName("FK_pw_tblPasswordGroupPerCulture_pw_tblNeutralCultureValues");

                entity.HasOne(d => d.PgcPg)
                    .WithMany(p => p.PwTblPasswordGroupPerCulture)
                    .HasForeignKey(d => d.PgcPgid)
                    .HasConstraintName("FK_pw_tblPasswordGroupPerCulture_pw_tblPasswordGroups");
            });

            modelBuilder.Entity<PwTblPasswordGroups>(entity =>
            {
                entity.HasKey(e => e.PgId);

                entity.ToTable("pw_tblPasswordGroups");

                entity.Property(e => e.PgId).HasColumnName("pgId");

                entity.Property(e => e.PgDateCreated)
                    .HasColumnName("pgDateCreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.PgDateModified)
                    .HasColumnName("pgDateModified")
                    .HasColumnType("datetime");

                entity.Property(e => e.PgName)
                    .IsRequired()
                    .HasColumnName("pgName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PwTblPasswords>(entity =>
            {
                entity.HasKey(e => new { e.PwdPgid, e.PwdPassword });

                entity.ToTable("pw_tblPasswords");

                entity.Property(e => e.PwdPgid).HasColumnName("pwdPGId");

                entity.Property(e => e.PwdPassword)
                    .HasColumnName("pwdPassword")
                    .HasMaxLength(100);

                entity.Property(e => e.PwdUsageCount).HasColumnName("pwdUsageCount");

                entity.HasOne(d => d.PwdPg)
                    .WithMany(p => p.PwTblPasswords)
                    .HasForeignKey(d => d.PwdPgid)
                    .HasConstraintName("FK_pw_tblPasswords_pw_tblPasswordGroups");
            });

            modelBuilder.Entity<PwTblPerformances>(entity =>
            {
                entity.HasKey(e => e.PfId);

                entity.ToTable("pw_tblPerformances");

                entity.HasIndex(e => e.PfPerfCode)
                    .HasName("IX_pw_tblPerformances")
                    .IsUnique();

                entity.HasIndex(e => e.PfVsid)
                    .HasName("IX_pw_tblPerformances_1");

                entity.HasIndex(e => new { e.PfPerfCode, e.PfIsPlaceHolder })
                    .HasName("IX_VenuePerformances");

                entity.HasIndex(e => new { e.PfVsid, e.PfPerformanceDate, e.PfIsRetired })
                    .HasName("NCINDEX_pw_tblPerformances_pfPerformanceDate_pfIsRetired_inc_pfVSId");

                entity.HasIndex(e => new { e.PfVsid, e.PfPerformanceDate, e.PfPaxmasterEventCode })
                    .HasName("NCINDEX_pw_tblPerformances_pfPAXMasterEventCode_inc_pfVSId_pfPerformanceDate");

                entity.Property(e => e.PfId).HasColumnName("pfId");

                entity.Property(e => e.PfIsPlaceHolder).HasColumnName("pfIsPlaceHolder");

                entity.Property(e => e.PfIsRetired).HasColumnName("pfIsRetired");

                entity.Property(e => e.PfIsSoldOut).HasColumnName("pfIsSoldOut");

                entity.Property(e => e.PfOffSaleDate)
                    .HasColumnName("pfOffSaleDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PfOnSaleDate)
                    .HasColumnName("pfOnSaleDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PfPaxmasterEventCode)
                    .HasColumnName("pfPAXMasterEventCode")
                    .HasMaxLength(50);

                entity.Property(e => e.PfPerfCode)
                    .IsRequired()
                    .HasColumnName("pfPerfCode")
                    .HasMaxLength(50);

                entity.Property(e => e.PfPerformanceDate)
                    .HasColumnName("pfPerformanceDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PfPlaceHolderPricing)
                    .IsRequired()
                    .HasColumnName("pfPlaceHolderPricing")
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PfSoftixWhen)
                    .IsRequired()
                    .HasColumnName("pfSoftixWhen")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PfSoftixWhere)
                    .IsRequired()
                    .HasColumnName("pfSoftixWhere")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PfSoftixWho)
                    .IsRequired()
                    .HasColumnName("pfSoftixWho")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PfTicketLimit)
                    .HasColumnName("pfTicketLimit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PfVsid).HasColumnName("pfVSId");

                entity.HasOne(d => d.PfVs)
                    .WithMany(p => p.PwTblPerformances)
                    .HasForeignKey(d => d.PfVsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pw_tblPerformances_pw_tblVenueshows");
            });

            modelBuilder.Entity<PwTblPhysicalAddresses>(entity =>
            {
                entity.HasKey(e => e.PaId);

                entity.ToTable("pw_tblPhysicalAddresses");

                entity.Property(e => e.PaId).HasColumnName("paId");

                entity.Property(e => e.PaAddressLine1)
                    .IsRequired()
                    .HasColumnName("paAddressLine1")
                    .HasMaxLength(200);

                entity.Property(e => e.PaAddressLine2)
                    .IsRequired()
                    .HasColumnName("paAddressLine2")
                    .HasMaxLength(200);

                entity.Property(e => e.PaCity)
                    .IsRequired()
                    .HasColumnName("paCity")
                    .HasMaxLength(200);

                entity.Property(e => e.PaCountry)
                    .IsRequired()
                    .HasColumnName("paCountry")
                    .HasMaxLength(100);

                entity.Property(e => e.PaLatitude)
                    .HasColumnName("paLatitude")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.PaLongitude)
                    .HasColumnName("paLongitude")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.PaPostcode)
                    .IsRequired()
                    .HasColumnName("paPostcode")
                    .HasMaxLength(20);

                entity.Property(e => e.PaSource)
                    .IsRequired()
                    .HasColumnName("paSource")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaState)
                    .IsRequired()
                    .HasColumnName("paState")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PwTblPublishStatusValues>(entity =>
            {
                entity.HasKey(e => e.PsvId);

                entity.ToTable("pw_tblPublishStatusValues");

                entity.Property(e => e.PsvId).HasColumnName("psvId");

                entity.Property(e => e.PsvDescription)
                    .IsRequired()
                    .HasColumnName("psvDescription")
                    .HasMaxLength(4000);

                entity.Property(e => e.PsvName)
                    .IsRequired()
                    .HasColumnName("psvName")
                    .HasMaxLength(50);

                entity.Property(e => e.PsvOrder).HasColumnName("psvOrder");
            });

            modelBuilder.Entity<PwTblScheduledBoxContent>(entity =>
            {
                entity.HasKey(e => e.ScheduledBoxContentId);

                entity.ToTable("pw_tblScheduledBoxContent");

                entity.HasIndex(e => e.ActivateAt);

                entity.HasIndex(e => e.BoxName);

                entity.HasIndex(e => e.DeactivateAt);

                entity.Property(e => e.ScheduledBoxContentId).HasColumnName("ScheduledBoxContentID");

                entity.Property(e => e.ActivateAt).HasColumnType("datetime");

                entity.Property(e => e.BoxName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DeactivateAt).HasColumnType("datetime");

                entity.Property(e => e.ScheduledBoxContentName).HasMaxLength(50);

                entity.Property(e => e.ShowTemplateUserControlOverride).HasMaxLength(100);

                entity.Property(e => e.ShowUrlOverride).HasMaxLength(2000);

                entity.Property(e => e.SoftixCode).HasMaxLength(20);
            });

            modelBuilder.Entity<PwTblSeasonPerformances>(entity =>
            {
                entity.HasKey(e => e.SpId);

                entity.ToTable("pw_tblSeasonPerformances");

                entity.HasIndex(e => e.SpPerfCode)
                    .HasName("IX_pw_tblSeasonPerformances_PerfCode")
                    .IsUnique();

                entity.Property(e => e.SpId).HasColumnName("spId");

                entity.Property(e => e.SpPerfCode)
                    .IsRequired()
                    .HasColumnName("spPerfCode")
                    .HasMaxLength(50);

                entity.Property(e => e.SpPerformanceDate)
                    .HasColumnName("spPerformanceDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SpSoftixWhen)
                    .IsRequired()
                    .HasColumnName("spSoftixWhen")
                    .HasMaxLength(100);

                entity.Property(e => e.SpSoftixWhere)
                    .IsRequired()
                    .HasColumnName("spSoftixWhere")
                    .HasMaxLength(100);

                entity.Property(e => e.SpSoftixWho)
                    .IsRequired()
                    .HasColumnName("spSoftixWho")
                    .HasMaxLength(100);

                entity.Property(e => e.SpVncode)
                    .HasColumnName("spVNCode")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<PwTblSeasonPerformancesCulture>(entity =>
            {
                entity.HasKey(e => e.SpcId);

                entity.ToTable("pw_tblSeasonPerformancesCulture");

                entity.Property(e => e.SpcId).HasColumnName("spcId");

                entity.Property(e => e.SpcNcvcode)
                    .IsRequired()
                    .HasColumnName("spcNCVCode")
                    .HasMaxLength(6);

                entity.Property(e => e.SpcSpid).HasColumnName("spcSPId");

                entity.Property(e => e.SpcTitle)
                    .IsRequired()
                    .HasColumnName("spcTitle")
                    .HasMaxLength(100);

                entity.HasOne(d => d.SpcSp)
                    .WithMany(p => p.PwTblSeasonPerformancesCulture)
                    .HasForeignKey(d => d.SpcSpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pw_tblseasonperformancesculture_pw_tblSeasonPerformances");
            });

            modelBuilder.Entity<PwTblSessionState>(entity =>
            {
                entity.HasKey(e => e.StateId);

                entity.ToTable("pw_tblSessionState");

                entity.Property(e => e.StateId).HasColumnName("stateId");

                entity.Property(e => e.StateCreation)
                    .HasColumnName("stateCreation")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StateData)
                    .IsRequired()
                    .HasColumnName("stateData")
                    .HasColumnType("image");

                entity.Property(e => e.StateLength).HasColumnName("stateLength");

                entity.Property(e => e.StateVerify).HasColumnName("stateVerify");
            });

            modelBuilder.Entity<PwTblSharedStore>(entity =>
            {
                entity.HasKey(e => e.SsId);

                entity.ToTable("pw_tblSharedStore");

                entity.HasIndex(e => new { e.SsKey, e.SsCrc })
                    .HasName("IX_pw_tblSharedStore")
                    .IsUnique();

                entity.Property(e => e.SsId).HasColumnName("ssId");

                entity.Property(e => e.SsCrc)
                    .IsRequired()
                    .HasColumnName("ssCrc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SsDateCreated)
                    .HasColumnName("ssDateCreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.SsDateModified)
                    .HasColumnName("ssDateModified")
                    .HasColumnType("datetime");

                entity.Property(e => e.SsKey)
                    .IsRequired()
                    .HasColumnName("ssKey")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SsValue)
                    .IsRequired()
                    .HasColumnName("ssValue")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<PwTblShowAttributes>(entity =>
            {
                entity.HasKey(e => e.SaId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("pw_tblShowAttributes");

                entity.HasIndex(e => e.SaShid)
                    .HasName("IX_pw_tblShowAttributes")
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => new { e.SaShid, e.SaName })
                    .HasName("IX_pw_tblShowAttributes_1")
                    .IsUnique();

                entity.Property(e => e.SaId).HasColumnName("saId");

                entity.Property(e => e.SaName)
                    .IsRequired()
                    .HasColumnName("saName")
                    .HasMaxLength(200);

                entity.Property(e => e.SaShid).HasColumnName("saSHId");

                entity.Property(e => e.SaValue)
                    .IsRequired()
                    .HasColumnName("saValue");

                entity.HasOne(d => d.SaSh)
                    .WithMany(p => p.PwTblShowAttributes)
                    .HasForeignKey(d => d.SaShid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pw_tblShowAttributes_pw_tblShows");
            });

            modelBuilder.Entity<PwTblShowCultureAttributes>(entity =>
            {
                entity.HasKey(e => e.ScaId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("pw_tblShowCultureAttributes");

                entity.HasIndex(e => new { e.ScaShid, e.ScaNcvcode })
                    .HasName("IX_pw_tblShowCultureAttributes_1")
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => new { e.ScaShid, e.ScaNcvcode, e.ScaName })
                    .HasName("IX_pw_tblShowCultureAttributes")
                    .IsUnique();

                entity.Property(e => e.ScaId).HasColumnName("scaId");

                entity.Property(e => e.ScaName)
                    .IsRequired()
                    .HasColumnName("scaName")
                    .HasMaxLength(200);

                entity.Property(e => e.ScaNcvcode)
                    .IsRequired()
                    .HasColumnName("scaNCVCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ScaShid).HasColumnName("scaSHId");

                entity.Property(e => e.ScaValue)
                    .IsRequired()
                    .HasColumnName("scaValue");

                entity.HasOne(d => d.ScaNcvcodeNavigation)
                    .WithMany(p => p.PwTblShowCultureAttributes)
                    .HasForeignKey(d => d.ScaNcvcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pw_tblShowCultureAttributes_pw_tblNeutralCultureValues");

                entity.HasOne(d => d.ScaSh)
                    .WithMany(p => p.PwTblShowCultureAttributes)
                    .HasForeignKey(d => d.ScaShid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pw_tblShowCultureAttributes_pw_tblShows");
            });

            modelBuilder.Entity<PwTblShowPerCulture>(entity =>
            {
                entity.HasKey(e => e.ScId);

                entity.ToTable("pw_tblShowPerCulture");

                entity.HasIndex(e => new { e.ScShid, e.ScNcvcode })
                    .HasName("IX_pw_tblShowPerCulture")
                    .IsUnique();

                entity.HasIndex(e => new { e.ScShid, e.ScNcvcode, e.ScPsvid })
                    .HasName("IC_pw_tblShowPerCulture_SHID_NCVCode_PSVId");

                entity.HasIndex(e => new { e.ScId, e.ScShid, e.ScNcvcode, e.ScPsvid })
                    .HasName("NCINDEX_pw_tblShowPerCulture_scNCVCode_scPSVId_inc_scId_scSHId");

                entity.HasIndex(e => new { e.ScShid, e.ScNcvcode, e.ScId, e.ScPsvid })
                    .HasName("IC_pw_tblShowPerCulture_SHID_NCVCode_scID_PSVId");

                entity.Property(e => e.ScId).HasColumnName("scId");

                entity.Property(e => e.ScAltTextLarge)
                    .IsRequired()
                    .HasColumnName("scAltTextLarge")
                    .HasMaxLength(1000);

                entity.Property(e => e.ScAltTextMedium)
                    .IsRequired()
                    .HasColumnName("scAltTextMedium")
                    .HasMaxLength(1000);

                entity.Property(e => e.ScAltTextSmall)
                    .IsRequired()
                    .HasColumnName("scAltTextSmall")
                    .HasMaxLength(1000);

                entity.Property(e => e.ScKeywords)
                    .IsRequired()
                    .HasColumnName("scKeywords")
                    .HasMaxLength(4000);

                entity.Property(e => e.ScNcvcode)
                    .IsRequired()
                    .HasColumnName("scNCVCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ScPsvid).HasColumnName("scPSVId");

                entity.Property(e => e.ScShid).HasColumnName("scSHId");

                entity.Property(e => e.ScShowImageLarge)
                    .IsRequired()
                    .HasColumnName("scShowImageLarge")
                    .HasMaxLength(1000);

                entity.Property(e => e.ScShowImageMedium)
                    .IsRequired()
                    .HasColumnName("scShowImageMedium")
                    .HasMaxLength(1000);

                entity.Property(e => e.ScShowImageSmall)
                    .IsRequired()
                    .HasColumnName("scShowImageSmall")
                    .HasMaxLength(1000);

                entity.Property(e => e.ScSummary)
                    .IsRequired()
                    .HasColumnName("scSummary")
                    .HasMaxLength(1000);

                entity.Property(e => e.ScSynopsis)
                    .IsRequired()
                    .HasColumnName("scSynopsis")
                    .HasColumnType("ntext");

                entity.Property(e => e.ScTitle)
                    .IsRequired()
                    .HasColumnName("scTitle")
                    .HasMaxLength(200);

                entity.HasOne(d => d.ScNcvcodeNavigation)
                    .WithMany(p => p.PwTblShowPerCulture)
                    .HasForeignKey(d => d.ScNcvcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pw_tblShowPerCulture_pw_tblNeutralCultureValues");

                entity.HasOne(d => d.ScPsv)
                    .WithMany(p => p.PwTblShowPerCulture)
                    .HasForeignKey(d => d.ScPsvid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pw_tblShowPerCulture_pw_tblPublishStatusValues");

                entity.HasOne(d => d.ScSh)
                    .WithMany(p => p.PwTblShowPerCulture)
                    .HasForeignKey(d => d.ScShid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pw_tblShowPerCulture_tblPerformanceGroups");
            });

            modelBuilder.Entity<PwTblShows>(entity =>
            {
                entity.HasKey(e => e.ShId);

                entity.ToTable("pw_tblShows");

                entity.HasIndex(e => e.ShParentId)
                    .HasName("NCINDEX_pw_tblShows_shParentId");

                entity.HasIndex(e => e.ShSoftixCode)
                    .HasName("IX_pw_tblShows")
                    .IsUnique();

                entity.HasIndex(e => new { e.ShId, e.ShDisappearsDate })
                    .HasName("NCINDEX_pw_tblShows_shDisappearsDate_inc_shId");

                entity.HasIndex(e => new { e.ShId, e.ShSsvname })
                    .HasName("NCINDEX_pw_tblShows_shSSVName_inc_shId");

                entity.Property(e => e.ShId).HasColumnName("shId");

                entity.Property(e => e.ShAppearsDate)
                    .HasColumnName("shAppearsDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShDisappearsDate)
                    .HasColumnName("shDisappearsDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShFriendlyName)
                    .IsRequired()
                    .HasColumnName("shFriendlyName")
                    .HasMaxLength(20);

                entity.Property(e => e.ShIsSoldOut).HasColumnName("shIsSoldOut");

                entity.Property(e => e.ShMarketingTypes)
                    .HasColumnName("shMarketingTypes")
                    .HasMaxLength(100);

                entity.Property(e => e.ShOwncode)
                    .IsRequired()
                    .HasColumnName("shOWNCode")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ShParentId).HasColumnName("shParentId");

                entity.Property(e => e.ShPosition)
                    .HasColumnName("shPosition")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShPriority).HasColumnName("shPriority");

                entity.Property(e => e.ShShvtype)
                    .IsRequired()
                    .HasColumnName("shSHVType")
                    .HasMaxLength(10);

                entity.Property(e => e.ShSoftixCode)
                    .IsRequired()
                    .HasColumnName("shSoftixCode")
                    .HasMaxLength(20);

                entity.Property(e => e.ShSoftixTitle)
                    .IsRequired()
                    .HasColumnName("shSoftixTitle")
                    .HasMaxLength(100);

                entity.Property(e => e.ShSsvname)
                    .IsRequired()
                    .HasColumnName("shSSVName")
                    .HasMaxLength(50);

                entity.HasOne(d => d.ShParent)
                    .WithMany(p => p.InverseShParent)
                    .HasForeignKey(d => d.ShParentId)
                    .HasConstraintName("FK_pw_tblShows_pw_tblShows");

                entity.HasOne(d => d.ShShvtypeNavigation)
                    .WithMany(p => p.PwTblShows)
                    .HasForeignKey(d => d.ShShvtype)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPerformanceGroups_tblPerfGroupTypeValues");

                entity.HasOne(d => d.ShSsvnameNavigation)
                    .WithMany(p => p.PwTblShows)
                    .HasForeignKey(d => d.ShSsvname)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pw_tblShows_pw_tblShowstatusValues");
            });

            modelBuilder.Entity<PwTblShowstatusValues>(entity =>
            {
                entity.HasKey(e => e.SsvName);

                entity.ToTable("pw_tblShowstatusValues");

                entity.Property(e => e.SsvName)
                    .HasColumnName("ssvName")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.SsvDescription)
                    .IsRequired()
                    .HasColumnName("ssvDescription")
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<PwTblShowTypeValues>(entity =>
            {
                entity.HasKey(e => e.ShvType);

                entity.ToTable("pw_tblShowTypeValues");

                entity.Property(e => e.ShvType)
                    .HasColumnName("shvType")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<PwTblSlotPerformancePriceCategoryMappings>(entity =>
            {
                entity.HasKey(e => e.SlppcmId);

                entity.ToTable("pw_tblSlotPerformancePriceCategoryMappings");

                entity.HasIndex(e => e.SlppcmSlpid)
                    .HasName("IC_pw_tblSlotPerformancePriceCategoryMappings_slppcmSLPId");

                entity.Property(e => e.SlppcmId).HasColumnName("slppcmId");

                entity.Property(e => e.SlppcmPerformancePriceCategoryCode).HasColumnName("slppcmPerformancePriceCategoryCode");

                entity.Property(e => e.SlppcmSeriesPriceCategoryCode).HasColumnName("slppcmSeriesPriceCategoryCode");

                entity.Property(e => e.SlppcmSlpid).HasColumnName("slppcmSLPId");

                entity.HasOne(d => d.SlppcmSlp)
                    .WithMany(p => p.PwTblSlotPerformancePriceCategoryMappings)
                    .HasForeignKey(d => d.SlppcmSlpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pw_tblSlotPerformancePriceCategoryMappings_pw_tblSlotPerformances");
            });

            modelBuilder.Entity<PwTblSlotPerformances>(entity =>
            {
                entity.HasKey(e => e.SlpId);

                entity.ToTable("pw_tblSlotPerformances");

                entity.Property(e => e.SlpId).HasColumnName("slpId");

                entity.Property(e => e.SlpHoldCode)
                    .HasColumnName("slpHoldCode")
                    .HasMaxLength(50);

                entity.Property(e => e.SlpOrder).HasColumnName("slpOrder");

                entity.Property(e => e.SlpSelectionNumber)
                    .HasColumnName("slpSelectionNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.SlpSlid).HasColumnName("slpSLId");

                entity.Property(e => e.SlpSpid).HasColumnName("slpSPId");

                entity.HasOne(d => d.SlpSl)
                    .WithMany(p => p.PwTblSlotPerformances)
                    .HasForeignKey(d => d.SlpSlid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pw_tblSlotPerformances_pw_tblSlots");

                entity.HasOne(d => d.SlpSp)
                    .WithMany(p => p.PwTblSlotPerformances)
                    .HasForeignKey(d => d.SlpSpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pw_tblSlotPerformances_tblSeriesPerformances");
            });

            modelBuilder.Entity<PwTblSlots>(entity =>
            {
                entity.HasKey(e => e.SlId);

                entity.ToTable("pw_tblSlots");

                entity.Property(e => e.SlId).HasColumnName("slId");

                entity.Property(e => e.SlIndex).HasColumnName("slIndex");

                entity.Property(e => e.SlMaximumSelections).HasColumnName("slMaximumSelections");

                entity.Property(e => e.SlMinimumSelections)
                    .HasColumnName("slMinimumSelections")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.SlRequiredSelections).HasColumnName("slRequiredSelections");

                entity.Property(e => e.SlShid).HasColumnName("slSHId");

                entity.Property(e => e.SlUiOrder).HasColumnName("slUiOrder");

                entity.HasOne(d => d.SlSh)
                    .WithMany(p => p.PwTblSlots)
                    .HasForeignKey(d => d.SlShid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pw_tblSlots_pw_tblShows");
            });

            modelBuilder.Entity<PwTblSlotsCulture>(entity =>
            {
                entity.HasKey(e => e.ScId);

                entity.ToTable("pw_tblSlotsCulture");

                entity.Property(e => e.ScId).HasColumnName("scId");

                entity.Property(e => e.ScHeading)
                    .IsRequired()
                    .HasColumnName("scHeading")
                    .HasMaxLength(100);

                entity.Property(e => e.ScImageLarge)
                    .HasColumnName("scImageLarge")
                    .HasMaxLength(1000);

                entity.Property(e => e.ScNcvcode)
                    .IsRequired()
                    .HasColumnName("scNCVCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ScSlid).HasColumnName("scSLId");

                entity.Property(e => e.ScSummary).HasColumnName("scSummary");

                entity.HasOne(d => d.ScSl)
                    .WithMany(p => p.PwTblSlotsCulture)
                    .HasForeignKey(d => d.ScSlid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pw_tblSlotsCulture_pw_tblSlots");
            });

            modelBuilder.Entity<PwTblSuperHeroes>(entity =>
            {
                entity.HasKey(e => e.SuperHeroId);

                entity.ToTable("pw_tblSuperHeroes");

                entity.HasIndex(e => e.ActivateAtUtc);

                entity.HasIndex(e => e.DeactivateAtUtc);

                entity.HasIndex(e => e.RegionId);

                entity.Property(e => e.SuperHeroId).HasColumnName("SuperHeroID");

                entity.Property(e => e.ActivateAtUtc).HasColumnType("datetime");

                entity.Property(e => e.DeactivateAtUtc).HasColumnType("datetime");

                entity.Property(e => e.HtmlClosed).IsRequired();

                entity.Property(e => e.HtmlOpen).IsRequired();

                entity.Property(e => e.RegionId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SuperHeroName).HasMaxLength(50);

                entity.Property(e => e.TimeZoneId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PwTblVenueAttributes>(entity =>
            {
                entity.HasKey(e => e.VaId);

                entity.ToTable("pw_tblVenueAttributes");

                entity.HasIndex(e => new { e.VaVsid, e.VaVncode, e.VaName })
                    .HasName("IX_pw_tblVenueAttributes")
                    .IsUnique();

                entity.Property(e => e.VaId).HasColumnName("vaId");

                entity.Property(e => e.VaIconImagePath)
                    .IsRequired()
                    .HasColumnName("vaIconImagePath")
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VaName)
                    .IsRequired()
                    .HasColumnName("vaName")
                    .HasMaxLength(200);

                entity.Property(e => e.VaVncode)
                    .HasColumnName("vaVNCode")
                    .HasMaxLength(10);

                entity.Property(e => e.VaVsid).HasColumnName("vaVSId");

                entity.HasOne(d => d.VaVncodeNavigation)
                    .WithMany(p => p.PwTblVenueAttributes)
                    .HasForeignKey(d => d.VaVncode)
                    .HasConstraintName("FK_pw_tblVenueAttributes_pw_tblVenues");

                entity.HasOne(d => d.VaVs)
                    .WithMany(p => p.PwTblVenueAttributes)
                    .HasForeignKey(d => d.VaVsid)
                    .HasConstraintName("FK_pw_tblVenueAttributes_pw_tblVenueshows");
            });

            modelBuilder.Entity<PwTblVenueAttributesPerCulture>(entity =>
            {
                entity.HasKey(e => new { e.VacVaid, e.VacNcvcode });

                entity.ToTable("pw_tblVenueAttributesPerCulture");

                entity.Property(e => e.VacVaid).HasColumnName("vacVAId");

                entity.Property(e => e.VacNcvcode)
                    .HasColumnName("vacNCVCode")
                    .HasMaxLength(6);

                entity.Property(e => e.VacCategoryTitle)
                    .IsRequired()
                    .HasColumnName("vacCategoryTitle")
                    .HasMaxLength(200);

                entity.Property(e => e.VacDescription)
                    .IsRequired()
                    .HasColumnName("vacDescription")
                    .HasMaxLength(1000);

                entity.Property(e => e.VacName)
                    .IsRequired()
                    .HasColumnName("vacName")
                    .HasMaxLength(200);

                entity.HasOne(d => d.VacNcvcodeNavigation)
                    .WithMany(p => p.PwTblVenueAttributesPerCulture)
                    .HasForeignKey(d => d.VacNcvcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pw_tblVenueAttributesPerCulture_pw_tblNeutralCultureValues");

                entity.HasOne(d => d.VacVa)
                    .WithMany(p => p.PwTblVenueAttributesPerCulture)
                    .HasForeignKey(d => d.VacVaid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pw_tblVenueAttributesPerCulture_pw_tblVenueAttributes");
            });

            modelBuilder.Entity<PwTblVenues>(entity =>
            {
                entity.HasKey(e => e.VnCode);

                entity.ToTable("pw_tblVenues");

                entity.Property(e => e.VnCode)
                    .HasColumnName("vnCode")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.VnEntirelyHidden).HasColumnName("vnEntirelyHidden");

                entity.Property(e => e.VnGeoFenceRadius).HasColumnName("vnGeoFenceRadius");

                entity.Property(e => e.VnOffsetFromBaseTime)
                    .HasColumnName("vnOffsetFromBaseTime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VnOwnerCode)
                    .HasColumnName("vnOwnerCode")
                    .HasMaxLength(20);

                entity.Property(e => e.VnRegex)
                    .HasColumnName("vnRegex")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VnSoftixRegionCode)
                    .HasColumnName("vnSoftixRegionCode")
                    .HasMaxLength(10);

                entity.Property(e => e.VnVisible).HasColumnName("vnVisible");

                entity.Property(e => e.VnWebAddress)
                    .HasColumnName("vnWebAddress")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<PwTblVenueshows>(entity =>
            {
                entity.HasKey(e => e.VsId);

                entity.ToTable("pw_tblVenueshows");

                entity.HasIndex(e => new { e.VsShid, e.VsVncode })
                    .HasName("NCINDEX_pw_tblVenueshows_vsVNCode_inc_vsSHId");

                entity.Property(e => e.VsId).HasColumnName("vsId");

                entity.Property(e => e.VsSellByArea).HasColumnName("vsSellByArea");

                entity.Property(e => e.VsShid).HasColumnName("vsSHId");

                entity.Property(e => e.VsVncode)
                    .IsRequired()
                    .HasColumnName("vsVNCode")
                    .HasMaxLength(10);

                entity.HasOne(d => d.VsSh)
                    .WithMany(p => p.PwTblVenueshows)
                    .HasForeignKey(d => d.VsShid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pw_tblVenueshows_pw_tblShows");

                entity.HasOne(d => d.VsVncodeNavigation)
                    .WithMany(p => p.PwTblVenueshows)
                    .HasForeignKey(d => d.VsVncode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pw_tblVenueshows_pw_tblVenues");
            });

            modelBuilder.Entity<PwTblVenueshowsPerCulture>(entity =>
            {
                entity.HasKey(e => new { e.VscVsid, e.VscNcvcode });

                entity.ToTable("pw_tblVenueshowsPerCulture");

                entity.Property(e => e.VscVsid).HasColumnName("vscVSId");

                entity.Property(e => e.VscNcvcode)
                    .HasColumnName("vscNCVCode")
                    .HasMaxLength(6);

                entity.Property(e => e.VscCategoryNameOverride)
                    .HasColumnName("vscCategoryNameOverride")
                    .HasMaxLength(500);

                entity.Property(e => e.VscSeatingMap)
                    .HasColumnName("vscSeatingMap")
                    .HasMaxLength(1000);

                entity.HasOne(d => d.VscNcvcodeNavigation)
                    .WithMany(p => p.PwTblVenueshowsPerCulture)
                    .HasForeignKey(d => d.VscNcvcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pw_tblVenueshowsPerCulture_pw_tblNeutralCultureValues");

                entity.HasOne(d => d.VscVs)
                    .WithMany(p => p.PwTblVenueshowsPerCulture)
                    .HasForeignKey(d => d.VscVsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pw_tblVenueshowsPerCulture_pw_tblVenueshows");
            });

            modelBuilder.Entity<PwTblVenuesPerCulture>(entity =>
            {
                entity.HasKey(e => new { e.VcVncode, e.VcNcvcode });

                entity.ToTable("pw_tblVenuesPerCulture");

                entity.HasIndex(e => e.VcPaid)
                    .HasName("IX_pw_tblVenuesPerCulture")
                    .IsUnique();

                entity.Property(e => e.VcVncode)
                    .HasColumnName("vcVNCode")
                    .HasMaxLength(10);

                entity.Property(e => e.VcNcvcode)
                    .HasColumnName("vcNCVCode")
                    .HasMaxLength(6);

                entity.Property(e => e.VcName)
                    .IsRequired()
                    .HasColumnName("vcName")
                    .HasMaxLength(200);

                entity.Property(e => e.VcPaid).HasColumnName("vcPAId");

                entity.Property(e => e.VcRegionName)
                    .IsRequired()
                    .HasColumnName("vcRegionName")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VcSeatingMap)
                    .IsRequired()
                    .HasColumnName("vcSeatingMap")
                    .HasMaxLength(1000);

                entity.HasOne(d => d.VcNcvcodeNavigation)
                    .WithMany(p => p.PwTblVenuesPerCulture)
                    .HasForeignKey(d => d.VcNcvcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pw_tblVenuesPerCulture_pw_tblNeutralCultureValues");

                entity.HasOne(d => d.VcVncodeNavigation)
                    .WithMany(p => p.PwTblVenuesPerCulture)
                    .HasForeignKey(d => d.VcVncode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pw_tblVenuesPerCulture_pw_tblVenues");
            });

            modelBuilder.Entity<TblAbbBallotEntry>(entity =>
            {
                entity.HasKey(e => e.BallotEntryId);

                entity.ToTable("tbl_ABB_BallotEntry");

                entity.Property(e => e.BallotEntryId).HasColumnName("BallotEntryID");

                entity.Property(e => e.BallotCode).HasMaxLength(10);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.EntitlementId).HasColumnName("EntitlementID");

                entity.Property(e => e.EntitlementPasswordId).HasColumnName("EntitlementPasswordID");

                entity.Property(e => e.EntitlementUsageId).HasColumnName("EntitlementUsageID");

                entity.Property(e => e.EventCode).HasMaxLength(50);

                entity.Property(e => e.ProtectionGroupId).HasColumnName("ProtectionGroupID");

                entity.Property(e => e.Reason).HasMaxLength(200);

                entity.Property(e => e.Status).HasMaxLength(20);
            });

            modelBuilder.Entity<TblAbbBallotLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("tbl_ABB_BallotLog");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.ActionDescription).HasMaxLength(1000);

                entity.Property(e => e.BallotCode).HasMaxLength(10);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblActivityRecordJoin>(entity =>
            {
                entity.HasKey(e => e.ActivityRecordJoinId);

                entity.ToTable("tbl_ActivityRecordJoin");

                entity.Property(e => e.ActivityRecordJoinId).HasColumnName("ActivityRecordJoinID");

                entity.Property(e => e.ActivityRecordId).HasColumnName("ActivityRecordID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FollowUpSellerId).HasColumnName("FollowUpSellerID");

                entity.Property(e => e.OrganisationCustomerId).HasColumnName("OrganisationCustomerID");

                entity.Property(e => e.SellerId).HasColumnName("SellerID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.ActivityRecord)
                    .WithMany(p => p.TblActivityRecordJoin)
                    .HasForeignKey(d => d.ActivityRecordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ActivityRecordJoin_tblCustomerActivityRecord");

                entity.HasOne(d => d.OrganisationCustomer)
                    .WithMany(p => p.TblActivityRecordJoin)
                    .HasForeignKey(d => d.OrganisationCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ActivityRecordJoin_tblOrganisationCustomer");
            });

            modelBuilder.Entity<TblActivityType>(entity =>
            {
                entity.HasKey(e => e.ActivityTypeId);

                entity.ToTable("tblActivityType");

                entity.HasIndex(e => e.ActivityTypeName)
                    .HasName("uc_tblActivityType_ActivityTypeName")
                    .IsUnique();

                entity.Property(e => e.ActivityTypeId).HasColumnName("ActivityTypeID");

                entity.Property(e => e.ActivityTypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblActivityTypeAttribute>(entity =>
            {
                entity.HasKey(e => e.AttributeId);

                entity.ToTable("tblActivityTypeAttribute");

                entity.HasIndex(e => new { e.ActivityTypeId, e.AttributeId })
                    .HasName("IX_ActivityTypeID_AttributeID")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.ActivityTypeId).HasColumnName("ActivityTypeID");

                entity.Property(e => e.AttributeDataTypeId).HasColumnName("AttributeDataTypeID");

                entity.Property(e => e.AttributeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CommonAttributeId).HasColumnName("CommonAttributeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DisplayLabel)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.ValidationError).HasMaxLength(50);

                entity.Property(e => e.ValidationText).HasMaxLength(500);

                entity.HasOne(d => d.ActivityType)
                    .WithMany(p => p.TblActivityTypeAttribute)
                    .HasForeignKey(d => d.ActivityTypeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("tblActivityType_tblActivityTypeAttribute_FK1");

                entity.HasOne(d => d.AttributeDataType)
                    .WithMany(p => p.TblActivityTypeAttribute)
                    .HasForeignKey(d => d.AttributeDataTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblRefAttributeDataType_tblActivityTypeAttribute_FK1");

                entity.HasOne(d => d.CommonAttribute)
                    .WithMany(p => p.TblActivityTypeAttribute)
                    .HasForeignKey(d => d.CommonAttributeId)
                    .HasConstraintName("tblActivityTypeCommonAttribute_tblRefActivityTypeAttribute_FK1");
            });

            modelBuilder.Entity<TblActivityTypeAttributeValue>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("tblActivityTypeAttributeValue");

                entity.HasIndex(e => e.AttributeId);

                entity.HasIndex(e => new { e.ActivityRecordId, e.AttributeId })
                    .HasName("uc_ActivityRecordID_AttributeID")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.ActivityRecordId).HasColumnName("ActivityRecordID");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.AttributeDataTypeId).HasColumnName("AttributeDataTypeID");

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.ChoiceId).HasColumnName("ChoiceID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateTimeValue).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TextValue).HasMaxLength(200);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.ActivityRecord)
                    .WithMany(p => p.TblActivityTypeAttributeValue)
                    .HasForeignKey(d => d.ActivityRecordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblCustomerActivityRecord_tblCustomerActivityAttributeValue_FK1");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.TblActivityTypeAttributeValue)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("tblAddress_tblActivityTypeAttributeValue_FK1");

                entity.HasOne(d => d.AttributeDataType)
                    .WithMany(p => p.TblActivityTypeAttributeValue)
                    .HasForeignKey(d => d.AttributeDataTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblRefAttributeDataType_tblActivityTypeAttributeValue_FK1");

                entity.HasOne(d => d.Attribute)
                    .WithMany(p => p.TblActivityTypeAttributeValue)
                    .HasForeignKey(d => d.AttributeId)
                    .HasConstraintName("tblActivityTypeAttribute_tblCustomerActivityAttributeValue_FK1");

                entity.HasOne(d => d.Choice)
                    .WithMany(p => p.TblActivityTypeAttributeValue)
                    .HasForeignKey(d => d.ChoiceId)
                    .HasConstraintName("tblActivityTypeChoiceAttribute_tblActivityTypeAttributeValue_FK1");
            });

            modelBuilder.Entity<TblActivityTypeChoiceAttribute>(entity =>
            {
                entity.HasKey(e => e.ChoiceId);

                entity.ToTable("tblActivityTypeChoiceAttribute");

                entity.HasIndex(e => new { e.CommonAttributeId, e.ChoiceName })
                    .HasName("uc_ActivityTypeChoice_ChoiceName")
                    .IsUnique();

                entity.Property(e => e.ChoiceId).HasColumnName("ChoiceID");

                entity.Property(e => e.ChoiceName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CommonAttributeId).HasColumnName("CommonAttributeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DisplayLabel).HasMaxLength(100);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.CommonAttribute)
                    .WithMany(p => p.TblActivityTypeChoiceAttribute)
                    .HasForeignKey(d => d.CommonAttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblActivityTypeCommonAttribute_tblActivityTypeChoiceAttribute_FK1");
            });

            modelBuilder.Entity<TblActivityTypeCommonAttribute>(entity =>
            {
                entity.HasKey(e => e.CommonAttributeId);

                entity.ToTable("tblActivityTypeCommonAttribute");

                entity.HasIndex(e => e.AttributeName)
                    .HasName("uc_tblActivityTypeCommonAttribute_AttributeName")
                    .IsUnique();

                entity.Property(e => e.CommonAttributeId).HasColumnName("CommonAttributeID");

                entity.Property(e => e.AddressTypeId).HasColumnName("AddressTypeID");

                entity.Property(e => e.AttributeDataTypeId).HasColumnName("AttributeDataTypeID");

                entity.Property(e => e.AttributeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DisplayLabel).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.AddressType)
                    .WithMany(p => p.TblActivityTypeCommonAttribute)
                    .HasForeignKey(d => d.AddressTypeId)
                    .HasConstraintName("FK_tblActivityTypeCommonAttribute_tblAddressType");

                entity.HasOne(d => d.AttributeDataType)
                    .WithMany(p => p.TblActivityTypeCommonAttribute)
                    .HasForeignKey(d => d.AttributeDataTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblAttributeDataType_tblActivityTypeCommonAttribute_FK1");
            });

            modelBuilder.Entity<TblAddress>(entity =>
            {
                entity.HasKey(e => e.AddressId);

                entity.ToTable("tblAddress");

                entity.HasIndex(e => e.AddressLine1)
                    .HasName("idx_AddressL1");

                entity.HasIndex(e => e.AddressLine2)
                    .HasName("idx_AddressL2");

                entity.HasIndex(e => e.AddressLine3)
                    .HasName("idx_AddressL3");

                entity.HasIndex(e => e.City)
                    .HasName("idx_City");

                entity.HasIndex(e => e.HouseNumber)
                    .HasName("idx_HouseNumber");

                entity.HasIndex(e => e.Postcode)
                    .HasName("idx_Postcode");

                entity.HasIndex(e => new { e.AddressLine1, e.City })
                    .HasName("IX_AddressLine1_City");

                entity.HasIndex(e => new { e.AddressLine2, e.City })
                    .HasName("IX_AddressLine2_City");

                entity.HasIndex(e => new { e.AddressLine3, e.City })
                    .HasName("IX_AddressLine3_City");

                entity.HasIndex(e => new { e.AddressLine3, e.City, e.State, e.Postcode, e.CountryName, e.AddressId, e.HouseNumber, e.ApartmentNumber, e.AddressLine1, e.AddressLine2 })
                    .HasName("idx_tblAddress_AddressID_HouseNumber_ApartmentNumber_AddressLine1_AddressLine2");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.AddressBarcode).HasMaxLength(100);

                entity.Property(e => e.AddressLine1).HasMaxLength(200);

                entity.Property(e => e.AddressLine2).HasMaxLength(200);

                entity.Property(e => e.AddressLine3).HasMaxLength(200);

                entity.Property(e => e.AddressTypeId).HasColumnName("AddressTypeID");

                entity.Property(e => e.ApartmentNumber).HasMaxLength(10);

                entity.Property(e => e.City).HasMaxLength(200);

                entity.Property(e => e.CleanedDate).HasColumnType("datetime");

                entity.Property(e => e.CountryCode).HasMaxLength(10);

                entity.Property(e => e.CountryName).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Dpid).HasColumnName("DPID");

                entity.Property(e => e.HouseNumber).HasMaxLength(10);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Postcode).HasMaxLength(20);

                entity.Property(e => e.State).HasMaxLength(100);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.AddressType)
                    .WithMany(p => p.TblAddress)
                    .HasForeignKey(d => d.AddressTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblAddressType_tblCustomerAddress_FK1");
            });

            modelBuilder.Entity<TblAddressType>(entity =>
            {
                entity.HasKey(e => e.AddressTypeId);

                entity.ToTable("tblAddressType");

                entity.HasIndex(e => e.AddressTypeName)
                    .HasName("uc_tblAddressType_AddressTypeName")
                    .IsUnique();

                entity.Property(e => e.AddressTypeId).HasColumnName("AddressTypeID");

                entity.Property(e => e.AddressLine1IsEnabled).HasDefaultValueSql("((1))");

                entity.Property(e => e.AddressLine1IsRequired).HasDefaultValueSql("((1))");

                entity.Property(e => e.AddressLine1Label)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'1')");

                entity.Property(e => e.AddressLine2IsEnabled).HasDefaultValueSql("((1))");

                entity.Property(e => e.AddressLine2IsRequired).HasDefaultValueSql("((1))");

                entity.Property(e => e.AddressLine2Label)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'1')");

                entity.Property(e => e.AddressLine3IsEnabled).HasDefaultValueSql("((1))");

                entity.Property(e => e.AddressLine3IsRequired).HasDefaultValueSql("((1))");

                entity.Property(e => e.AddressLine3Label)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'1')");

                entity.Property(e => e.AddressTypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ApartmentNumberIsEnabled).HasDefaultValueSql("((1))");

                entity.Property(e => e.ApartmentNumberIsRequired).HasDefaultValueSql("((1))");

                entity.Property(e => e.ApartmentNumberLabel)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'1')");

                entity.Property(e => e.CityIsEnabled).HasDefaultValueSql("((1))");

                entity.Property(e => e.CityIsRequired).HasDefaultValueSql("((1))");

                entity.Property(e => e.CityLabel)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'1')");

                entity.Property(e => e.CountryCodeIsEnabled).HasDefaultValueSql("((1))");

                entity.Property(e => e.CountryCodeIsRequired).HasDefaultValueSql("((1))");

                entity.Property(e => e.CountryCodeLabel)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'1')");

                entity.Property(e => e.CountryNameIsEnabled).HasDefaultValueSql("((1))");

                entity.Property(e => e.CountryNameIsRequired).HasDefaultValueSql("((1))");

                entity.Property(e => e.CountryNameLabel)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'1')");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.HouseNumberIsEnabled).HasDefaultValueSql("((1))");

                entity.Property(e => e.HouseNumberIsRequired).HasDefaultValueSql("((1))");

                entity.Property(e => e.HouseNumberLabel)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'1')");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PostCodeIsEnabled).HasDefaultValueSql("((1))");

                entity.Property(e => e.PostCodeIsRequired).HasDefaultValueSql("((1))");

                entity.Property(e => e.PostCodeLabel)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'1')");

                entity.Property(e => e.StateIsEnabled).HasDefaultValueSql("((1))");

                entity.Property(e => e.StateIsRequired).HasDefaultValueSql("((1))");

                entity.Property(e => e.StateLabel)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'1')");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblAllocationFilterDefinition>(entity =>
            {
                entity.HasKey(e => e.FilterId);

                entity.ToTable("tbl_AllocationFilterDefinition");

                entity.Property(e => e.FilterId).HasColumnName("FilterID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FilterDescription).HasMaxLength(50);

                entity.Property(e => e.FilterName).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblAllocationFilterDetails>(entity =>
            {
                entity.HasKey(e => e.OrgFilterDetailsId);

                entity.ToTable("tbl_AllocationFilterDetails");

                entity.Property(e => e.OrgFilterDetailsId).HasColumnName("OrgFilterDetailsID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FilterId).HasColumnName("FilterID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderClassification).HasMaxLength(2000);

                entity.Property(e => e.ProcessGroup).HasMaxLength(50);

                entity.Property(e => e.ProcessSproc)
                    .HasColumnName("ProcessSProc")
                    .HasMaxLength(100);

                entity.Property(e => e.SelectSproc)
                    .HasColumnName("SelectSProc")
                    .HasMaxLength(100);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.WorkflowStatus).HasMaxLength(50);

                entity.HasOne(d => d.Filter)
                    .WithMany(p => p.TblAllocationFilterDetails)
                    .HasForeignKey(d => d.FilterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_AllocationFilterDetails_tbl_AllocationFilterDefinition");
            });

            modelBuilder.Entity<TblAllocationProcessOrganisationJoin>(entity =>
            {
                entity.HasKey(e => new { e.OrganisationId, e.ProcessingLevel, e.FilterId });

                entity.ToTable("tbl_AllocationProcessOrganisationJoin");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.FilterId).HasColumnName("FilterID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.HasOne(d => d.Filter)
                    .WithMany(p => p.TblAllocationProcessOrganisationJoin)
                    .HasForeignKey(d => d.FilterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_AllocationProcessOrganisationJoin_tbl_AllocationFilterDefinition");

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblAllocationProcessOrganisationJoin)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_AllocationProcessOrganisationJoin_tblOrganisation");
            });

            modelBuilder.Entity<TblAttributeDataType>(entity =>
            {
                entity.HasKey(e => e.AttributeDataTypeId);

                entity.ToTable("tblAttributeDataType");

                entity.Property(e => e.AttributeDataTypeId)
                    .HasColumnName("AttributeDataTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AttributeDataTypeName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblAuditDataExchangeFile>(entity =>
            {
                entity.HasKey(e => e.AuditFileId);

                entity.ToTable("tbl_AuditDataExchangeFile");

                entity.Property(e => e.AuditFileId).HasColumnName("AuditFileID");

                entity.Property(e => e.AuditDateTime)
                    .HasColumnName("Audit_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.AuditOperation)
                    .IsRequired()
                    .HasColumnName("Audit_Operation")
                    .HasMaxLength(1);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.Md5checkSum)
                    .HasColumnName("MD5CheckSum")
                    .HasMaxLength(32);

                entity.Property(e => e.MessageTypeId).HasColumnName("MessageTypeID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<TblAuthorisationStatus>(entity =>
            {
                entity.HasKey(e => e.AuthorisationStatusId);

                entity.ToTable("tblAuthorisationStatus");

                entity.Property(e => e.AuthorisationStatusId)
                    .HasColumnName("AuthorisationStatusID")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblAutomaticRenewalPaymentMethod>(entity =>
            {
                entity.HasKey(e => e.AutomaticRenewalPaymentMethodId);

                entity.ToTable("tbl_AutomaticRenewalPaymentMethod");

                entity.Property(e => e.AutomaticRenewalPaymentMethodId).HasColumnName("AutomaticRenewalPaymentMethodID");

                entity.Property(e => e.BankAccountId).HasColumnName("BankAccountID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreditCardId).HasColumnName("CreditCardID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationCustomerId).HasColumnName("OrganisationCustomerID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.BankAccount)
                    .WithMany(p => p.TblAutomaticRenewalPaymentMethod)
                    .HasForeignKey(d => d.BankAccountId)
                    .HasConstraintName("FK_tbl_AutomaticRenewalPaymentMethod_tbl_BankAccount");

                entity.HasOne(d => d.CreditCard)
                    .WithMany(p => p.TblAutomaticRenewalPaymentMethod)
                    .HasForeignKey(d => d.CreditCardId)
                    .HasConstraintName("FK_tbl_AutomaticRenewalPaymentMethod_tbl_CreditCardDetails");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblAutomaticRenewalPaymentMethod)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_AutomaticRenewalPaymentMethod_tblCustomer");

                entity.HasOne(d => d.OrganisationCustomer)
                    .WithMany(p => p.TblAutomaticRenewalPaymentMethod)
                    .HasForeignKey(d => d.OrganisationCustomerId)
                    .HasConstraintName("FK_tbl_AutomaticRenewalPaymentMethod_tblOrganisationCustomer");
            });

            modelBuilder.Entity<TblBallot>(entity =>
            {
                entity.HasKey(e => e.BallotId);

                entity.ToTable("tbl_Ballot");

                entity.Property(e => e.BallotId).HasColumnName("BallotID");

                entity.Property(e => e.AllocateToHold).HasColumnType("nchar(1)");

                entity.Property(e => e.AllowNonEfpentries).HasColumnName("AllowNonEFPEntries");

                entity.Property(e => e.BallotName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FailedCreditCardHold)
                    .IsRequired()
                    .HasColumnType("char(1)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SellerCode).HasMaxLength(20);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblBallotAction>(entity =>
            {
                entity.HasKey(e => e.BallotActionId);

                entity.ToTable("tbl_BallotAction");

                entity.HasIndex(e => e.BallotId)
                    .HasName("IC_tbl_BallotAction_BallotID");

                entity.Property(e => e.BallotActionId).HasColumnName("BallotActionID");

                entity.Property(e => e.ActionTitle)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.BallotId).HasColumnName("BallotID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Ballot)
                    .WithMany(p => p.TblBallotAction)
                    .HasForeignKey(d => d.BallotId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_BallotAction_BallotID");
            });

            modelBuilder.Entity<TblBallotEntry>(entity =>
            {
                entity.HasKey(e => e.BallotEntryId);

                entity.ToTable("tbl_BallotEntry");

                entity.HasIndex(e => e.BallotId)
                    .HasName("IC_tbl_BallotEntry_BallotID");

                entity.HasIndex(e => e.BallotProcessStatusId)
                    .HasName("IC_tbl_BallotEntry_BallotProcessStatusID");

                entity.HasIndex(e => e.BallotSeatingChoiceId)
                    .HasName("IC_tbl_BallotEntry_BallotSeatingChoiceID");

                entity.Property(e => e.BallotEntryId).HasColumnName("BallotEntryID");

                entity.Property(e => e.AllocationPerformanceCode).HasMaxLength(20);

                entity.Property(e => e.AllocationSeating).HasMaxLength(100);

                entity.Property(e => e.AmountPaid).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.BallotId).HasColumnName("BallotID");

                entity.Property(e => e.BallotProcessStatusId).HasColumnName("BallotProcessStatusID");

                entity.Property(e => e.BallotSeatingChoiceId).HasColumnName("BallotSeatingChoiceID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreditCardExpiry).HasColumnType("char(4)");

                entity.Property(e => e.CreditCardHolderName).HasMaxLength(50);

                entity.Property(e => e.CreditCardName).HasMaxLength(50);

                entity.Property(e => e.CreditCardNumber).HasMaxLength(512);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DeliveryType).HasColumnType("char(1)");

                entity.Property(e => e.HandlingFeeAmount).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OriginAccountFile).HasColumnType("char(3)");

                entity.Property(e => e.RegistrationChannelCode).HasMaxLength(1);

                entity.Property(e => e.RegistrationDateTime).HasColumnType("datetime");

                entity.Property(e => e.RegistrationPerformanceCode).HasMaxLength(20);

                entity.Property(e => e.RegistrationSellerCode).HasMaxLength(50);

                entity.Property(e => e.RegistrationSourcePriceType).HasColumnType("nchar(1)");

                entity.Property(e => e.SalesAmount).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Ballot)
                    .WithMany(p => p.TblBallotEntry)
                    .HasForeignKey(d => d.BallotId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_BallotEntry_BallotID");

                entity.HasOne(d => d.BallotProcessStatus)
                    .WithMany(p => p.TblBallotEntry)
                    .HasForeignKey(d => d.BallotProcessStatusId)
                    .HasConstraintName("FK_tbl_BallotEntry_BallotProcessStatusID");

                entity.HasOne(d => d.BallotSeatingChoice)
                    .WithMany(p => p.TblBallotEntry)
                    .HasForeignKey(d => d.BallotSeatingChoiceId)
                    .HasConstraintName("FK_tbl_BallotEntry_BallotSeatingChoiceID");
            });

            modelBuilder.Entity<TblBallotEntryCustomer>(entity =>
            {
                entity.HasKey(e => e.BallotEntryId);

                entity.ToTable("tbl_BallotEntryCustomer");

                entity.Property(e => e.BallotEntryId)
                    .HasColumnName("BallotEntryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressLine1).HasMaxLength(200);

                entity.Property(e => e.AddressLine2).HasMaxLength(200);

                entity.Property(e => e.AreaCode).HasMaxLength(10);

                entity.Property(e => e.City).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FirstName).HasMaxLength(200);

                entity.Property(e => e.LastName).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PhoneNumber).HasMaxLength(20);

                entity.Property(e => e.Postcode).HasMaxLength(20);

                entity.Property(e => e.Salutation).HasMaxLength(10);

                entity.Property(e => e.State).HasMaxLength(100);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.BallotEntry)
                    .WithOne(p => p.TblBallotEntryCustomer)
                    .HasForeignKey<TblBallotEntryCustomer>(d => d.BallotEntryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_BallotEntryCustomer_BallotEntryID");
            });

            modelBuilder.Entity<TblBallotEntryMember>(entity =>
            {
                entity.HasKey(e => e.BallotEntryMemberId);

                entity.ToTable("tbl_BallotEntryMember");

                entity.HasIndex(e => e.BallotEntryId)
                    .HasName("IC_tbl_BallotEntryMember_BallotEntryID");

                entity.HasIndex(e => e.EntitlementUsageId)
                    .HasName("NCINDEX_tbl_BallotEntryMember_EntitlementUsageID");

                entity.Property(e => e.BallotEntryMemberId).HasColumnName("BallotEntryMemberID");

                entity.Property(e => e.Admits).HasDefaultValueSql("((1))");

                entity.Property(e => e.BallotEntryId).HasColumnName("BallotEntryID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EntitlementUsageId).HasColumnName("EntitlementUsageID");

                entity.Property(e => e.MemberIdentifier)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OfferCode).HasMaxLength(20);

                entity.Property(e => e.PriceType)
                    .IsRequired()
                    .HasColumnType("char(1)");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.BallotEntry)
                    .WithMany(p => p.TblBallotEntryMember)
                    .HasForeignKey(d => d.BallotEntryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_BallotEntryMember_BallotEntryID");
            });

            modelBuilder.Entity<TblBallotGroup>(entity =>
            {
                entity.HasKey(e => e.BallotGroupId);

                entity.ToTable("tbl_BallotGroup");

                entity.HasIndex(e => e.BallotGroupName)
                    .HasName("UC_tbl_BallotGroup_BallotGroupName")
                    .IsUnique();

                entity.Property(e => e.BallotGroupId).HasColumnName("BallotGroupID");

                entity.Property(e => e.BallotGroupName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EntitlementId).HasColumnName("EntitlementID");

                entity.Property(e => e.InstalmentsFeePerformanceCode).HasMaxLength(20);

                entity.Property(e => e.InstalmentsFeePriceType).HasColumnType("nchar(1)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Entitlement)
                    .WithMany(p => p.TblBallotGroup)
                    .HasForeignKey(d => d.EntitlementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_BallotGroup_EntitlementID");
            });

            modelBuilder.Entity<TblBallotGroupAction>(entity =>
            {
                entity.HasKey(e => e.BallotGroupActionId);

                entity.ToTable("tbl_BallotGroupAction");

                entity.Property(e => e.BallotGroupActionId).HasColumnName("BallotGroupActionID");

                entity.Property(e => e.ActionTitle)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.BallotGroupId).HasColumnName("BallotGroupID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.BallotGroup)
                    .WithMany(p => p.TblBallotGroupAction)
                    .HasForeignKey(d => d.BallotGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_BallotGroupAction_BallotGroupID");
            });

            modelBuilder.Entity<TblBallotGroupBallot>(entity =>
            {
                entity.HasKey(e => new { e.BallotGroupId, e.BallotId });

                entity.ToTable("tbl_BallotGroupBallot");

                entity.Property(e => e.BallotGroupId).HasColumnName("BallotGroupID");

                entity.Property(e => e.BallotId).HasColumnName("BallotID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.BallotGroup)
                    .WithMany(p => p.TblBallotGroupBallot)
                    .HasForeignKey(d => d.BallotGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_BallotGroupBallot_BallotGroupID");

                entity.HasOne(d => d.Ballot)
                    .WithMany(p => p.TblBallotGroupBallot)
                    .HasForeignKey(d => d.BallotId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_BallotGroupBallot_BallotID");
            });

            modelBuilder.Entity<TblBallotGroupEntry>(entity =>
            {
                entity.HasKey(e => e.BallotGroupEntryId);

                entity.ToTable("tbl_BallotGroupEntry");

                entity.Property(e => e.BallotGroupEntryId).HasColumnName("BallotGroupEntryID");

                entity.Property(e => e.BallotGroupEntryGroupId).HasColumnName("BallotGroupEntryGroupID");

                entity.Property(e => e.BallotGroupRuleId).HasColumnName("BallotGroupRuleID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.BallotGroupEntryGroup)
                    .WithMany(p => p.TblBallotGroupEntry)
                    .HasForeignKey(d => d.BallotGroupEntryGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_BallotGroupEntry_BallotGroupEntryGroupID");

                entity.HasOne(d => d.BallotGroupRule)
                    .WithMany(p => p.TblBallotGroupEntry)
                    .HasForeignKey(d => d.BallotGroupRuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_BallotGroupEntry_BallotGroupRuleID");
            });

            modelBuilder.Entity<TblBallotGroupEntryBallotEntry>(entity =>
            {
                entity.HasKey(e => new { e.BallotGroupEntryId, e.BallotEntryId });

                entity.ToTable("tbl_BallotGroupEntryBallotEntry");

                entity.Property(e => e.BallotGroupEntryId).HasColumnName("BallotGroupEntryID");

                entity.Property(e => e.BallotEntryId).HasColumnName("BallotEntryID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.BallotEntry)
                    .WithMany(p => p.TblBallotGroupEntryBallotEntry)
                    .HasForeignKey(d => d.BallotEntryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_BallotGroupEntryBallotEntry_BallotEntryID");

                entity.HasOne(d => d.BallotGroupEntry)
                    .WithMany(p => p.TblBallotGroupEntryBallotEntry)
                    .HasForeignKey(d => d.BallotGroupEntryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_BallotGroupEntryBallotEntry_BallotGroupEntryID");
            });

            modelBuilder.Entity<TblBallotGroupEntryGroup>(entity =>
            {
                entity.HasKey(e => e.BallotGroupEntryGroupId);

                entity.ToTable("tbl_BallotGroupEntryGroup");

                entity.Property(e => e.BallotGroupEntryGroupId).HasColumnName("BallotGroupEntryGroupID");

                entity.Property(e => e.BallotGroupId).HasColumnName("BallotGroupID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PartPaymentFee).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.BallotGroup)
                    .WithMany(p => p.TblBallotGroupEntryGroup)
                    .HasForeignKey(d => d.BallotGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_BallotGroupEntryGroup_BallotGroupID");
            });

            modelBuilder.Entity<TblBallotGroupRule>(entity =>
            {
                entity.HasKey(e => e.BallotGroupRuleId);

                entity.ToTable("tbl_BallotGroupRule");

                entity.HasIndex(e => new { e.BallotGroupId, e.SourcePriceType })
                    .HasName("UC_tbl_BallotGroupRule_BallotGroupID_SourcePriceType")
                    .IsUnique();

                entity.Property(e => e.BallotGroupRuleId).HasColumnName("BallotGroupRuleID");

                entity.Property(e => e.BallotGroupId).HasColumnName("BallotGroupID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SourcePriceType)
                    .IsRequired()
                    .HasColumnType("nchar(1)");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.BallotGroup)
                    .WithMany(p => p.TblBallotGroupRule)
                    .HasForeignKey(d => d.BallotGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_BallotGroupRule_BallotGroupID");
            });

            modelBuilder.Entity<TblBallotPriorityBand>(entity =>
            {
                entity.HasKey(e => e.PriorityBandId);

                entity.ToTable("tbl_BallotPriorityBand");

                entity.Property(e => e.PriorityBandId).HasColumnName("PriorityBandID");

                entity.Property(e => e.BallotId).HasColumnName("BallotID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EndDateTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RegistrationPerformanceCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Ballot)
                    .WithMany(p => p.TblBallotPriorityBand)
                    .HasForeignKey(d => d.BallotId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_BallotPriorityBand_BallotID");
            });

            modelBuilder.Entity<TblBallotProcessStatus>(entity =>
            {
                entity.HasKey(e => e.BallotProcessStatusId);

                entity.ToTable("tbl_BallotProcessStatus");

                entity.Property(e => e.BallotProcessStatusId)
                    .HasColumnName("BallotProcessStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BallotProcessStatusName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblBallotSeatingAllocation>(entity =>
            {
                entity.HasKey(e => e.BallotSeatingAllocationId);

                entity.ToTable("tbl_BallotSeatingAllocation");

                entity.HasIndex(e => e.BallotSeatingChoiceId)
                    .HasName("IC_tbl_BallotSeatingAllocation_BallotSeatingChoiceID");

                entity.Property(e => e.BallotSeatingAllocationId).HasColumnName("BallotSeatingAllocationID");

                entity.Property(e => e.BallotSeatingChoiceId).HasColumnName("BallotSeatingChoiceID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DemandArea)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PerformanceCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.BallotSeatingChoice)
                    .WithMany(p => p.TblBallotSeatingAllocation)
                    .HasForeignKey(d => d.BallotSeatingChoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_BallotSeatingAllocation_BallotSeatingChoiceID");
            });

            modelBuilder.Entity<TblBallotSeatingChoice>(entity =>
            {
                entity.HasKey(e => e.BallotSeatingChoiceId);

                entity.ToTable("tbl_BallotSeatingChoice");

                entity.HasIndex(e => e.BallotId)
                    .HasName("IC_tbl_BallotSeatingChoice_BallotID");

                entity.Property(e => e.BallotSeatingChoiceId).HasColumnName("BallotSeatingChoiceID");

                entity.Property(e => e.BallotId).HasColumnName("BallotID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SeatingChoiceName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Ballot)
                    .WithMany(p => p.TblBallotSeatingChoice)
                    .HasForeignKey(d => d.BallotId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_BallotSeatingChoice_BallotID");
            });

            modelBuilder.Entity<TblBankAccount>(entity =>
            {
                entity.HasKey(e => e.BankAccountId);

                entity.ToTable("tbl_BankAccount");

                entity.Property(e => e.BankAccountId).HasColumnName("BankAccountID");

                entity.Property(e => e.AccountName).HasMaxLength(100);

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("BranchID")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblBankAccount)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_BankAccount_tblCustomer");
            });

            modelBuilder.Entity<TblBillingRecord>(entity =>
            {
                entity.HasKey(e => e.BillingId);

                entity.ToTable("tblBillingRecord");

                entity.HasIndex(e => e.InventoryTransactionId);

                entity.HasIndex(e => e.OrderId);

                entity.Property(e => e.BillingId)
                    .HasColumnName("BillingID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AuthorisationId)
                    .HasColumnName("AuthorisationID")
                    .HasMaxLength(10);

                entity.Property(e => e.AuthorisationStatusId)
                    .HasColumnName("AuthorisationStatusID")
                    .HasMaxLength(10);

                entity.Property(e => e.BillingAmount).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.BillingDateTime).HasColumnType("datetime");

                entity.Property(e => e.ChangedBy).HasMaxLength(50);

                entity.Property(e => e.CollectableDueDate).HasColumnType("datetime");

                entity.Property(e => e.Comment).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreditCardName).HasMaxLength(50);

                entity.Property(e => e.CreditCardNumber).HasMaxLength(512);

                entity.Property(e => e.CustomerAreaCode).HasMaxLength(10);

                entity.Property(e => e.CustomerName).HasMaxLength(50);

                entity.Property(e => e.CustomerPhone).HasMaxLength(20);

                entity.Property(e => e.CustomerPostCode).HasMaxLength(20);

                entity.Property(e => e.Eftdone).HasColumnName("EFTDone");

                entity.Property(e => e.Eftfailed).HasColumnName("EFTFailed");

                entity.Property(e => e.Eftpending).HasColumnName("EFTPending");

                entity.Property(e => e.Eftreference)
                    .HasColumnName("EFTReference")
                    .HasMaxLength(50);

                entity.Property(e => e.Eftstatus).HasColumnName("EFTStatus");

                entity.Property(e => e.EftstatusMessage)
                    .HasColumnName("EFTStatusMessage")
                    .HasMaxLength(50);

                entity.Property(e => e.EuroRounding).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.FundsMoved).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.GiroBankAccount).HasMaxLength(15);

                entity.Property(e => e.HowPaidCchp).HasColumnName("HowPaid_CCHP");

                entity.Property(e => e.InventoryTransactionId).HasColumnName("InventoryTransactionID");

                entity.Property(e => e.LastFourDigits).HasMaxLength(4);

                entity.Property(e => e.LastTimeUsed).HasColumnType("datetime");

                entity.Property(e => e.MerchantName).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PayType).HasMaxLength(10);

                entity.Property(e => e.PayTypeFee).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.ReplacedBillingRecordId).HasColumnName("ReplacedBillingRecordID");

                entity.Property(e => e.ReplacementBillingId).HasColumnName("ReplacementBillingID");

                entity.Property(e => e.Seller).HasMaxLength(10);

                entity.Property(e => e.SettlementStatus).HasMaxLength(10);

                entity.Property(e => e.ShippingRecordId).HasColumnName("ShippingRecordID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.VerifiedByVisaSli)
                    .HasColumnName("VerifiedByVisaSLI")
                    .HasMaxLength(20);

                entity.HasOne(d => d.AuthorisationStatus)
                    .WithMany(p => p.TblBillingRecord)
                    .HasForeignKey(d => d.AuthorisationStatusId)
                    .HasConstraintName("tblAuthorisationStatus_tblBillingRecord_FK1");

                entity.HasOne(d => d.Billing)
                    .WithOne(p => p.TblBillingRecordBilling)
                    .HasForeignKey<TblBillingRecord>(d => d.BillingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblOriginBillingRecordMap_tblBillingRecord_FK3");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TblBillingRecord)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblOrder_tblBillingRecord_FK1");

                entity.HasOne(d => d.ReplacedBillingRecord)
                    .WithMany(p => p.TblBillingRecordReplacedBillingRecord)
                    .HasForeignKey(d => d.ReplacedBillingRecordId)
                    .HasConstraintName("tblOriginBillingRecordMap_tblBillingRecord_FK1");

                entity.HasOne(d => d.ReplacementBilling)
                    .WithMany(p => p.TblBillingRecordReplacementBilling)
                    .HasForeignKey(d => d.ReplacementBillingId)
                    .HasConstraintName("tblOriginBillingRecordMap_tblBillingRecord_FK2");

                entity.HasOne(d => d.ShippingRecord)
                    .WithMany(p => p.TblBillingRecord)
                    .HasForeignKey(d => d.ShippingRecordId)
                    .HasConstraintName("tblOriginShippingRecordMap_tblBillingRecord_FK1");
            });

            modelBuilder.Entity<TblBuildMessage>(entity =>
            {
                entity.HasKey(e => e.BuildMessageId);

                entity.ToTable("tbl_BuildMessage");

                entity.Property(e => e.BuildMessageId).HasColumnName("BuildMessageID");

                entity.Property(e => e.BuildMessage)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblBuildType>(entity =>
            {
                entity.HasKey(e => e.BuildTypeId);

                entity.ToTable("tbl_BuildType");

                entity.Property(e => e.BuildTypeId).HasColumnName("BuildTypeID");

                entity.Property(e => e.BuildTypeDescription)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblBusiness>(entity =>
            {
                entity.HasKey(e => e.BusinessId);

                entity.ToTable("tbl_Business");

                entity.Property(e => e.BusinessId).HasColumnName("BusinessID");

                entity.Property(e => e.BusinessAddressId).HasColumnName("BusinessAddressID");

                entity.Property(e => e.BusinessName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.BusinessNumber).HasMaxLength(255);

                entity.Property(e => e.BusinessUrl)
                    .HasColumnName("BusinessURL")
                    .HasMaxLength(255);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FaxNumber).HasMaxLength(255);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TaxIdnumber)
                    .HasColumnName("TaxIDNumber")
                    .HasMaxLength(255);

                entity.Property(e => e.TelephoneNumber).HasMaxLength(255);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblBusinessContact>(entity =>
            {
                entity.HasKey(e => e.BusinessContactId);

                entity.ToTable("tbl_BusinessContact");

                entity.Property(e => e.BusinessContactId).HasColumnName("BusinessContactID");

                entity.Property(e => e.BusinessContactRoleId).HasColumnName("BusinessContactRoleID");

                entity.Property(e => e.BusinessId).HasColumnName("BusinessID");

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.MobileNumber).HasMaxLength(255);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TelephoneNumber).HasMaxLength(255);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.BusinessContactRole)
                    .WithMany(p => p.TblBusinessContact)
                    .HasForeignKey(d => d.BusinessContactRoleId)
                    .HasConstraintName("FK_tbl_BusinessContact_tbl_BusinessContactRole");

                entity.HasOne(d => d.Business)
                    .WithMany(p => p.TblBusinessContact)
                    .HasForeignKey(d => d.BusinessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_BusinessContact_tbl_Business");
            });

            modelBuilder.Entity<TblBusinessContactRole>(entity =>
            {
                entity.HasKey(e => e.BusinessContactRoleId);

                entity.ToTable("tbl_BusinessContactRole");

                entity.Property(e => e.BusinessContactRoleId).HasColumnName("BusinessContactRoleID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblCardType>(entity =>
            {
                entity.HasKey(e => e.CardTypeId);

                entity.ToTable("tbl_CardType");

                entity.Property(e => e.CardTypeId)
                    .HasColumnName("CardTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CardTypeDetail).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExtRefCode).HasMaxLength(10);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OriginPayTypeCode).HasMaxLength(4);

                entity.Property(e => e.PrefixPattern).HasMaxLength(100);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblConcurrentPackage>(entity =>
            {
                entity.HasKey(e => e.ConcurrentPackageId);

                entity.ToTable("tbl_ConcurrentPackage");

                entity.Property(e => e.ConcurrentPackageId).HasColumnName("ConcurrentPackageID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SourceProductId).HasColumnName("SourceProductID");

                entity.Property(e => e.TargetProductId).HasColumnName("TargetProductID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.SourceProduct)
                    .WithMany(p => p.TblConcurrentPackageSourceProduct)
                    .HasForeignKey(d => d.SourceProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ConcurrentPackage_Reference_tbl_Package_source");

                entity.HasOne(d => d.TargetProduct)
                    .WithMany(p => p.TblConcurrentPackageTargetProduct)
                    .HasForeignKey(d => d.TargetProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ConcurrentPackage_Reference_tbl_Package_Target");
            });

            modelBuilder.Entity<TblConfigAttribute>(entity =>
            {
                entity.HasKey(e => e.AttributeId);

                entity.ToTable("tbl_ConfigAttribute");

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.AttributeCss)
                    .HasColumnName("AttributeCSS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AttributeDescription).HasMaxLength(200);

                entity.Property(e => e.AttributeErrorMsg)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ControlTypeId).HasColumnName("ControlTypeID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.TblConfigAttribute)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ConfigAttribute_ApplicationID");

                entity.HasOne(d => d.ControlType)
                    .WithMany(p => p.TblConfigAttribute)
                    .HasForeignKey(d => d.ControlTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ConfigAttribute_tbl_ConfigAttributeControl");

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblConfigAttribute)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ConfigAttribute_OrganisationID");
            });

            modelBuilder.Entity<TblConfigAttributeControl>(entity =>
            {
                entity.HasKey(e => e.ControlTypeId);

                entity.ToTable("tbl_ConfigAttributeControl");

                entity.Property(e => e.ControlTypeId)
                    .HasColumnName("ControlTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AttributeDataTypeId).HasColumnName("AttributeDataTypeID");

                entity.Property(e => e.ControlReadOnly).HasDefaultValueSql("((0))");

                entity.Property(e => e.ControlType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.AttributeDataType)
                    .WithMany(p => p.TblConfigAttributeControl)
                    .HasForeignKey(d => d.AttributeDataTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ConfigAttributeControl_tblAttributeDataType");
            });

            modelBuilder.Entity<TblConfigAttributeEntity>(entity =>
            {
                entity.HasKey(e => e.EntityId);

                entity.ToTable("tbl_ConfigAttributeEntity");

                entity.Property(e => e.EntityId).HasColumnName("EntityID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntityCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblConfigAttributeGroup>(entity =>
            {
                entity.HasKey(e => e.GroupAttributeId);

                entity.ToTable("tbl_ConfigAttributeGroup");

                entity.Property(e => e.GroupAttributeId).HasColumnName("GroupAttributeID");

                entity.Property(e => e.AttributeDefaultOverWrite)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.AttributeLinkId)
                    .HasColumnName("AttributeLinkID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Attribute)
                    .WithMany(p => p.TblConfigAttributeGroup)
                    .HasForeignKey(d => d.AttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ConfigAttributeGroup_tbl_ConfigAttribute");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.TblConfigAttributeGroup)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ConfigAttributeGroup_tbl_ConfigAttributeUserControl");
            });

            modelBuilder.Entity<TblConfigAttributeList>(entity =>
            {
                entity.HasKey(e => e.ConfigAttributeListId);

                entity.ToTable("tbl_ConfigAttributeList");

                entity.Property(e => e.ConfigAttributeListId).HasColumnName("ConfigAttributeListID");

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.AttributeListName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Attribute)
                    .WithMany(p => p.TblConfigAttributeList)
                    .HasForeignKey(d => d.AttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ConfigAttributeList_tbl_ConfigAttribute");
            });

            modelBuilder.Entity<TblConfigAttributeOperation>(entity =>
            {
                entity.HasKey(e => e.AttributeOperationId);

                entity.ToTable("tbl_ConfigAttributeOperation");

                entity.Property(e => e.AttributeOperationId).HasColumnName("AttributeOperationID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GroupAttributeId).HasColumnName("GroupAttributeID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifyOperationId).HasColumnName("ModifyOperationID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.VisibleOperationId).HasColumnName("VisibleOperationID");

                entity.HasOne(d => d.GroupAttribute)
                    .WithMany(p => p.TblConfigAttributeOperation)
                    .HasForeignKey(d => d.GroupAttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ConfigAttributeOperation_tbl_ConfigAttributeGroup");

                entity.HasOne(d => d.ModifyOperation)
                    .WithMany(p => p.TblConfigAttributeOperation)
                    .HasForeignKey(d => d.ModifyOperationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ConfigAttributeOperation_OperationID");
            });

            modelBuilder.Entity<TblConfigAttributeStore>(entity =>
            {
                entity.HasKey(e => new { e.ApplicationId, e.EntityId, e.AttributeGroupName });

                entity.ToTable("tbl_ConfigAttributeStore");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.EntityId).HasColumnName("EntityID");

                entity.Property(e => e.AttributeGroupName).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.DisplayGroupName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.TblConfigAttributeStore)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ConfigAttributeStore_tblSysApplication");

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.TblConfigAttributeStore)
                    .HasForeignKey(d => d.EntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ConfigAttributeStore_tbl_ConfigAttributeEntity");
            });

            modelBuilder.Entity<TblConfigAttributeUrl>(entity =>
            {
                entity.HasKey(e => e.ConfigAttributeUrlid);

                entity.ToTable("tbl_ConfigAttributeURL");

                entity.Property(e => e.ConfigAttributeUrlid).HasColumnName("ConfigAttributeURLID");

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.AttributeUrl)
                    .IsRequired()
                    .HasColumnName("AttributeURL")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Attribute)
                    .WithMany(p => p.TblConfigAttributeUrl)
                    .HasForeignKey(d => d.AttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ConfigAttributeURL_tbl_ConfigAttribute");
            });

            modelBuilder.Entity<TblConfigAttributeUserControl>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.ToTable("tbl_ConfigAttributeUserControl");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.AttributeGroupName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntityId).HasColumnName("EntityID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.TblConfigAttributeUserControl)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ConfigAttributeUserControl_ApplicationID");

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.TblConfigAttributeUserControl)
                    .HasForeignKey(d => d.EntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ConfigAttributeUserControl_tbl_ConfigAttributeEntity");

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblConfigAttributeUserControl)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ConfigAttributeUserControl_OrganisationID");
            });

            modelBuilder.Entity<TblConfigAttributeValue>(entity =>
            {
                entity.HasKey(e => e.ConfigAttributeValueId);

                entity.ToTable("tbl_ConfigAttributeValue");

                entity.HasIndex(e => e.EntityKey)
                    .HasName("NCINDEX_tbl_ConfigAttributeValue_EntityKey");

                entity.HasIndex(e => new { e.AttributeId, e.EntityId, e.EntityKey })
                    .HasName("NCINDEX_tbl_ConfigAttributeValue_AttributeID_EntityID_EntityKey");

                entity.Property(e => e.ConfigAttributeValueId).HasColumnName("ConfigAttributeValueID");

                entity.Property(e => e.AttributeDataTypeId).HasColumnName("AttributeDataTypeID");

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateTimeValue).HasColumnType("datetime");

                entity.Property(e => e.EntityId).HasColumnName("EntityID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NumericValue).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.TextValue)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.AttributeDataType)
                    .WithMany(p => p.TblConfigAttributeValue)
                    .HasForeignKey(d => d.AttributeDataTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ConfigAttributeValue_tblAttributeDataType");

                entity.HasOne(d => d.Attribute)
                    .WithMany(p => p.TblConfigAttributeValue)
                    .HasForeignKey(d => d.AttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ConfigAttributeValue_tbl_ConfigAttribute");

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.TblConfigAttributeValue)
                    .HasForeignKey(d => d.EntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ConfigAttributeValue_tbl_ConfigAttributeEntity");
            });

            modelBuilder.Entity<TblContact>(entity =>
            {
                entity.HasKey(e => e.ContactId);

                entity.ToTable("tbl_Contact");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FaxAreaCode).HasMaxLength(6);

                entity.Property(e => e.FaxCountryCode).HasMaxLength(6);

                entity.Property(e => e.FaxNumber).HasMaxLength(20);

                entity.Property(e => e.Mobile).HasMaxLength(20);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PhoneAreaCode)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.PhoneCountryCode)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblCountry>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.ToTable("tbl_Country");

                entity.Property(e => e.CountryId)
                    .HasColumnName("CountryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DialingCode).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblCreditCardDetails>(entity =>
            {
                entity.HasKey(e => e.CreditCardId);

                entity.ToTable("tbl_CreditCardDetails");

                entity.Property(e => e.CreditCardId).HasColumnName("CreditCardID");

                entity.Property(e => e.CardName).HasMaxLength(100);

                entity.Property(e => e.CardNumber).HasMaxLength(512);

                entity.Property(e => e.CardTypeId).HasColumnName("CardTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDate).HasMaxLength(10);

                entity.Property(e => e.FromDate).HasMaxLength(10);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.CardType)
                    .WithMany(p => p.TblCreditCardDetails)
                    .HasForeignKey(d => d.CardTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CreditCardDetails_Reference_CreditCardType");
            });

            modelBuilder.Entity<TblCustomer>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblCustomer");

                entity.HasIndex(e => e.BusinessName)
                    .HasName("nclidx_tblCustomer_BusinessName");

                entity.HasIndex(e => e.CreatedDate)
                    .HasName("UNCLIDX_temp_tblCustomer_CreatedDate");

                entity.HasIndex(e => e.DateOfBirth)
                    .HasName("idx_DateOfBirth");

                entity.HasIndex(e => e.EmailAddress)
                    .HasName("idx_Email");

                entity.HasIndex(e => e.ModifiedDate)
                    .HasName("UNCLIDX_temp_tblCustomer_ModifiedDate");

                entity.HasIndex(e => new { e.CustomerId, e.CustomerListId })
                    .HasName("NCINDEX_tblCustomer_CustomerListID_INCLUDE_CustomerID");

                entity.HasIndex(e => new { e.PowerWebUsername, e.IsPowerWebUser })
                    .HasName("idx_PowerWebUsername_IsPowerWebUser");

                entity.HasIndex(e => new { e.LastName, e.FirstName, e.CustomerId })
                    .HasName("idx_tblCustomer_LastName_FirstName_CustomerID")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.BusinessName).HasMaxLength(200);

                entity.Property(e => e.Comments).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerListId).HasColumnName("CustomerListID");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.DisabledDate).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress).HasMaxLength(200);

                entity.Property(e => e.FirstName).HasMaxLength(200);

                entity.Property(e => e.Gender).HasColumnType("nchar(1)");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.LockedDate).HasColumnType("datetime");

                entity.Property(e => e.LoginDisabledDate).HasColumnType("datetime");

                entity.Property(e => e.MiddleName).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Password).HasMaxLength(256);

                entity.Property(e => e.PowerWebUsername).HasMaxLength(200);

                entity.Property(e => e.ProfileModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Salutation).HasMaxLength(10);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.CustomerList)
                    .WithMany(p => p.TblCustomer)
                    .HasForeignKey(d => d.CustomerListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCustomer_tblCustomerList");
            });

            modelBuilder.Entity<TblCustomerAccountBalance>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("tblCustomerAccountBalance");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Customer)
                    .WithOne(p => p.TblCustomerAccountBalance)
                    .HasForeignKey<TblCustomerAccountBalance>(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCustomerAccountBalance_tblCustomer");
            });

            modelBuilder.Entity<TblCustomerAccountBalance1>(entity =>
            {
                entity.HasKey(e => e.CustomerAccountBalanceId);

                entity.ToTable("tbl_CustomerAccountBalance");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblCustomerAccountBalanceAudit>(entity =>
            {
                entity.ToTable("tbl_CustomerAccountBalanceAudit");

                entity.Property(e => e.TransactionDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblCustomerAccountBalanceJournal>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("tblCustomerAccountBalanceJournal");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.NewBalance).HasColumnType("money");

                entity.Property(e => e.OldBalance).HasColumnType("money");

                entity.Property(e => e.SellerCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.VoucherId).HasColumnName("VoucherID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblCustomerAccountBalanceJournal)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCustomerAccountBalanceJournal_tblCustomer");

                entity.HasOne(d => d.Voucher)
                    .WithMany(p => p.TblCustomerAccountBalanceJournal)
                    .HasForeignKey(d => d.VoucherId)
                    .HasConstraintName("FK_tblCustomerAccountBalanceJournal_tblVoucher");
            });

            modelBuilder.Entity<TblCustomerActivityRecord>(entity =>
            {
                entity.HasKey(e => e.ActivityRecordId);

                entity.ToTable("tblCustomerActivityRecord");

                entity.HasIndex(e => new { e.CustomerId, e.ActivityTypeId })
                    .HasName("IC_tblCustomerActivityRecord_CustomerID_ActivityTypeID");

                entity.HasIndex(e => new { e.CustomerId, e.ActivityRecordId, e.ActivityTypeId, e.CreatedDate })
                    .HasName("NCINDEX_tblCustomerActivityRecord_CreatedDate_inc_CustomerID_ActivityRecordID_ActivityTypeID");

                entity.Property(e => e.ActivityRecordId).HasColumnName("ActivityRecordID");

                entity.Property(e => e.ActivityTypeId).HasColumnName("ActivityTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.ActivityType)
                    .WithMany(p => p.TblCustomerActivityRecord)
                    .HasForeignKey(d => d.ActivityTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblActivityType_tblCustomerActivityRecord_FK1");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblCustomerActivityRecord)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblCustomer_tblCustomerActivityRecord_FK1");
            });

            modelBuilder.Entity<TblCustomerAddress>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblCustomerAddress");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("idx_CustomerID")
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => new { e.AddressId, e.IsPrimary })
                    .HasName("IX_AddressID_IsPrimary");

                entity.HasIndex(e => new { e.CustomerId, e.AddressId })
                    .HasName("uc_CustomerID_AddressID")
                    .IsUnique();

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.TblCustomerAddress)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblAddress_tblCustomerAddress_FK1");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblCustomerAddress)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblCustomer_tblCustomerAddress_FK1");
            });

            modelBuilder.Entity<TblCustomerCredentials>(entity =>
            {
                entity.HasKey(e => e.CustomerCredentialsId);

                entity.ToTable("tbl_CustomerCredentials");

                entity.HasIndex(e => new { e.CustomerId, e.ProviderName })
                    .HasName("UQ_tbl_CustomerCredentials_CustomerId_ProviderName")
                    .IsUnique();

                entity.HasIndex(e => new { e.ProviderName, e.ProviderCustomerIdentifier })
                    .HasName("NC_tbl_CustomerCredentials_ProviderType_ProviderId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProviderCustomerIdentifier)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ProviderName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .IsRowVersion();

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblCustomerCredentials)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_CustomerCredentials_CustomerId");
            });

            modelBuilder.Entity<TblCustomerCreditCard>(entity =>
            {
                entity.HasKey(e => e.CustomerCreditCardId);

                entity.ToTable("tbl_CustomerCreditCard");

                entity.HasIndex(e => new { e.CustomerId, e.CreditCardId })
                    .HasName("UK_tbl_CustomerCreditCard")
                    .IsUnique();

                entity.Property(e => e.CustomerCreditCardId).HasColumnName("CustomerCreditCardID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreditCardId).HasColumnName("CreditCardID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.CreditCard)
                    .WithMany(p => p.TblCustomerCreditCard)
                    .HasForeignKey(d => d.CreditCardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerCreditCard_Reference_CreditCardDetails");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblCustomerCreditCard)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerCreditCard_Reference_Customer");
            });

            modelBuilder.Entity<TblCustomerCustomerType>(entity =>
            {
                entity.HasKey(e => e.CustomerCustomerTypeId);

                entity.ToTable("tblCustomerCustomerType");

                entity.HasIndex(e => new { e.CustomerId, e.CustomerTypeId })
                    .HasName("UC_tblCustomer_CustomerType")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.CustomerCustomerTypeId).HasColumnName("CustomerCustomerTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerTypeId).HasColumnName("CustomerTypeID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblCustomerCustomerType)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblCustomer_tblCustomerTypeJoin_FK1");

                entity.HasOne(d => d.CustomerType)
                    .WithMany(p => p.TblCustomerCustomerType)
                    .HasForeignKey(d => d.CustomerTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Customer Types_Customer Type Table_FK1");
            });

            modelBuilder.Entity<TblCustomerHold>(entity =>
            {
                entity.HasKey(e => e.CustomerHoldId);

                entity.ToTable("tbl_CustomerHold");

                entity.Property(e => e.CustomerHoldId).HasColumnName("CustomerHoldID");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.HoldExpiry).HasColumnType("datetime");

                entity.Property(e => e.HoldPtype)
                    .IsRequired()
                    .HasColumnName("HoldPType")
                    .HasColumnType("nchar(10)");

                entity.Property(e => e.HoldTransDate).HasColumnType("datetime");

                entity.Property(e => e.ModfiedDate).HasColumnType("datetime");

                entity.Property(e => e.PerfCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PurchaseTransDate).HasColumnType("datetime");

                entity.Property(e => e.PurchasedRzstring)
                    .IsRequired()
                    .HasColumnName("PurchasedRZString")
                    .HasMaxLength(50);

                entity.Property(e => e.ShowCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.VenueCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblCustomerHold)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_CustomerHold_CustomerID");
            });

            modelBuilder.Entity<TblCustomerHoldSeat>(entity =>
            {
                entity.HasKey(e => e.CustomerHoldSeatId);

                entity.ToTable("tbl_CustomerHoldSeat");

                entity.Property(e => e.CustomerHoldSeatId).HasColumnName("CustomerHoldSeatID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerHoldId).HasColumnName("CustomerHoldID");

                entity.Property(e => e.CustomerHoldSeatStatusId).HasColumnName("CustomerHoldSeatStatusID");

                entity.Property(e => e.ModfiedDate).HasColumnType("datetime");

                entity.Property(e => e.Row)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SeatNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Section)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.CustomerHold)
                    .WithMany(p => p.TblCustomerHoldSeat)
                    .HasForeignKey(d => d.CustomerHoldId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_CustomerHoldSeat_CustomerHoldID");

                entity.HasOne(d => d.CustomerHoldSeatStatus)
                    .WithMany(p => p.TblCustomerHoldSeat)
                    .HasForeignKey(d => d.CustomerHoldSeatStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_CustomerHoldSeat_tbl_CustomerHoldSeatStatus");
            });

            modelBuilder.Entity<TblCustomerHoldSeatStatus>(entity =>
            {
                entity.HasKey(e => e.CustomerHoldSeatStatusId);

                entity.ToTable("tbl_CustomerHoldSeatStatus");

                entity.Property(e => e.CustomerHoldSeatStatusId)
                    .HasColumnName("CustomerHoldSeatStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerHoldSeatStatusName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblCustomerLinkedCustomer>(entity =>
            {
                entity.HasKey(e => e.CustomerLinkedCustomerId);

                entity.ToTable("tblCustomerLinkedCustomer");

                entity.HasIndex(e => new { e.CustomerId, e.LinkedCustomerId })
                    .HasName("NCINDEX_tblCustomerLinkedCustomer_LinkedCustomerID_INC_CustomerID");

                entity.HasIndex(e => new { e.LinkedCustomerId, e.CustomerId })
                    .HasName("NCINDEX_tblCustomerLinkedCustomer_CustomerID_INC_LinkedCustomerID");

                entity.Property(e => e.CustomerLinkedCustomerId).HasColumnName("CustomerLinkedCustomerID");

                entity.Property(e => e.ActivatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerLinkedCustomerTypeId).HasColumnName("CustomerLinkedCustomerTypeID");

                entity.Property(e => e.Enabled).HasDefaultValueSql("((1))");

                entity.Property(e => e.LinkedCustomerId).HasColumnName("LinkedCustomerID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblCustomerLinkedCustomerCustomer)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCustomerLinkedCustomer_tblCustomer1");

                entity.HasOne(d => d.LinkedCustomer)
                    .WithMany(p => p.TblCustomerLinkedCustomerLinkedCustomer)
                    .HasForeignKey(d => d.LinkedCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCustomerLinkedCustomer_tblCustomer21");

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblCustomerLinkedCustomer)
                    .HasForeignKey(d => d.OrganisationId)
                    .HasConstraintName("FK_tblCustomerLinkedCustomer_tblOrganisation");
            });

            modelBuilder.Entity<TblCustomerLinkedCustomerAparna>(entity =>
            {
                entity.HasKey(e => e.CustomerLinkedCustomerId);

                entity.ToTable("tblCustomerLinkedCustomer_aparna");

                entity.Property(e => e.CustomerLinkedCustomerId).HasColumnName("CustomerLinkedCustomerID");

                entity.Property(e => e.ActivatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.LinkedCustomerId).HasColumnName("LinkedCustomerID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblCustomerLinkedCustomerType>(entity =>
            {
                entity.HasKey(e => e.CustomerLinkedCustomerTypeId);

                entity.ToTable("tblCustomerLinkedCustomerType");

                entity.Property(e => e.CustomerLinkedCustomerTypeId).HasColumnName("CustomerLinkedCustomerTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerLinkedCustomerTypeName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblCustomerLinkedGroup>(entity =>
            {
                entity.HasKey(e => e.CustomerLinkedGroupId);

                entity.ToTable("tblCustomerLinkedGroup");

                entity.Property(e => e.CustomerLinkedGroupId).HasColumnName("CustomerLinkedGroupID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerLinkedGroupName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblCustomerLinkedGroup)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCustomerLinkedGroup_tblCustomer");
            });

            modelBuilder.Entity<TblCustomerLinkedGroupLinkedCustomer>(entity =>
            {
                entity.HasKey(e => new { e.CustomerLinkedGroupId, e.CustomerLinkedCustomerId });

                entity.ToTable("tblCustomerLinkedGroupLinkedCustomer");

                entity.Property(e => e.CustomerLinkedGroupId).HasColumnName("CustomerLinkedGroupID");

                entity.Property(e => e.CustomerLinkedCustomerId).HasColumnName("CustomerLinkedCustomerID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CustomerLinkedCustomer)
                    .WithMany(p => p.TblCustomerLinkedGroupLinkedCustomer)
                    .HasForeignKey(d => d.CustomerLinkedCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCustomerLinkedGroupLinkedCustomer_tblCustomerLinkedCustomer");

                entity.HasOne(d => d.CustomerLinkedGroup)
                    .WithMany(p => p.TblCustomerLinkedGroupLinkedCustomer)
                    .HasForeignKey(d => d.CustomerLinkedGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCustomerLinkedGroupLinkedCustomer_tblCustomerLinkedGroup");
            });

            modelBuilder.Entity<TblCustomerList>(entity =>
            {
                entity.HasKey(e => e.CustomerListId);

                entity.ToTable("tblCustomerList");

                entity.HasIndex(e => e.ListName)
                    .HasName("uc_tblCustomerList_ListName")
                    .IsUnique();

                entity.Property(e => e.CustomerListId).HasColumnName("CustomerListID");

                entity.Property(e => e.BusinessId).HasColumnName("BusinessID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.IsVisible).HasDefaultValueSql("((1))");

                entity.Property(e => e.ListName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblCustomerPasswordReset>(entity =>
            {
                entity.HasKey(e => e.CustomerPasswordResetId);

                entity.ToTable("tblCustomerPasswordReset");

                entity.Property(e => e.CustomerPasswordResetId).HasColumnName("CustomerPasswordResetID");

                entity.Property(e => e.ActionType).HasMaxLength(50);

                entity.Property(e => e.ConsumedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ExpiresDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ResetToken)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCustomerPhone>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblCustomerPhone");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("idx_CustomerID")
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => e.PhoneId)
                    .HasName("idx_PhoneID");

                entity.HasIndex(e => new { e.CustomerId, e.PhoneId })
                    .HasName("uc_CustomerID_PhoneID")
                    .IsUnique();

                entity.HasIndex(e => new { e.IsPrimary, e.CustomerId })
                    .HasName("IX_tblCustomerPhone_IsPrimary");

                entity.HasIndex(e => new { e.RecordId, e.PhoneId })
                    .HasName("IX_RecordID_PhoneID");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PhoneId).HasColumnName("PhoneID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblCustomerPhone)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblCustomer_tblCustomerPhoneValue_FK1");

                entity.HasOne(d => d.Phone)
                    .WithMany(p => p.TblCustomerPhone)
                    .HasForeignKey(d => d.PhoneId)
                    .HasConstraintName("tblPhone_tblCustomerPhone_FK1");
            });

            modelBuilder.Entity<TblCustomerPreference>(entity =>
            {
                entity.HasKey(e => e.PreferenceId);

                entity.ToTable("tblCustomerPreference");

                entity.HasIndex(e => e.ParentId);

                entity.HasIndex(e => e.PreferenceId)
                    .HasName("CustomerPreference_PK")
                    .IsUnique();

                entity.HasIndex(e => new { e.ParentId, e.PreferenceName })
                    .HasName("IX_tblCustomerPreference_ParentID_PreferenceName")
                    .IsUnique();

                entity.Property(e => e.PreferenceId).HasColumnName("PreferenceID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PreferenceName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblCustomerPreferenceValue>(entity =>
            {
                entity.HasKey(e => e.PreferenceValueId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblCustomerPreferenceValue");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("idx_CustomerID");

                entity.HasIndex(e => e.PreferenceId)
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => new { e.CustomerId, e.PreferenceId })
                    .HasName("uc_CustomerID_PreferenceID")
                    .IsUnique();

                entity.Property(e => e.PreferenceValueId).HasColumnName("PreferenceValueID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PreferenceId).HasColumnName("PreferenceID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblCustomerPreferenceValue)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Customers_Customer Preferences_FK1");

                entity.HasOne(d => d.Preference)
                    .WithMany(p => p.TblCustomerPreferenceValue)
                    .HasForeignKey(d => d.PreferenceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblCustomerPreference_tblCustomerPreferenceValue_FK1");
            });

            modelBuilder.Entity<TblCustomerSubscription>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblCustomerSubscription");

                entity.HasIndex(e => e.SubscriptionChoiceId);

                entity.HasIndex(e => e.SubscriptionId)
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => new { e.CustomerId, e.SubscriptionId })
                    .HasName("uc_CustomerID_SubscriptionID")
                    .IsUnique();

                entity.HasIndex(e => new { e.SubscriptionId, e.IsSubscribed, e.SubscriptionChoiceId, e.CreatedBy, e.CreatedDate, e.ModifiedBy, e.ModifiedDate, e.Tstamp, e.CustomerId, e.RecordId })
                    .HasName("idx_tblCustomerSubscription_CustomerID_RecordID");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SubscriptionChoiceId).HasColumnName("SubscriptionChoiceID");

                entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblCustomerSubscription)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblCustomer_tblCustomerSubscriptionJoin_FK1");

                entity.HasOne(d => d.SubscriptionChoice)
                    .WithMany(p => p.TblCustomerSubscription)
                    .HasForeignKey(d => d.SubscriptionChoiceId)
                    .HasConstraintName("tblRefSubscriptionChoice_tblCustomerSubscription_FK1");

                entity.HasOne(d => d.Subscription)
                    .WithMany(p => p.TblCustomerSubscription)
                    .HasForeignKey(d => d.SubscriptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Subscription Services_Customer Subscriptions_FK1");
            });

            modelBuilder.Entity<TblCustomerTransactionPermission>(entity =>
            {
                entity.HasKey(e => new { e.PlaceCode, e.PromCode });

                entity.ToTable("tblCustomerTransactionPermission");

                entity.Property(e => e.PlaceCode).HasColumnType("nchar(5)");

                entity.Property(e => e.PromCode).HasColumnType("nchar(3)");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblCustomerType>(entity =>
            {
                entity.HasKey(e => e.CustomerTypeId);

                entity.ToTable("tblCustomerType");

                entity.HasIndex(e => e.CustomerTypeName)
                    .HasName("uc_tblCustomerType_CustomerTypeName")
                    .IsUnique();

                entity.Property(e => e.CustomerTypeId).HasColumnName("CustomerTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerTypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblCustomerTypeAttribute>(entity =>
            {
                entity.HasKey(e => e.AttributeId);

                entity.ToTable("tblCustomerTypeAttribute");

                entity.HasIndex(e => new { e.CustomerTypeId, e.AttributeId })
                    .HasName("IX_CustomerTypeID_AttributeID")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.AttributeDataTypeId).HasColumnName("AttributeDataTypeID");

                entity.Property(e => e.AttributeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CommonAttributeId).HasColumnName("CommonAttributeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerTypeId).HasColumnName("CustomerTypeID");

                entity.Property(e => e.DisplayLabel)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.ValidationError).HasMaxLength(50);

                entity.Property(e => e.ValidationText).HasMaxLength(500);

                entity.HasOne(d => d.AttributeDataType)
                    .WithMany(p => p.TblCustomerTypeAttribute)
                    .HasForeignKey(d => d.AttributeDataTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblRefAttributeDataType_tblCustomerTypeAttribute_FK1");

                entity.HasOne(d => d.CommonAttribute)
                    .WithMany(p => p.TblCustomerTypeAttribute)
                    .HasForeignKey(d => d.CommonAttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblCustomerAttribute_tblCustomerTypeAttribute_FK1");

                entity.HasOne(d => d.CustomerType)
                    .WithMany(p => p.TblCustomerTypeAttribute)
                    .HasForeignKey(d => d.CustomerTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblCustomerType_tblCustomerTypeAttribute_FK1");
            });

            modelBuilder.Entity<TblCustomerTypeAttributeValue>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("tblCustomerTypeAttributeValue");

                entity.HasIndex(e => e.AttributeId);

                entity.HasIndex(e => new { e.CustomerCustomerTypeId, e.AttributeId })
                    .HasName("uc_CustomerTypeJoinID_AttributeID")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.AttributeDataTypeId).HasColumnName("AttributeDataTypeID");

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.ChoiceId).HasColumnName("ChoiceID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerCustomerTypeId).HasColumnName("CustomerCustomerTypeID");

                entity.Property(e => e.DateTimeValue).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TextValue).HasMaxLength(200);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.TblCustomerTypeAttributeValue)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("tblAddress_tblCustomerTypeAttributeValue_FK1");

                entity.HasOne(d => d.AttributeDataType)
                    .WithMany(p => p.TblCustomerTypeAttributeValue)
                    .HasForeignKey(d => d.AttributeDataTypeId)
                    .HasConstraintName("tblRefAttributeDataType_tblCustomerTypeAttributeValue_FK1");

                entity.HasOne(d => d.Attribute)
                    .WithMany(p => p.TblCustomerTypeAttributeValue)
                    .HasForeignKey(d => d.AttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblCustomerTypeAttribute_tblCustomerTypeAttributeValue_FK1");

                entity.HasOne(d => d.Choice)
                    .WithMany(p => p.TblCustomerTypeAttributeValue)
                    .HasForeignKey(d => d.ChoiceId)
                    .HasConstraintName("tblCustomerTypeChoiceAttribute_tblCustomerTypeAttributeValue_FK1");

                entity.HasOne(d => d.CustomerCustomerType)
                    .WithMany(p => p.TblCustomerTypeAttributeValue)
                    .HasForeignKey(d => d.CustomerCustomerTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblCustomerTypeJoin_tblCustomerTypeAttributeValue_FK1");
            });

            modelBuilder.Entity<TblCustomerTypeChoiceAttribute>(entity =>
            {
                entity.HasKey(e => e.ChoiceId);

                entity.ToTable("tblCustomerTypeChoiceAttribute");

                entity.HasIndex(e => new { e.CommonAttributeId, e.ChoiceName })
                    .HasName("uc_CustomerTypeChoice_ChoiceName")
                    .IsUnique();

                entity.Property(e => e.ChoiceId).HasColumnName("ChoiceID");

                entity.Property(e => e.ChoiceName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CommonAttributeId).HasColumnName("CommonAttributeID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DisplayLabel).HasMaxLength(100);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.CommonAttribute)
                    .WithMany(p => p.TblCustomerTypeChoiceAttribute)
                    .HasForeignKey(d => d.CommonAttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblCustomerTypeCommonAttribute_tblCutomerTypeChoiceAttribute_FK1");
            });

            modelBuilder.Entity<TblCustomerTypeCommonAttribute>(entity =>
            {
                entity.HasKey(e => e.CommonAttributeId);

                entity.ToTable("tblCustomerTypeCommonAttribute");

                entity.HasIndex(e => e.AttributeName)
                    .HasName("uc_tblCustomerTypeCommonAttribute_AttributeName")
                    .IsUnique();

                entity.Property(e => e.CommonAttributeId).HasColumnName("CommonAttributeID");

                entity.Property(e => e.AddressTypeId).HasColumnName("AddressTypeID");

                entity.Property(e => e.AttributeDataTypeId).HasColumnName("AttributeDataTypeID");

                entity.Property(e => e.AttributeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DisplayLabel)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.AddressType)
                    .WithMany(p => p.TblCustomerTypeCommonAttribute)
                    .HasForeignKey(d => d.AddressTypeId)
                    .HasConstraintName("tblAddressType_tblCustomerTypeCommonAttribute_FK1");

                entity.HasOne(d => d.AttributeDataType)
                    .WithMany(p => p.TblCustomerTypeCommonAttribute)
                    .HasForeignKey(d => d.AttributeDataTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblAttributeDataType_tblCustomerTypeCommonAttribute_FK1");
            });

            modelBuilder.Entity<TblCustomerWaitlist>(entity =>
            {
                entity.HasKey(e => e.CustomerWaitlistId);

                entity.ToTable("tbl_CustomerWaitlist");

                entity.HasIndex(e => new { e.CustomerId, e.WaitlistId })
                    .HasName("UC_tbl_CustomerWaitlist_CustomerWaitlist")
                    .IsUnique();

                entity.Property(e => e.CustomerWaitlistId).HasColumnName("CustomerWaitlistID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.WaitlistId).HasColumnName("WaitlistID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblCustomerWaitlist)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_CustomerWaitlist_tblCustomer");

                entity.HasOne(d => d.Waitlist)
                    .WithMany(p => p.TblCustomerWaitlist)
                    .HasForeignKey(d => d.WaitlistId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_CustomerWaitlist_tbl_Waitlist");
            });

            modelBuilder.Entity<TblDataExchangeAflupgradePurchase>(entity =>
            {
                entity.HasKey(e => e.BarcodeId);

                entity.ToTable("tbl_DataExchangeAFLUpgradePurchase");

                entity.HasIndex(e => e.FileId)
                    .HasName("IC_tbl_DataExchangeAFLUpgradePurchase_FileID");

                entity.HasIndex(e => e.LogId)
                    .HasName("IC_tbl_DataExchangeAFLUpgradePurchase_LogID");

                entity.Property(e => e.BarcodeId).HasColumnName("BarcodeID");

                entity.Property(e => e.Barcode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DatabaseSource)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DefaultEntitlementId).HasColumnName("DefaultEntitlementID");

                entity.Property(e => e.EntitlementGroupId).HasColumnName("EntitlementGroupID");

                entity.Property(e => e.EntitlementPasswordId).HasColumnName("EntitlementPasswordID");

                entity.Property(e => e.EntitlementUsageId).HasColumnName("EntitlementUsageID");

                entity.Property(e => e.EventGroupCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.ForeignEventCode).HasMaxLength(50);

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PaxMasterEventCode).HasMaxLength(50);

                entity.Property(e => e.ProtectionGroupEntitlementId).HasColumnName("ProtectionGroupEntitlementID");

                entity.Property(e => e.ProtectionGroupId).HasColumnName("ProtectionGroupID");

                entity.Property(e => e.TicketType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblDataExchangeAxcessOneBarcode>(entity =>
            {
                entity.HasKey(e => e.BarcodeId);

                entity.ToTable("tbl_DataExchangeAxcessOneBarcode");

                entity.HasIndex(e => e.FileId)
                    .HasName("IC_tbl_DataExchangeAxcessOneBarcode_FileID");

                entity.HasIndex(e => e.LogId)
                    .HasName("IC_tbl_DataExchangeAxcessOneBarcode_LogID");

                entity.Property(e => e.BarcodeId).HasColumnName("BarcodeID");

                entity.Property(e => e.Barcode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DisabledReasonId).HasColumnName("DisabledReasonID");

                entity.Property(e => e.EntitlementGroupId).HasColumnName("EntitlementGroupID");

                entity.Property(e => e.EntitlementPasswordId).HasColumnName("EntitlementPasswordID");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblDataExchangeFile>(entity =>
            {
                entity.HasKey(e => e.FileId);

                entity.ToTable("tbl_DataExchangeFile");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.MaximumRecordDate).HasColumnType("datetime");

                entity.Property(e => e.Md5checkSum)
                    .HasColumnName("MD5CheckSum")
                    .HasMaxLength(32);

                entity.Property(e => e.MessageTypeId).HasColumnName("MessageTypeID");

                entity.Property(e => e.MinimumRecordDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.MessageType)
                    .WithMany(p => p.TblDataExchangeFile)
                    .HasForeignKey(d => d.MessageTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_DataExchangeFile_Reference_tbl_DataExchangeMessageType");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TblDataExchangeFile)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_DataExchangeFile_Reference_tbl_DataExchangeStatus");
            });

            modelBuilder.Entity<TblDataExchangeMccbarcode>(entity =>
            {
                entity.HasKey(e => e.BarcodeId);

                entity.ToTable("tbl_DataExchangeMCCBarcode");

                entity.HasIndex(e => e.FileId)
                    .HasName("IC_tbl_DataExchangeMCCBarcode_FileID");

                entity.HasIndex(e => e.LogId)
                    .HasName("IC_tbl_DataExchangeMCCBarcode_LogID");

                entity.Property(e => e.BarcodeId).HasColumnName("BarcodeID");

                entity.Property(e => e.Barcode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DisabledReasonId).HasColumnName("DisabledReasonID");

                entity.Property(e => e.EntitlementGroupId).HasColumnName("EntitlementGroupID");

                entity.Property(e => e.EntitlementPasswordId).HasColumnName("EntitlementPasswordID");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.MembershipType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PriceType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblDataExchangeMessageType>(entity =>
            {
                entity.HasKey(e => e.MessageTypeId);

                entity.ToTable("tbl_DataExchangeMessageType");

                entity.HasIndex(e => e.ConfigMapping)
                    .HasName("PXML_DataExchangeMessageType_ConfigMapping");

                entity.Property(e => e.MessageTypeId).HasColumnName("MessageTypeID");

                entity.Property(e => e.ConfigMapping).HasColumnType("xml");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasColumnType("xml");

                entity.Property(e => e.FileMask).HasMaxLength(260);

                entity.Property(e => e.HostDirectory)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.LocalDirectory).HasMaxLength(260);

                entity.Property(e => e.MessageTypeName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TransportId).HasColumnName("TransportID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Transport)
                    .WithMany(p => p.TblDataExchangeMessageType)
                    .HasForeignKey(d => d.TransportId)
                    .HasConstraintName("FK_tbl_DataExchangeMessageType_Reference_tbl_DataExchangeTransport");
            });

            modelBuilder.Entity<TblDataExchangeNewArchticsBarcode>(entity =>
            {
                entity.HasKey(e => e.BarcodeId);

                entity.ToTable("tbl_DataExchangeNewArchticsBarcode");

                entity.HasIndex(e => e.FileId)
                    .HasName("IC_tbl_DataExchangeNewArchticsBarcode_FileID");

                entity.HasIndex(e => e.LogId)
                    .HasName("IC_tbl_DataExchangeNewArchticsBarcode_LogID");

                entity.Property(e => e.BarcodeId).HasColumnName("BarcodeID");

                entity.Property(e => e.Barcode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BarcodeStatus)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DatabaseSource)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DefaultEntitlementId).HasColumnName("DefaultEntitlementID");

                entity.Property(e => e.DisabledReasonId).HasColumnName("DisabledReasonID");

                entity.Property(e => e.EntitlementGroupId).HasColumnName("EntitlementGroupID");

                entity.Property(e => e.EntitlementPasswordId).HasColumnName("EntitlementPasswordID");

                entity.Property(e => e.EntitlementUsageId).HasColumnName("EntitlementUsageID");

                entity.Property(e => e.EventGroupCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TicketType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblDataExchangeSmslistSynchronisation>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("tbl_DataExchangeSMSListSynchronisation");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerPhoneId).HasColumnName("CustomerPhoneID");

                entity.Property(e => e.CustomerSubscriptionId).HasColumnName("CustomerSubscriptionID");

                entity.Property(e => e.ExternalModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SubscriptionChoiceId).HasColumnName("SubscriptionChoiceID");

                entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");
            });

            modelBuilder.Entity<TblDataExchangeStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("tbl_DataExchangeStatus");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblDataExchangeTransport>(entity =>
            {
                entity.HasKey(e => e.TransportId);

                entity.ToTable("tbl_DataExchangeTransport");

                entity.Property(e => e.TransportId).HasColumnName("TransportID");

                entity.Property(e => e.ConnectXml).HasColumnType("xml");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TransportName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TransportType)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblDataExchangeVelocityEntitlementPassword>(entity =>
            {
                entity.HasKey(e => e.Epid);

                entity.ToTable("tbl_DataExchangeVelocityEntitlementPassword");

                entity.Property(e => e.Epid).HasColumnName("EPID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DefaultEntitlementId).HasColumnName("DefaultEntitlementID");

                entity.Property(e => e.DisabledReasonId).HasColumnName("DisabledReasonID");

                entity.Property(e => e.EntitlementGroupCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EntitlementGroupId).HasColumnName("EntitlementGroupID");

                entity.Property(e => e.EntitlementPassword)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EntitlementPasswordId).HasColumnName("EntitlementPasswordID");

                entity.Property(e => e.EntitlementUsageId).HasColumnName("EntitlementUsageID");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblDeliveryType>(entity =>
            {
                entity.HasKey(e => e.DeliveryTypeId);

                entity.ToTable("tbl_DeliveryType");

                entity.Property(e => e.DeliveryTypeId).HasColumnName("DeliveryTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeliveryType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.DeliveryTypeDesc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeliveryTypeName)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblDistributionChannel>(entity =>
            {
                entity.HasKey(e => e.DistributionChannelCode);

                entity.ToTable("tblDistributionChannel");

                entity.Property(e => e.DistributionChannelCode)
                    .HasMaxLength(1)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblEnquiryEdit>(entity =>
            {
                entity.HasKey(e => e.EnquiryEditId);

                entity.ToTable("tbl_EnquiryEdit");

                entity.Property(e => e.EnquiryEditId).HasColumnName("EnquiryEditID");

                entity.Property(e => e.AlternateText).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ImageUrl)
                    .HasColumnName("ImageURL")
                    .HasMaxLength(255);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.QueryString)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Target).HasMaxLength(10);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblEnquiryFilter>(entity =>
            {
                entity.HasKey(e => e.EnquiryFilterId);

                entity.ToTable("tbl_EnquiryFilter");

                entity.Property(e => e.EnquiryFilterId).HasColumnName("EnquiryFilterID");

                entity.Property(e => e.Category).HasMaxLength(10);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DbobjectName)
                    .IsRequired()
                    .HasColumnName("DBObjectName")
                    .HasMaxLength(250);

                entity.Property(e => e.DbobjectType).HasColumnName("DBObjectType");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.DrillDown1Id).HasColumnName("DrillDown1ID");

                entity.Property(e => e.DrillDown2Id).HasColumnName("DrillDown2ID");

                entity.Property(e => e.DrillDown3Id).HasColumnName("DrillDown3ID");

                entity.Property(e => e.DrillDown4Id).HasColumnName("DrillDown4ID");

                entity.Property(e => e.DrillDown5Id).HasColumnName("DrillDown5ID");

                entity.Property(e => e.EnquiryEditId).HasColumnName("EnquiryEditID");

                entity.Property(e => e.EnquiryName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.PageTitle).HasMaxLength(50);

                entity.Property(e => e.Tstamp)
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.DrillDown1)
                    .WithMany(p => p.InverseDrillDown1)
                    .HasForeignKey(d => d.DrillDown1Id)
                    .HasConstraintName("FK_tbl_EnquiryFilter_tbl_EnquiryFilter_Drill1");

                entity.HasOne(d => d.DrillDown2)
                    .WithMany(p => p.InverseDrillDown2)
                    .HasForeignKey(d => d.DrillDown2Id)
                    .HasConstraintName("FK_tbl_EnquiryFilter_tbl_EnquiryFilter_Drill2");

                entity.HasOne(d => d.DrillDown3)
                    .WithMany(p => p.InverseDrillDown3)
                    .HasForeignKey(d => d.DrillDown3Id)
                    .HasConstraintName("FK_tbl_EnquiryFilter_tbl_EnquiryFilter_Drill3");

                entity.HasOne(d => d.DrillDown4)
                    .WithMany(p => p.InverseDrillDown4)
                    .HasForeignKey(d => d.DrillDown4Id)
                    .HasConstraintName("FK_tbl_EnquiryFilter_tbl_EnquiryFilter_Drill4");

                entity.HasOne(d => d.DrillDown5)
                    .WithMany(p => p.InverseDrillDown5)
                    .HasForeignKey(d => d.DrillDown5Id)
                    .HasConstraintName("FK_tbl_EnquiryFilter_tbl_EnquiryFilter_Drill5");

                entity.HasOne(d => d.EnquiryEdit)
                    .WithMany(p => p.TblEnquiryFilter)
                    .HasForeignKey(d => d.EnquiryEditId)
                    .HasConstraintName("FK_tbl_EnquiryFilter_tbl_EnquiryEdit");

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblEnquiryFilter)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_EnquiryFilter_tblOrganisation");
            });

            modelBuilder.Entity<TblEnquiryFilterParam>(entity =>
            {
                entity.HasKey(e => e.EnquiryFilterParamId);

                entity.ToTable("tbl_EnquiryFilterParam");

                entity.Property(e => e.EnquiryFilterParamId).HasColumnName("EnquiryFilterParamID");

                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DefaultValue).HasMaxLength(250);

                entity.Property(e => e.EnquiryFilterId).HasColumnName("EnquiryFilterID");

                entity.Property(e => e.InputHelpText).HasMaxLength(50);

                entity.Property(e => e.InputMask).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ParamDataTypeId).HasColumnName("ParamDataTypeID");

                entity.Property(e => e.ParamName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ToolTip).HasMaxLength(250);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.EnquiryFilter)
                    .WithMany(p => p.TblEnquiryFilterParam)
                    .HasForeignKey(d => d.EnquiryFilterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_EnquiryFilterParam_tbl_EnquiryFilter");

                entity.HasOne(d => d.ParamDataType)
                    .WithMany(p => p.TblEnquiryFilterParam)
                    .HasForeignKey(d => d.ParamDataTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_EnquiryFilterParam_tblAttributeDataType");
            });

            modelBuilder.Entity<TblEntitlement>(entity =>
            {
                entity.HasKey(e => e.EntitlementId);

                entity.ToTable("tbl_Entitlement");

                entity.HasIndex(e => e.EntitlementName)
                    .HasName("UC_tbl_Entitlement_EntitlementName")
                    .IsUnique();

                entity.Property(e => e.EntitlementId).HasColumnName("EntitlementID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EntitlementName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OfferCode).HasMaxLength(6);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblEntitlementDependency>(entity =>
            {
                entity.HasKey(e => new { e.ParentEntitlementId, e.ChildEntitlementId });

                entity.ToTable("tbl_EntitlementDependency");

                entity.HasIndex(e => e.ChildEntitlementId)
                    .HasName("IC_tbl_EntitlementDependency_ChildEntitlementID");

                entity.HasIndex(e => e.ParentEntitlementId)
                    .HasName("IC_tbl_EntitlementDependency_ParentEntitlementID");

                entity.Property(e => e.ParentEntitlementId).HasColumnName("ParentEntitlementID");

                entity.Property(e => e.ChildEntitlementId).HasColumnName("ChildEntitlementID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.ChildEntitlement)
                    .WithMany(p => p.TblEntitlementDependencyChildEntitlement)
                    .HasForeignKey(d => d.ChildEntitlementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_EntitlementDependency_ChildEntitlementID");

                entity.HasOne(d => d.ParentEntitlement)
                    .WithMany(p => p.TblEntitlementDependencyParentEntitlement)
                    .HasForeignKey(d => d.ParentEntitlementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_EntitlementDependency_ParentEntitlementID");
            });

            modelBuilder.Entity<TblEntitlementDisabledReason>(entity =>
            {
                entity.HasKey(e => e.DisabledReasonId);

                entity.ToTable("tbl_EntitlementDisabledReason");

                entity.HasIndex(e => e.DisabledReasonCode)
                    .HasName("UC_tbl_EntitlementDisabledReason_DisabledReasonCode")
                    .IsUnique();

                entity.Property(e => e.DisabledReasonId).HasColumnName("DisabledReasonID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DisabledReasonCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.DisabledReasonText)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Mapping).HasColumnType("xml");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblEntitlementGroup>(entity =>
            {
                entity.HasKey(e => e.EntitlementGroupId);

                entity.ToTable("tbl_EntitlementGroup");

                entity.HasIndex(e => e.DatabaseSource)
                    .HasName("ncidx_tbl_EntitlementGroup_DatabaseSource");

                entity.HasIndex(e => e.EntitlementGroupName)
                    .HasName("UC_tbl_EntitlementGroup_EntitlementGroupName")
                    .IsUnique();

                entity.HasIndex(e => e.EventGroupCode)
                    .HasName("ncidx_tbl_EntitlementGroup_EventGroupCode");

                entity.HasIndex(e => e.Mapping)
                    .HasName("PXML_EntitlementGroup_Mapping");

                entity.HasIndex(e => e.TicketType)
                    .HasName("ncidx_tbl_EntitlementGroup_TicketType");

                entity.Property(e => e.EntitlementGroupId).HasColumnName("EntitlementGroupID");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DatabaseSource)
                    .HasMaxLength(50)
                    .HasComputedColumnSql("([dbo].[udf_get_EntitlementGroup_DatabaseSource]([Mapping]))");

                entity.Property(e => e.EntitlementGroupName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.EventGroupCode)
                    .HasMaxLength(50)
                    .HasComputedColumnSql("([dbo].[udf_get_EntitlementGroup_EventGroupCode]([Mapping]))");

                entity.Property(e => e.Mapping).HasColumnType("xml");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TicketType)
                    .HasMaxLength(1)
                    .HasComputedColumnSql("([dbo].[udf_get_EntitlementGroup_TicketType]([Mapping]))");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblEntitlementPassword>(entity =>
            {
                entity.HasKey(e => e.EntitlementPasswordId);

                entity.ToTable("tbl_EntitlementPassword");

                entity.HasIndex(e => e.DisabledReasonId)
                    .HasName("IC_tbl_EntitlementPassword_DisabledReasonID");

                entity.HasIndex(e => e.EntitlementGroupId)
                    .HasName("IC_tbl_EntitlementPassword_EntitlementGroupID");

                entity.HasIndex(e => new { e.EntitlementPassword, e.EntitlementGroupId })
                    .HasName("UCL_tbl_EntitlementPassword")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => new { e.EntitlementPasswordId, e.EntitlementPassword, e.IsDisabled, e.DisabledReasonId, e.EntitlementGroupId })
                    .HasName("NCINDEX_tbl_EntitlementPassword_EntitlementGroupID_inc_EntitlementPasswordID_EntitlementPassword_IsDisabled_DisabledReasonID");

                entity.Property(e => e.EntitlementPasswordId).HasColumnName("EntitlementPasswordID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DisabledReasonId).HasColumnName("DisabledReasonID");

                entity.Property(e => e.EntitlementGroupId).HasColumnName("EntitlementGroupID");

                entity.Property(e => e.EntitlementPassword)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.DisabledReason)
                    .WithMany(p => p.TblEntitlementPassword)
                    .HasForeignKey(d => d.DisabledReasonId)
                    .HasConstraintName("FK_tbl_EntitlementPassword_DisabledReasonID");

                entity.HasOne(d => d.EntitlementGroup)
                    .WithMany(p => p.TblEntitlementPassword)
                    .HasForeignKey(d => d.EntitlementGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_EntitlementPassword_EntitlementGroupID");
            });

            modelBuilder.Entity<TblEntitlementUsage>(entity =>
            {
                entity.HasKey(e => e.EntitlementUsageId);

                entity.ToTable("tbl_EntitlementUsage");

                entity.HasIndex(e => e.Admits)
                    .HasName("NCINDEX_tbl_EntitlementUsage_Admits");

                entity.HasIndex(e => e.DisabledReasonId)
                    .HasName("IC_tbl_EntitlementUsage_DisabledReasonID");

                entity.HasIndex(e => e.EntitlementId)
                    .HasName("IC_tbl_EntitlementUsage_EntitlementID");

                entity.HasIndex(e => e.EntitlementPasswordId)
                    .HasName("IC_tbl_EntitlementUsage_EntitlementPasswordID");

                entity.HasIndex(e => e.IsAttendance)
                    .HasName("NCINDEX_tbl_EntitlementUsage_IsAttendance");

                entity.HasIndex(e => e.PaxmasterEventCode)
                    .HasName("NCINDEX_tbl_EntitlementUsage_PAXMasterEventCode");

                entity.HasIndex(e => e.ProtectionGroupId)
                    .HasName("IC_tbl_EntitlementUsage_ProtectionGroupID");

                entity.HasIndex(e => new { e.BasketLeaderTransactionDate, e.BasketLeaderTransactionNumber })
                    .HasName("IC_tbl_EntitlementUsage_BasketLeaderTransactionDate_BasketLeaderTransactionNumber");

                entity.HasIndex(e => new { e.EventCode, e.NativeBarcode })
                    .HasName("IC_tbl_EntitlementUsage_EventCode_NativeBarcode");

                entity.HasIndex(e => new { e.TransactionDate, e.TransactionNumber })
                    .HasName("IC_tbl_EntitlementUsage_TransactionDate_TransactionNumber");

                entity.HasIndex(e => new { e.Admits, e.IsAttendance, e.UsageCancelled })
                    .HasName("NCINDEX_tbl_EntitlementUsage_Admits_IsAttendance_UsageCancelled");

                entity.HasIndex(e => new { e.EntitlementPasswordId, e.IsDisabled, e.UsageCancelled })
                    .HasName("NCINDEX_tbl_EntitlementUsage_EntitlementPasswordID_IsDisabled_UsageCancelled");

                entity.HasIndex(e => new { e.EntitlementPasswordId, e.DisabledReasonId, e.IsDisabled, e.UsageCancelled })
                    .HasName("NCINDEX_tbl_EntitlementUsage_IsDisabled_UsageCancelled_inc_EntitlementPasswordID_DisabledReasonID");

                entity.HasIndex(e => new { e.EntitlementPasswordId, e.EntitlementId, e.NativeBarcode, e.UsageCancelled })
                    .HasName("NCINDEX_tbl_EntitlementUsage_UsageCancelled_inc_EntitlementPasswordID_EntitlementID_NativeBarcode");

                entity.HasIndex(e => new { e.EntitlementPasswordId, e.NativeBarcode, e.Admits, e.EntitlementId, e.UsageCancelled })
                    .HasName("NCINDEX_tbl_EntitlementUsage_EntitlementID_UsageCancelled_inc_EntitlementPasswordID_NativeBarcode_Admits");

                entity.Property(e => e.EntitlementUsageId).HasColumnName("EntitlementUsageID");

                entity.Property(e => e.AfileName).HasMaxLength(3);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DeliveryMethod).HasMaxLength(1);

                entity.Property(e => e.DisabledReasonId).HasColumnName("DisabledReasonID");

                entity.Property(e => e.DistributionChannelCode).HasMaxLength(1);

                entity.Property(e => e.EntitlementId).HasColumnName("EntitlementID");

                entity.Property(e => e.EntitlementPasswordId).HasColumnName("EntitlementPasswordID");

                entity.Property(e => e.EventCode).HasMaxLength(50);

                entity.Property(e => e.ForeignEventCode).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NativeBarcode).HasMaxLength(50);

                entity.Property(e => e.OfferCode).HasMaxLength(50);

                entity.Property(e => e.PaxmasterEventCode)
                    .HasColumnName("PAXMasterEventCode")
                    .HasMaxLength(50);

                entity.Property(e => e.PriceTypeCode).HasMaxLength(20);

                entity.Property(e => e.ProtectionGroupId).HasColumnName("ProtectionGroupID");

                entity.Property(e => e.Seating).HasMaxLength(500);

                entity.Property(e => e.SellerCode).HasMaxLength(50);

                entity.Property(e => e.SourcePriceType).HasMaxLength(1);

                entity.Property(e => e.TicketCost).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.TicketGst)
                    .HasColumnName("TicketGST")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.TransactionDateTime).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblEntitlementUsage)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_tbl_EntitlementUsage_CustomerID");

                entity.HasOne(d => d.DisabledReason)
                    .WithMany(p => p.TblEntitlementUsage)
                    .HasForeignKey(d => d.DisabledReasonId)
                    .HasConstraintName("FK_tbl_EntitlementUsage_DisabledReasonID");

                entity.HasOne(d => d.DistributionChannelCodeNavigation)
                    .WithMany(p => p.TblEntitlementUsage)
                    .HasForeignKey(d => d.DistributionChannelCode)
                    .HasConstraintName("FK_tbl_EntitlementUsage_DistributionChannelCode");

                entity.HasOne(d => d.Entitlement)
                    .WithMany(p => p.TblEntitlementUsage)
                    .HasForeignKey(d => d.EntitlementId)
                    .HasConstraintName("FK_tbl_EntitlementUsage_EntitlementID");

                entity.HasOne(d => d.EntitlementPassword)
                    .WithMany(p => p.TblEntitlementUsage)
                    .HasForeignKey(d => d.EntitlementPasswordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_EntitlementUsage_EntitlementPasswordID");

                entity.HasOne(d => d.ProtectionGroup)
                    .WithMany(p => p.TblEntitlementUsage)
                    .HasForeignKey(d => d.ProtectionGroupId)
                    .HasConstraintName("FK_tbl_EntitlementUsage_ProtectionGroupID");
            });

            modelBuilder.Entity<TblEventType>(entity =>
            {
                entity.HasKey(e => e.EventTypeId);

                entity.ToTable("tbl_EventType");

                entity.Property(e => e.EventTypeId).HasColumnName("EventTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EventType)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.EventTypeDesc)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblEventWorksAudit>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("tbl_EventWorksAudit");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.NotificationId).HasColumnName("NotificationID");

                entity.Property(e => e.NotificationName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblEventWorksFile>(entity =>
            {
                entity.HasKey(e => new { e.FileId, e.NotificationId });

                entity.ToTable("tbl_EventWorksFile");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.NotificationId).HasColumnName("NotificationID");

                entity.Property(e => e.Context).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.File)
                    .WithMany(p => p.TblEventWorksFile)
                    .HasForeignKey(d => d.FileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_EventWorksFile_tbl_File");

                entity.HasOne(d => d.Notification)
                    .WithMany(p => p.TblEventWorksFile)
                    .HasForeignKey(d => d.NotificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_EventWorksFile_tbl_Notification");
            });

            modelBuilder.Entity<TblEzyTicketGenerationLog>(entity =>
            {
                entity.HasKey(e => e.EzyTicketLogId);

                entity.ToTable("tbl_EzyTicketGenerationLog");

                entity.HasIndex(e => new { e.EzyTicketLogId, e.SubscriptionId })
                    .HasName("NCINDEX_tbl_EzyTicketGenerationLog_SubscriptionID_inc_EzyTicketLogID");

                entity.Property(e => e.EzyTicketLogId).HasColumnName("EzyTicketLogID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Subscription)
                    .WithMany(p => p.TblEzyTicketGenerationLog)
                    .HasForeignKey(d => d.SubscriptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EzyTicketGenerationLog_tbl_Subscription");
            });

            modelBuilder.Entity<TblEzyTicketReplacementType>(entity =>
            {
                entity.HasKey(e => e.ReplacementId);

                entity.ToTable("tbl_EzyTicketReplacementType");

                entity.Property(e => e.ReplacementId)
                    .HasColumnName("ReplacementID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ReplacementTypeName)
                    .HasColumnName("REplacementTypeName")
                    .HasMaxLength(100);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblFile>(entity =>
            {
                entity.HasKey(e => e.FileId);

                entity.ToTable("tbl_File");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.FileName).HasMaxLength(100);

                entity.Property(e => e.OriginalFileName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblForeignBarcode>(entity =>
            {
                entity.HasKey(e => e.ForeignBarcodeId);

                entity.ToTable("tbl_ForeignBarcode");

                entity.Property(e => e.ForeignBarcodeId).HasColumnName("ForeignBarcodeID");

                entity.Property(e => e.BarcodeNumber)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.PriceTypeId).HasColumnName("PriceTypeID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.SeasonId).HasColumnName("SeasonID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .IsRowVersion();

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblForeignBarcode)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ForeignBarcode_tblOrganisation");

                entity.HasOne(d => d.PriceType)
                    .WithMany(p => p.TblForeignBarcode)
                    .HasForeignKey(d => d.PriceTypeId)
                    .HasConstraintName("FK_tbl_ForeignBarcode_tbl_PriceType");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblForeignBarcode)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_tbl_ForeignBarcode_tbl_Product");

                entity.HasOne(d => d.Season)
                    .WithMany(p => p.TblForeignBarcode)
                    .HasForeignKey(d => d.SeasonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ForeignBarcode_tbl_Season");
            });

            modelBuilder.Entity<TblGiftCard>(entity =>
            {
                entity.HasKey(e => e.GiftCardId);

                entity.ToTable("tbl_GiftCard");

                entity.Property(e => e.GiftCardId).HasColumnName("GiftCardID");

                entity.Property(e => e.CompanyCode).HasMaxLength(10);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.GiftCardIdentifier).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductCode).HasMaxLength(10);

                entity.Property(e => e.Tstamp)
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.VoucherId).HasColumnName("VoucherID");

                entity.HasOne(d => d.Voucher)
                    .WithMany(p => p.TblGiftCard)
                    .HasForeignKey(d => d.VoucherId)
                    .HasConstraintName("FK_tbl_GiftCard_REF_Voucher");
            });

            modelBuilder.Entity<TblGiftVoucherBarcodeMap>(entity =>
            {
                entity.HasKey(e => e.OriginalBarcode);

                entity.ToTable("tbl_GiftVoucherBarcodeMap");

                entity.Property(e => e.OriginalBarcode)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NewBarcode).HasMaxLength(50);

                entity.Property(e => e.Tstamp)
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblGroupCustomerList>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblGroupCustomerList");

                entity.HasIndex(e => new { e.GroupId, e.CustomerListId })
                    .HasName("UC_CustomerListID_GroupID")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.AccessLevelId).HasColumnName("AccessLevelID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerListId).HasColumnName("CustomerListID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.AccessLevel)
                    .WithMany(p => p.TblGroupCustomerList)
                    .HasForeignKey(d => d.AccessLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblAccessLevel_tblGroupCustomerList_FK1");

                entity.HasOne(d => d.CustomerList)
                    .WithMany(p => p.TblGroupCustomerList)
                    .HasForeignKey(d => d.CustomerListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblRefCustomerList_tblGroupCustomerList_FK1");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.TblGroupCustomerList)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblSysGroup_tblGroupCustomerList_FK1");
            });

            modelBuilder.Entity<TblGroupCustomerType>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblGroupCustomerType");

                entity.HasIndex(e => new { e.GroupId, e.CustomerTypeId })
                    .HasName("UC_GroupID_CustomerTypeID")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.AccessLevelId).HasColumnName("AccessLevelID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerTypeId).HasColumnName("CustomerTypeID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.AccessLevel)
                    .WithMany(p => p.TblGroupCustomerType)
                    .HasForeignKey(d => d.AccessLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblAccessLevel_tblGroupCustomerType_FK1");

                entity.HasOne(d => d.CustomerType)
                    .WithMany(p => p.TblGroupCustomerType)
                    .HasForeignKey(d => d.CustomerTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblCustomerTypeJoin_tblGroupCustomerType_FK1");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.TblGroupCustomerType)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblSysGroup_tblGroupCustomerType_FK1");
            });

            modelBuilder.Entity<TblGroupOrganisation>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblGroupOrganisation");

                entity.HasIndex(e => new { e.GroupId, e.OrganisationId })
                    .HasName("UC_GroupID_OrganisationID")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.AccessLevelId).HasColumnName("AccessLevelID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.AccessLevel)
                    .WithMany(p => p.TblGroupOrganisation)
                    .HasForeignKey(d => d.AccessLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblAccessLevel_tblGroupOrganisation_FK1");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.TblGroupOrganisation)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblSysGroup_tblGroupOrganisation_FK1");

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblGroupOrganisation)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblOrganisation_tblGroupOrganisation_FK1");
            });

            modelBuilder.Entity<TblGroupPromoter>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblGroupPromoter");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.AccessLevelId).HasColumnName("AccessLevelID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PromoterId).HasColumnName("PromoterID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.AccessLevel)
                    .WithMany(p => p.TblGroupPromoter)
                    .HasForeignKey(d => d.AccessLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblAccessLevel_tblGroupPromoter_FK1");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.TblGroupPromoter)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblSysGroup_tblGroupPromoter_FK1");

                entity.HasOne(d => d.Promoter)
                    .WithMany(p => p.TblGroupPromoter)
                    .HasForeignKey(d => d.PromoterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblPromoter_tblGroupPromoter_FK1");
            });

            modelBuilder.Entity<TblGroupVenueManager>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblGroupVenueManager");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.AccessLevelId).HasColumnName("AccessLevelID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.VenueManagerId).HasColumnName("VenueManagerID");

                entity.HasOne(d => d.AccessLevel)
                    .WithMany(p => p.TblGroupVenueManager)
                    .HasForeignKey(d => d.AccessLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblAccessLevel_tblGroupVenueManager_FK1");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.TblGroupVenueManager)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblSysGroup_tblGroupVenueManager_FK1");
            });

            modelBuilder.Entity<TblInsurancePremium>(entity =>
            {
                entity.HasKey(e => e.InsurancePremiumId);

                entity.ToTable("tbl_InsurancePremium");

                entity.Property(e => e.InsurancePremiumId).HasColumnName("InsurancePremiumID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExternalProductId)
                    .IsRequired()
                    .HasColumnName("ExternalProductID")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PerformanceCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductType)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                entity.Property(e => e.ValidTo).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblInsuranceRequest>(entity =>
            {
                entity.HasKey(e => e.InsuranceRequestId);

                entity.ToTable("tbl_InsuranceRequest");

                entity.HasIndex(e => new { e.ContractNumber, e.RequestFail })
                    .HasName("IC_tbl_InsuranceRequest_ContractNumber_RequestFail");

                entity.HasIndex(e => new { e.TransactionDate, e.TransactionNumber })
                    .HasName("NCINDEX_tbl_InsuranceRequest_TransactionDate_TransactionNumber");

                entity.HasIndex(e => new { e.ContractNumber, e.DemandString, e.InsuranceTransactionDate, e.InsuranceTransactionNumber })
                    .HasName("NCINDEX_tbl_InsuranceRequest_InsuranceTransactionDate_InsuranceTransactionNumber");

                entity.Property(e => e.InsuranceRequestId).HasColumnName("InsuranceRequestID");

                entity.Property(e => e.ContractNumber).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DemandString)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RequestXml)
                    .IsRequired()
                    .HasColumnName("RequestXML")
                    .HasColumnType("xml");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblInventoryTransaction>(entity =>
            {
                entity.HasKey(e => e.InventoryTransactionId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblInventoryTransaction");

                entity.HasIndex(e => e.EventDateName)
                    .HasName("IX_EventDateName");

                entity.HasIndex(e => e.ModifiedDate)
                    .HasName("UNCLIDX_temp_tblInventoryTransaction_ModifiedDate");

                entity.HasIndex(e => e.PlaceCode)
                    .HasName("IX_PlaceCode");

                entity.HasIndex(e => e.PromoterName)
                    .HasName("IX_PromoterName");

                entity.HasIndex(e => e.SaleTransId)
                    .HasName("nclidx_tblInventoryTransaction_SaleTransID");

                entity.HasIndex(e => e.SellerCode)
                    .HasName("IX_SellerCode");

                entity.HasIndex(e => e.ShowTag)
                    .HasName("IX_ShowTag");

                entity.HasIndex(e => new { e.CustomerId, e.InventoryTransactionId })
                    .HasName("IX_tblInventoryTransaction_CustomerID")
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => new { e.OrderId, e.PromCode })
                    .HasName("IX_tblInventoryTransaction_OrderID_OrderID_Promcode");

                entity.Property(e => e.InventoryTransactionId)
                    .HasColumnName("InventoryTransactionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AfileName).HasMaxLength(3);

                entity.Property(e => e.Allocations).HasColumnType("xml");

                entity.Property(e => e.AmountOwed).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.AmountPaid).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.AuthorisationStatusId)
                    .HasColumnName("AuthorisationStatusID")
                    .HasMaxLength(10);

                entity.Property(e => e.BasketNextTransId).HasColumnName("BasketNextTransID");

                entity.Property(e => e.BfeeAmount)
                    .HasColumnName("BFeeAmount")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.BusinessType).HasMaxLength(50);

                entity.Property(e => e.ChainName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CollectableAmountOwing).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditCardFeeAmountCalculated).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DeliveryMethod).HasMaxLength(1);

                entity.Property(e => e.DistributedAmount).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.DistributedIcamount)
                    .HasColumnName("DistributedICAmount")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.DistributedIcamountApplied)
                    .HasColumnName("DistributedICAmountApplied")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.DistributedTaxAmount).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.DistributedTaxAmountApplied).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.DistributionChannelCode).HasMaxLength(1);

                entity.Property(e => e.EventDateName).HasMaxLength(50);

                entity.Property(e => e.EventName).HasMaxLength(50);

                entity.Property(e => e.ExchangeDiffCharged).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.ExchangeDiffWaived).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.ExchangeFee).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.FirstTransGsn).HasColumnName("FirstTransGSN");

                entity.Property(e => e.GrossAmountPaid).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.GrossSalesAmount).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Gstapplies).HasColumnName("GSTApplies");

                entity.Property(e => e.GstinBfeeAmount).HasColumnName("GSTInBFeeAmount");

                entity.Property(e => e.GstinHfeeAmount).HasColumnName("GSTInHFeeAmount");

                entity.Property(e => e.GstinIcamount).HasColumnName("GSTInICAmount");

                entity.Property(e => e.GstinPriceAmount).HasColumnName("GSTInPriceAmount");

                entity.Property(e => e.GstinclCamount).HasColumnName("GSTInclCAmount");

                entity.Property(e => e.Gstrate)
                    .HasColumnName("GSTRate")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.GstsiteLiable)
                    .HasColumnName("GSTSiteLiable")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.HandlingFeeAmount).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.InsideChargeAmount).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OriginalDeliveryMethod).HasMaxLength(1);

                entity.Property(e => e.PayTypeFeeAmount).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.PaymentTransId).HasColumnName("PaymentTransID");

                entity.Property(e => e.PlaceCode)
                    .IsRequired()
                    .HasColumnType("nchar(5)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PromCode)
                    .IsRequired()
                    .HasColumnType("nchar(3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PromoterCreditCardFee).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.PromoterName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PromoterRegionName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ReturnReason).HasMaxLength(50);

                entity.Property(e => e.ReturnTransId).HasColumnName("ReturnTransID");

                entity.Property(e => e.RowSeatString).HasMaxLength(50);

                entity.Property(e => e.SaleTransId).HasColumnName("SaleTransID");

                entity.Property(e => e.SalesAmount).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.SalesIcamount)
                    .HasColumnName("SalesICAmount")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.SectionName).HasMaxLength(50);

                entity.Property(e => e.SellerCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SellerId)
                    .HasColumnName("SellerID")
                    .HasMaxLength(50);

                entity.Property(e => e.ShowTag).HasMaxLength(50);

                entity.Property(e => e.TaxAmount).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.TixLastPrintDateTime).HasColumnType("datetime");

                entity.Property(e => e.TixLastPrintNoPrintTransDateTime).HasColumnType("datetime");

                entity.Property(e => e.TixPrintId).HasColumnName("TixPrintID");

                entity.Property(e => e.TotalCommission).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.TransactionDateTime).HasColumnType("datetime");

                entity.Property(e => e.TransactionType).HasMaxLength(50);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.AuthorisationStatus)
                    .WithMany(p => p.TblInventoryTransaction)
                    .HasForeignKey(d => d.AuthorisationStatusId)
                    .HasConstraintName("tblAuthorisationStatus_tblInventoryTransaction_FK1");

                entity.HasOne(d => d.BasketNextTrans)
                    .WithMany(p => p.TblInventoryTransactionBasketNextTrans)
                    .HasForeignKey(d => d.BasketNextTransId)
                    .HasConstraintName("tblOriginInventoryTransactionMap_tblInventoryTransaction_FK1");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblInventoryTransaction)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("tblInventoryTransaction_tblCustomer_FK1");

                entity.HasOne(d => d.DistributionChannelCodeNavigation)
                    .WithMany(p => p.TblInventoryTransaction)
                    .HasForeignKey(d => d.DistributionChannelCode)
                    .HasConstraintName("tblDistributionChannel_tblInventoryTransaction_FK1");

                entity.HasOne(d => d.InventoryTransaction)
                    .WithOne(p => p.TblInventoryTransactionInventoryTransaction)
                    .HasForeignKey<TblInventoryTransaction>(d => d.InventoryTransactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblInventoryTransaction_tblInventoryTransaction_FK3");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TblInventoryTransaction)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("tblOrder_tblInventoryTransaction_FK1");

                entity.HasOne(d => d.PaymentTrans)
                    .WithMany(p => p.TblInventoryTransactionPaymentTrans)
                    .HasForeignKey(d => d.PaymentTransId)
                    .HasConstraintName("tblOriginInventoryTransactionMap_tblInventoryTransaction_FK6");

                entity.HasOne(d => d.ReturnTrans)
                    .WithMany(p => p.TblInventoryTransactionReturnTrans)
                    .HasForeignKey(d => d.ReturnTransId)
                    .HasConstraintName("tblInventoryTransaction_tblInventoryTransaction_FK1");

                entity.HasOne(d => d.SaleTrans)
                    .WithMany(p => p.TblInventoryTransactionSaleTrans)
                    .HasForeignKey(d => d.SaleTransId)
                    .HasConstraintName("tblInventoryTransaction_tblInventoryTransaction_FK2");
            });

            modelBuilder.Entity<TblInventoryTransactionSource>(entity =>
            {
                entity.HasKey(e => new { e.TransactionDate, e.TransactionNumber });

                entity.ToTable("tbl_InventoryTransactionSource");

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ReferrerId).HasColumnName("ReferrerID");

                entity.Property(e => e.ReferrerType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SourceCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblLinkedFees>(entity =>
            {
                entity.HasKey(e => new { e.FeeProductId, e.ProductId });

                entity.ToTable("tbl_LinkedFees");

                entity.Property(e => e.FeeProductId).HasColumnName("FeeProductID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.FeeProduct)
                    .WithMany(p => p.TblLinkedFeesFeeProduct)
                    .HasForeignKey(d => d.FeeProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_tbl_LinkedFees_tbl_Product_FeeProductID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblLinkedFeesProduct)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_tbl_LinkedFees_tbl_Product_ProductID");
            });

            modelBuilder.Entity<TblMandatoryProduct>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("tbl_MandatoryProduct");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Product)
                    .WithOne(p => p.TblMandatoryProduct)
                    .HasForeignKey<TblMandatoryProduct>(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MandatoryProduct_ProductID");
            });

            modelBuilder.Entity<TblMasterMapping>(entity =>
            {
                entity.HasKey(e => e.MasterMappingId);

                entity.ToTable("tbl_MasterMapping");

                entity.Property(e => e.MasterMappingId).HasColumnName("MasterMappingID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MappingDescription).HasMaxLength(200);

                entity.Property(e => e.MappingGroup)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MappingName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.MappingValue).HasMaxLength(2000);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblMasterMapping)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MasterMapping_tblOrganisation");
            });

            modelBuilder.Entity<TblMember>(entity =>
            {
                entity.HasKey(e => e.OrganisationCustomerId);

                entity.ToTable("tbl_Member");

                entity.HasIndex(e => e.UserName)
                    .HasName("NCINDEX_tbl_Member_UserName");

                entity.HasIndex(e => new { e.MemberNumber, e.OrganisationCustomerId })
                    .HasName("NCINDEX_tbl_Member_MemberNumber_OrganisationCustomerID");

                entity.Property(e => e.OrganisationCustomerId)
                    .HasColumnName("OrganisationCustomerID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExtRefCode).HasMaxLength(100);

                entity.Property(e => e.MemberNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.MemberSince).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Password).HasMaxLength(256);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.UserName).HasMaxLength(200);

                entity.HasOne(d => d.OrganisationCustomer)
                    .WithOne(p => p.TblMember)
                    .HasForeignKey<TblMember>(d => d.OrganisationCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblMem_Reference_tblOrgCustomer");
            });

            modelBuilder.Entity<TblMemberPerformanceBarcode>(entity =>
            {
                entity.HasKey(e => e.MemberPerformanceBarcodeId);

                entity.ToTable("tbl_MemberPerformanceBarcode");

                entity.Property(e => e.MemberPerformanceBarcodeId).HasColumnName("MemberPerformanceBarcodeID");

                entity.Property(e => e.Aisle).HasMaxLength(10);

                entity.Property(e => e.AttendanceRequestProcessedDate).HasColumnType("datetime");

                entity.Property(e => e.AttendedDate).HasColumnType("datetime");

                entity.Property(e => e.Barcode)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Door).HasMaxLength(10);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderlineId).HasColumnName("OrderlineID");

                entity.Property(e => e.OrganisationCustomerId).HasColumnName("OrganisationCustomerID");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.RequestProcessedDate).HasColumnType("datetime");

                entity.Property(e => e.SeasonId).HasColumnName("SeasonID");

                entity.Property(e => e.SubscriptionAllocationId).HasColumnName("SubscriptionAllocationID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.VenueId).HasColumnName("VenueID");

                entity.HasOne(d => d.OrganisationCustomer)
                    .WithMany(p => p.TblMemberPerformanceBarcode)
                    .HasForeignKey(d => d.OrganisationCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MemberPerformanceBarcode_REF_tblOrganisationCustomer");

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblMemberPerformanceBarcode)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MemberPerformanceBarcode_REF_tblOrganisation");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblMemberPerformanceBarcode)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MemberPerformanceBarcode_REF_tbl_Product");

                entity.HasOne(d => d.Season)
                    .WithMany(p => p.TblMemberPerformanceBarcode)
                    .HasForeignKey(d => d.SeasonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MemberPerformanceBarcode_REF_tbl_Season");

                entity.HasOne(d => d.Venue)
                    .WithMany(p => p.TblMemberPerformanceBarcode)
                    .HasForeignKey(d => d.VenueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MemberPerformanceBarcode_REF_tbl_Venue");
            });

            modelBuilder.Entity<TblMemberRanking>(entity =>
            {
                entity.HasKey(e => e.MemberRankingId);

                entity.ToTable("tbl_MemberRanking");

                entity.HasIndex(e => new { e.OrganisationCustomerId, e.ProductId })
                    .HasName("NCLIDX_tbl_MemberRanking_OrganisationCustomerID");

                entity.HasIndex(e => new { e.ProductId, e.OrganisationCustomerId })
                    .HasName("NCLIDX_tbl_MemberRanking_ProductID");

                entity.Property(e => e.MemberRankingId).HasColumnName("MemberRankingID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationCustomerId).HasColumnName("OrganisationCustomerID");

                entity.Property(e => e.PreviousMemberRankingId).HasColumnName("PreviousMemberRankingID");

                entity.Property(e => e.ProductAttendance).HasDefaultValueSql("((1))");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.OrganisationCustomer)
                    .WithMany(p => p.TblMemberRanking)
                    .HasForeignKey(d => d.OrganisationCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MemberRanking_tblOrganisationCustomer");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblMemberRanking)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MemberRanking_tbl_Product");
            });

            modelBuilder.Entity<TblMemberRollover>(entity =>
            {
                entity.HasKey(e => e.MemberRolloverId);

                entity.ToTable("tbl_MemberRollover");

                entity.Property(e => e.MemberRolloverId).HasColumnName("MemberRolloverID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DynamicPricingPriceTypeCode).HasMaxLength(10);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationCustomerId).HasColumnName("OrganisationCustomerID");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.PaymentOptionCode).HasMaxLength(10);

                entity.Property(e => e.PriceTypeId).HasColumnName("PriceTypeID");

                entity.Property(e => e.SeasonId).HasColumnName("SeasonID");

                entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.OrganisationCustomer)
                    .WithMany(p => p.TblMemberRollover)
                    .HasForeignKey(d => d.OrganisationCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MemberRollover_tbl_Member");

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblMemberRollover)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MemberRollover_tbl_MembershipOrganisation");

                entity.HasOne(d => d.Season)
                    .WithMany(p => p.TblMemberRollover)
                    .HasForeignKey(d => d.SeasonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MemberRollover_tbl_Season");
            });

            modelBuilder.Entity<TblMembership>(entity =>
            {
                entity.HasKey(e => e.MembershipId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tbl_Membership");

                entity.HasIndex(e => e.OrganisationCustomerId)
                    .HasName("NCLIDX_tbl_Membership_MemberID");

                entity.HasIndex(e => e.SeatZonePreferenceId)
                    .HasName("NCLIDX_tbl_Membership_SeatZonePreferenceID");

                entity.HasIndex(e => new { e.OrganisationCustomerId, e.MembershipProductId })
                    .HasName("NCINDEX_tbl_Membership_OrganisationCustomerID_MembershipProductID");

                entity.Property(e => e.MembershipId).HasColumnName("MembershipID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.MembershipNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.MembershipProductId).HasColumnName("MembershipProductID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationCustomerId).HasColumnName("OrganisationCustomerID");

                entity.Property(e => e.SeatZonePreferenceId).HasColumnName("SeatZonePreferenceID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.MembershipProduct)
                    .WithMany(p => p.TblMembership)
                    .HasForeignKey(d => d.MembershipProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_Membership_tbl_MembershipProduct");

                entity.HasOne(d => d.OrganisationCustomer)
                    .WithMany(p => p.TblMembership)
                    .HasForeignKey(d => d.OrganisationCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblMembership_Reference_tblOrgCustomer");

                entity.HasOne(d => d.SeatZonePreference)
                    .WithMany(p => p.TblMembership)
                    .HasForeignKey(d => d.SeatZonePreferenceId)
                    .HasConstraintName("FK_tbl_Membership_Reference_tbl_SeatZonePreference");
            });

            modelBuilder.Entity<TblMembershipContentType>(entity =>
            {
                entity.HasKey(e => e.ContentTypeId);

                entity.ToTable("tbl_MembershipContentType");

                entity.Property(e => e.ContentTypeId).HasColumnName("ContentTypeID");

                entity.Property(e => e.ContentTypeDescription).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.KeyName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblMembershipGroup>(entity =>
            {
                entity.HasKey(e => e.MembershipGroupId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tbl_MembershipGroup");

                entity.Property(e => e.MembershipGroupId).HasColumnName("MembershipGroupID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LeaderMemberId).HasColumnName("LeaderMemberID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.LeaderMember)
                    .WithMany(p => p.TblMembershipGroup)
                    .HasForeignKey(d => d.LeaderMemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblMemGroup_Reference_tblMember");
            });

            modelBuilder.Entity<TblMembershipOrganisation>(entity =>
            {
                entity.HasKey(e => e.OrganisationId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tbl_MembershipOrganisation");

                entity.Property(e => e.OrganisationId)
                    .HasColumnName("OrganisationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AcceptPartPaymentsUntil).HasColumnType("datetime");

                entity.Property(e => e.Afile)
                    .HasColumnName("AFile")
                    .HasMaxLength(5);

                entity.Property(e => e.BookingFormBlurb).HasColumnType("ntext");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerListId).HasColumnName("CustomerListID");

                entity.Property(e => e.DefaultMembershipProductId).HasColumnName("DefaultMembershipProductID");

                entity.Property(e => e.ExtRefCode).HasMaxLength(100);

                entity.Property(e => e.IsCrmenabled).HasColumnName("IsCRMEnabled");

                entity.Property(e => e.MemberNumberPrefix).HasMaxLength(5);

                entity.Property(e => e.MembershipOrganisationTypeId).HasColumnName("MembershipOrganisationTypeID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderProcessTypeId).HasColumnName("OrderProcessTypeID");

                entity.Property(e => e.PartPaymentProductId).HasColumnName("PartPaymentProductID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.CustomerList)
                    .WithMany(p => p.TblMembershipOrganisation)
                    .HasForeignKey(d => d.CustomerListId)
                    .HasConstraintName("FK_tbl_MembershipOrganisation_tblCustomerList");

                entity.HasOne(d => d.DefaultMembershipProduct)
                    .WithMany(p => p.TblMembershipOrganisation)
                    .HasForeignKey(d => d.DefaultMembershipProductId)
                    .HasConstraintName("FK_tbl_MembershipOrganisation_tbl_MembershipProduct");

                entity.HasOne(d => d.MembershipOrganisationType)
                    .WithMany(p => p.TblMembershipOrganisation)
                    .HasForeignKey(d => d.MembershipOrganisationTypeId)
                    .HasConstraintName("FK_tbl_MembershipOrganisation_tbl_MembershipOrganisationType");

                entity.HasOne(d => d.OrderProcessType)
                    .WithMany(p => p.TblMembershipOrganisation)
                    .HasForeignKey(d => d.OrderProcessTypeId)
                    .HasConstraintName("FK_tbl_MembershipOrganisation_tbl_OrderProcessType");

                entity.HasOne(d => d.Organisation)
                    .WithOne(p => p.TblMembershipOrganisation)
                    .HasForeignKey<TblMembershipOrganisation>(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblMembeshipOrg_Reference_tblOrganisation");
            });

            modelBuilder.Entity<TblMembershipOrganisationContent>(entity =>
            {
                entity.HasKey(e => e.OrganisationContentId);

                entity.ToTable("tbl_MembershipOrganisationContent");

                entity.Property(e => e.OrganisationContentId).HasColumnName("OrganisationContentID");

                entity.Property(e => e.ContentTypeId).HasColumnName("ContentTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.ContentType)
                    .WithMany(p => p.TblMembershipOrganisationContent)
                    .HasForeignKey(d => d.ContentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MembershipOrganisationContent_tbl_MembershipContentType");

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblMembershipOrganisationContent)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MembershipOrganisationContent_tbl_MembershipOrganisationContent");
            });

            modelBuilder.Entity<TblMembershipOrganisationType>(entity =>
            {
                entity.HasKey(e => e.MembershipOrganisationTypeId);

                entity.ToTable("tbl_MembershipOrganisationType");

                entity.Property(e => e.MembershipOrganisationTypeId).HasColumnName("MembershipOrganisationTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MembershipOrganisationTypeName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblMembershipPortalAttribute>(entity =>
            {
                entity.HasKey(e => e.MembershipPortalAttributeId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tbl_MembershipPortalAttribute");

                entity.Property(e => e.MembershipPortalAttributeId)
                    .HasColumnName("MembershipPortalAttributeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AttributeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MembershipPortalAttributeTypeId).HasColumnName("MembershipPortalAttributeTypeID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.ValidationError).HasMaxLength(50);

                entity.HasOne(d => d.MembershipPortalAttributeType)
                    .WithMany(p => p.TblMembershipPortalAttribute)
                    .HasForeignKey(d => d.MembershipPortalAttributeTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MemPortalAtt_Reference_MemPortalAttType");
            });

            modelBuilder.Entity<TblMembershipPortalAttributeType>(entity =>
            {
                entity.HasKey(e => e.MembershipPortalAttributeTypeId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tbl_MembershipPortalAttributeType");

                entity.Property(e => e.MembershipPortalAttributeTypeId)
                    .HasColumnName("MembershipPortalAttributeTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AttributeTypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.ValidationExpression).HasMaxLength(255);
            });

            modelBuilder.Entity<TblMembershipPortalAttributeValue>(entity =>
            {
                entity.HasKey(e => new { e.OrganisationId, e.MembershipPortalAttributeId })
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tbl_MembershipPortalAttributeValue");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.MembershipPortalAttributeId).HasColumnName("MembershipPortalAttributeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.MembershipPortalAttribute)
                    .WithMany(p => p.TblMembershipPortalAttributeValue)
                    .HasForeignKey(d => d.MembershipPortalAttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MemPortalAttVal_Reference_MemPortalAtt");

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblMembershipPortalAttributeValue)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblMemPortalAttVal_Reference_tblOrganisation");
            });

            modelBuilder.Entity<TblMembershipProduct>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("tbl_MembershipProduct");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Product)
                    .WithOne(p => p.TblMembershipProduct)
                    .HasForeignKey<TblMembershipProduct>(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblMembershipProduct_Reference_tblProduct");
            });

            modelBuilder.Entity<TblMembershipProductPackageJoin>(entity =>
            {
                entity.HasKey(e => new { e.MembershipProductId, e.PackageId })
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tbl_MembershipProductPackageJoin");

                entity.Property(e => e.MembershipProductId).HasColumnName("MembershipProductID");

                entity.Property(e => e.PackageId).HasColumnName("PackageID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.MembershipProduct)
                    .WithMany(p => p.TblMembershipProductPackageJoin)
                    .HasForeignKey(d => d.MembershipProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MembershipProductPackageJoin_tbl_MembershipProduct");

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.TblMembershipProductPackageJoin)
                    .HasForeignKey(d => d.PackageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MembershipProductPackageJoin_tbl_Package");
            });

            modelBuilder.Entity<TblMembershipPromotion>(entity =>
            {
                entity.HasKey(e => e.MembershipPromotionId);

                entity.ToTable("tbl_MembershipPromotion");

                entity.HasIndex(e => new { e.OrganisationId, e.PromotionCode })
                    .HasName("uc_tbl_MembershipPromotion_OrganisationID_PromotionCode")
                    .IsUnique();

                entity.Property(e => e.MembershipPromotionId).HasColumnName("MembershipPromotionID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MembershipProductId).HasColumnName("MembershipProductID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.PromotionCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                entity.Property(e => e.ValidTo).HasColumnType("datetime");

                entity.HasOne(d => d.MembershipProduct)
                    .WithMany(p => p.TblMembershipPromotion)
                    .HasForeignKey(d => d.MembershipProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MembershipPromotion_Reference_MembershipProductID");

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblMembershipPromotion)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MembershipPromotion_Reference_OrganisationID");
            });

            modelBuilder.Entity<TblMembershipSeat>(entity =>
            {
                entity.HasKey(e => e.MembershipSeatId);

                entity.ToTable("tbl_MembershipSeat");

                entity.Property(e => e.MembershipSeatId).HasColumnName("MembershipSeatID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationCustomerId).HasColumnName("OrganisationCustomerID");

                entity.Property(e => e.RankingFactorId).HasColumnName("RankingFactorID");

                entity.Property(e => e.Row).HasColumnType("nchar(10)");

                entity.Property(e => e.Seat).HasColumnType("nchar(10)");

                entity.Property(e => e.Section).HasColumnType("nchar(12)");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.OrganisationCustomer)
                    .WithMany(p => p.TblMembershipSeat)
                    .HasForeignKey(d => d.OrganisationCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MembershipSeat_tblOrganisationCustomer");

                entity.HasOne(d => d.RankingFactor)
                    .WithMany(p => p.TblMembershipSeat)
                    .HasForeignKey(d => d.RankingFactorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MembershipSeat_tbl_RankingFactor");
            });

            modelBuilder.Entity<TblMembershipTicketGenerationLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("tbl_MembershipTicketGenerationLog");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");

                entity.Property(e => e.TicketTypeId).HasColumnName("TicketTypeID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Subscription)
                    .WithMany(p => p.TblMembershipTicketGenerationLog)
                    .HasForeignKey(d => d.SubscriptionId)
                    .HasConstraintName("FK_MembershipTicketGenerationLog_tbl_Subscription");

                entity.HasOne(d => d.TicketType)
                    .WithMany(p => p.TblMembershipTicketGenerationLog)
                    .HasForeignKey(d => d.TicketTypeId)
                    .HasConstraintName("FK_MembershipTicketGenerationLog_tbl_TicketType");
            });

            modelBuilder.Entity<TblMemGroupMembershipJoin>(entity =>
            {
                entity.HasKey(e => new { e.MembershipGroupId, e.MembershipId })
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tbl_MemGroupMembershipJoin");

                entity.Property(e => e.MembershipGroupId).HasColumnName("MembershipGroupID");

                entity.Property(e => e.MembershipId).HasColumnName("MembershipID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.MembershipGroup)
                    .WithMany(p => p.TblMemGroupMembershipJoin)
                    .HasForeignKey(d => d.MembershipGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblMemGroupMem_Reference_MemGroup");

                entity.HasOne(d => d.Membership)
                    .WithMany(p => p.TblMemGroupMembershipJoin)
                    .HasForeignKey(d => d.MembershipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblMemGroupMem_Reference_Member");
            });

            modelBuilder.Entity<TblMenuItem>(entity =>
            {
                entity.HasKey(e => e.MenuItemId);

                entity.ToTable("tbl_MenuItem");

                entity.HasIndex(e => new { e.MenuItemNumber, e.OrganisationId, e.ApplicationId })
                    .HasName("uc_tbl_MenuItem_MenuItemNumber_OrganisationID_ApplicationID")
                    .IsUnique();

                entity.Property(e => e.MenuItemId).HasColumnName("MenuItemID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DisplayLabel).HasMaxLength(50);

                entity.Property(e => e.ImageUrl)
                    .HasColumnName("ImageURL")
                    .HasMaxLength(500);

                entity.Property(e => e.MenuItemTargetId).HasColumnName("MenuItemTargetID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(500);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.TblMenuItem)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MenuItem_Reference_ApplicationID");

                entity.HasOne(d => d.MenuItemTarget)
                    .WithMany(p => p.TblMenuItem)
                    .HasForeignKey(d => d.MenuItemTargetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MenuItem_Reference_MenuItemTargetID");

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblMenuItem)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MenuItem_Reference_OrganisationID");
            });

            modelBuilder.Entity<TblMenuItemLink>(entity =>
            {
                entity.HasKey(e => e.MenuItemLinkId);

                entity.ToTable("tbl_MenuItemLink");

                entity.HasIndex(e => new { e.MenuItemId, e.OrganisationId, e.ApplicationId, e.MenuGroupName })
                    .HasName("uc_tbl_MenuItemLink_MenuItemID_OrganisationID_ApplicationID")
                    .IsUnique();

                entity.Property(e => e.MenuItemLinkId).HasColumnName("MenuItemLinkID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MenuGroupName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MenuItemId).HasColumnName("MenuItemID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.TblMenuItemLink)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MenuItemLink_Reference_ApplicationID");

                entity.HasOne(d => d.MenuItem)
                    .WithMany(p => p.TblMenuItemLink)
                    .HasForeignKey(d => d.MenuItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MenuItemLink_Reference_MenuItemID");

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblMenuItemLink)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MenuItemLink_Reference_OrganisationID");
            });

            modelBuilder.Entity<TblMenuItemOperation>(entity =>
            {
                entity.HasKey(e => e.MenuItemOperationId);

                entity.ToTable("tbl_MenuItemOperation");

                entity.HasIndex(e => e.MenuItemId)
                    .HasName("NCLIDX_tbl_MenuItemOperation_MenuItemID");

                entity.Property(e => e.MenuItemOperationId).HasColumnName("MenuItemOperationID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MenuItemId).HasColumnName("MenuItemID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OperationId).HasColumnName("OperationID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.MenuItem)
                    .WithMany(p => p.TblMenuItemOperation)
                    .HasForeignKey(d => d.MenuItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MenuItemOperation_Reference_MenuItemID");

                entity.HasOne(d => d.Operation)
                    .WithMany(p => p.TblMenuItemOperation)
                    .HasForeignKey(d => d.OperationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MenuItemOperation_Reference_OperationID");
            });

            modelBuilder.Entity<TblMenuItemTarget>(entity =>
            {
                entity.HasKey(e => e.MenuItemTargetId);

                entity.ToTable("tbl_MenuItemTarget");

                entity.Property(e => e.MenuItemTargetId).HasColumnName("MenuItemTargetID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TargetLocation)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblMerchandise>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("tbl_Merchandise");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Product)
                    .WithOne(p => p.TblMerchandise)
                    .HasForeignKey<TblMerchandise>(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblMerchandise_Reference_tblProduct");
            });

            modelBuilder.Entity<TblNotification>(entity =>
            {
                entity.HasKey(e => e.NotificationId);

                entity.ToTable("tbl_Notification");

                entity.Property(e => e.NotificationId).HasColumnName("NotificationID");

                entity.Property(e => e.ArchiveDate).HasColumnType("datetime");

                entity.Property(e => e.AssignedId).HasColumnName("AssignedID");

                entity.Property(e => e.CopiedFromNotificationId).HasColumnName("CopiedFromNotificationID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OwnerId).HasColumnName("OwnerID");

                entity.Property(e => e.ShowVenueId).HasColumnName("ShowVenueID");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.ShowVenue)
                    .WithMany(p => p.TblNotification)
                    .HasForeignKey(d => d.ShowVenueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_Notification_Ref_tbl_ShowVenue_ShowVenueID");
            });

            modelBuilder.Entity<TblNotificationBuild>(entity =>
            {
                entity.HasKey(e => e.NotificationBuildId);

                entity.ToTable("tbl_NotificationBuild");

                entity.Property(e => e.NotificationBuildId).HasColumnName("NotificationBuildID");

                entity.Property(e => e.BuildTypeId).HasColumnName("BuildTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NotificationId).HasColumnName("NotificationID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.BuildType)
                    .WithMany(p => p.TblNotificationBuild)
                    .HasForeignKey(d => d.BuildTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_NotificationBuild_Ref_tbl_BuildType");

                entity.HasOne(d => d.Notification)
                    .WithMany(p => p.TblNotificationBuild)
                    .HasForeignKey(d => d.NotificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_NotificationBuild_Ref_tbl_Notification");
            });

            modelBuilder.Entity<TblNotificationBuildResult>(entity =>
            {
                entity.HasKey(e => e.NotificationBuildResultId);

                entity.ToTable("tbl_NotificationBuildResult");

                entity.Property(e => e.NotificationBuildResultId).HasColumnName("NotificationBuildResultID");

                entity.Property(e => e.BuildMessageId).HasColumnName("BuildMessageID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ErrorMessage).HasMaxLength(2000);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NotificationBuildId).HasColumnName("NotificationBuildID");

                entity.Property(e => e.ShowTagId).HasColumnName("ShowTagID");

                entity.Property(e => e.ShowVenuePerformanceId).HasColumnName("ShowVenuePerformanceID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.BuildMessage)
                    .WithMany(p => p.TblNotificationBuildResult)
                    .HasForeignKey(d => d.BuildMessageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_NotificationBuildResult_Ref_tbl_BuildMessage");

                entity.HasOne(d => d.NotificationBuild)
                    .WithMany(p => p.TblNotificationBuildResult)
                    .HasForeignKey(d => d.NotificationBuildId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_NotificationBuildResult_Ref_tbl_NotificationBuild");
            });

            modelBuilder.Entity<TblNotificationPart>(entity =>
            {
                entity.HasKey(e => e.PartId);

                entity.ToTable("tbl_NotificationPart");

                entity.Property(e => e.PartId).HasColumnName("PartID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NotificationId).HasColumnName("NotificationID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Notification)
                    .WithMany(p => p.TblNotificationPart)
                    .HasForeignKey(d => d.NotificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_NotificationPart_tbl_Notification");
            });

            modelBuilder.Entity<TblOnSaleTime>(entity =>
            {
                entity.HasKey(e => e.OnSaleTimeId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tbl_OnSaleTime");

                entity.Property(e => e.OnSaleTimeId).HasColumnName("OnSaleTimeID");

                entity.Property(e => e.Additive).HasMaxLength(1);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasMaxLength(8);

                entity.Property(e => e.EndTime).HasMaxLength(5);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SalesChannelId).HasColumnName("SalesChannelID");

                entity.Property(e => e.SellerCode).HasMaxLength(6);

                entity.Property(e => e.ShowVenueId).HasColumnName("ShowVenueID");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.SalesChannel)
                    .WithMany(p => p.TblOnSaleTime)
                    .HasForeignKey(d => d.SalesChannelId)
                    .HasConstraintName("FK_tbl_OnSaleTime_tbl_SalesChannel");

                entity.HasOne(d => d.ShowVenue)
                    .WithMany(p => p.TblOnSaleTime)
                    .HasForeignKey(d => d.ShowVenueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_OnSaleTime_tbl_ShowVenue");
            });

            modelBuilder.Entity<TblOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblOrder");

                entity.HasIndex(e => e.CustomerId)
                    .ForSqlServerIsClustered();

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Channel).HasMaxLength(1);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderJournalDate).HasColumnType("datetime");

                entity.Property(e => e.SellerId)
                    .HasColumnName("SellerID")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblOrder)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("tblCustomer_tblOrder");

                entity.HasOne(d => d.Order)
                    .WithOne(p => p.TblOrder)
                    .HasForeignKey<TblOrder>(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblOrder_tblOriginOrderMap");
            });

            modelBuilder.Entity<TblOrder1>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("tbl_Order");

                entity.HasIndex(e => e.OrderStatusId)
                    .HasName("NCINDEX_tbl_Order_OrderStatusID");

                entity.HasIndex(e => new { e.OrderId, e.OrganisationId })
                    .HasName("NCINDEX_tbl_Order_OrganisationID_inc_OrderID");

                entity.HasIndex(e => new { e.OrderId, e.OrganisationCustomerId, e.OrderJournalDate })
                    .HasName("NCINDEX_tbl_Order_OrderJournalDate_inc_OrderID_OrganisationCustomerID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Channel)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FailedPaymentDate).HasColumnType("datetime");

                entity.Property(e => e.FailedPaymentRequestProcessedDate).HasColumnType("datetime");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderJournalDate).HasColumnType("datetime");

                entity.Property(e => e.OrderReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderStatusId).HasColumnName("OrderStatusID");

                entity.Property(e => e.OrganisationCustomerId).HasColumnName("OrganisationCustomerID");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.OriginErrorAdvice).HasMaxLength(255);

                entity.Property(e => e.OriginErrorKey).HasMaxLength(255);

                entity.Property(e => e.RequestProcessedDate).HasColumnType("datetime");

                entity.Property(e => e.SellerId)
                    .HasColumnName("SellerID")
                    .HasMaxLength(50);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.OrganisationCustomer)
                    .WithMany(p => p.TblOrder1)
                    .HasForeignKey(d => d.OrganisationCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblOrder_Reference_tblOrganisationCustomer");
            });

            modelBuilder.Entity<TblOrderBaseClassification>(entity =>
            {
                entity.HasKey(e => e.OrderBaseClassificationId);

                entity.ToTable("tbl_OrderBaseClassification");

                entity.Property(e => e.OrderBaseClassificationId).HasColumnName("OrderBaseClassificationID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderClassificationName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblOrderBaseClassificationGroup>(entity =>
            {
                entity.HasKey(e => e.OrderBaseClassificationGroupId);

                entity.ToTable("tbl_OrderBaseClassificationGroup");

                entity.Property(e => e.OrderBaseClassificationGroupId).HasColumnName("OrderBaseClassificationGroupID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MembershipProductId).HasColumnName("MembershipProductID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderBaseClassificationId).HasColumnName("OrderBaseClassificationID");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.MembershipProduct)
                    .WithMany(p => p.TblOrderBaseClassificationGroup)
                    .HasForeignKey(d => d.MembershipProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_OrderBaseClassificationGroup_Reference_tbl_MembershipProduct");

                entity.HasOne(d => d.OrderBaseClassification)
                    .WithMany(p => p.TblOrderBaseClassificationGroup)
                    .HasForeignKey(d => d.OrderBaseClassificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_OrderBaseClassificationGroup_Reference_tbl_OrderBaseClassification");

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblOrderBaseClassificationGroup)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_OrderBaseClassificationGroup_Reference_tblOrganisation");
            });

            modelBuilder.Entity<TblOrderClassification>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("tbl_OrderClassification");

                entity.HasIndex(e => new { e.OrderId, e.OrderBaseClassificationId, e.OrganisationId })
                    .HasName("NCINDEX_tbl_OrderClassification_OrganisationID_inc_OrderID_OrderBaseClassificationID");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderBaseClassificationId).HasColumnName("OrderBaseClassificationID");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.OrderBaseClassification)
                    .WithMany(p => p.TblOrderClassification)
                    .HasForeignKey(d => d.OrderBaseClassificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_OrderClassification_tbl_OrderBaseClassification");

                entity.HasOne(d => d.Order)
                    .WithOne(p => p.TblOrderClassification)
                    .HasForeignKey<TblOrderClassification>(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_OrderClassification_tbl_Order");

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblOrderClassification)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_OrderClassification_tblOrganisation");
            });

            modelBuilder.Entity<TblOrderDelegation>(entity =>
            {
                entity.HasKey(e => new { e.OrderMemberId, e.DelegatingMembershipId })
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tbl_OrderDelegation");

                entity.Property(e => e.OrderMemberId).HasColumnName("OrderMemberID");

                entity.Property(e => e.DelegatingMembershipId).HasColumnName("DelegatingMembershipID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.DelegatingMembership)
                    .WithMany(p => p.TblOrderDelegation)
                    .HasForeignKey(d => d.DelegatingMembershipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDelegation_Reference_tblMembership2");

                entity.HasOne(d => d.OrderMember)
                    .WithMany(p => p.TblOrderDelegation)
                    .HasForeignKey(d => d.OrderMemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDelegation_Reference_tblMembership");
            });

            modelBuilder.Entity<TblOrderDeletion>(entity =>
            {
                entity.HasKey(e => e.OrderDeletionId);

                entity.ToTable("tbl_OrderDeletion");

                entity.Property(e => e.OrderDeletionId).HasColumnName("OrderDeletionID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OrderLineId).HasColumnName("OrderLineID");

                entity.Property(e => e.OrderXml)
                    .HasColumnName("OrderXML")
                    .HasColumnType("xml");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.RequestProcessedDate).HasColumnType("datetime");

                entity.Property(e => e.SeasonId).HasColumnName("SeasonID");

                entity.Property(e => e.SubscriptionAllocationId).HasColumnName("SubscriptionAllocationID");

                entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblOrderDeletion)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrganisationID_REF_tblOrganisation");

                entity.HasOne(d => d.Season)
                    .WithMany(p => p.TblOrderDeletion)
                    .HasForeignKey(d => d.SeasonId)
                    .HasConstraintName("FK_SeasonID_REF_tbl_season");
            });

            modelBuilder.Entity<TblOrderFulfillmentMethod>(entity =>
            {
                entity.HasKey(e => e.OrderFulfilmentMethodId);

                entity.ToTable("tbl_OrderFulfillmentMethod");

                entity.Property(e => e.OrderFulfilmentMethodId)
                    .HasColumnName("OrderFulfilmentMethodID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderFulfilmentMethodName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblOrderGuestInfo>(entity =>
            {
                entity.HasKey(e => e.OrderLineId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tbl_OrderGuestInfo");

                entity.Property(e => e.OrderLineId)
                    .HasColumnName("OrderLineID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.OrderLine)
                    .WithOne(p => p.TblOrderGuestInfo)
                    .HasForeignKey<TblOrderGuestInfo>(d => d.OrderLineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblOrderGuestInfo_Reference_tblOrderLine");
            });

            modelBuilder.Entity<TblOrderItemStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("tbl_OrderItemStatus");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StatusName).HasMaxLength(20);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblOrderLine>(entity =>
            {
                entity.HasKey(e => e.OrderLineId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tbl_OrderLine");

                entity.HasIndex(e => e.FulfilmentStatus)
                    .HasName("NCINDEX_tbl_OrderLine_FulfilmentStatus");

                entity.HasIndex(e => e.OrderId)
                    .HasName("IC_tbl_OrderLine_OrderID");

                entity.HasIndex(e => e.OrderLineId)
                    .HasName("NCINDEX_tbl_Orderline_OrderlineID");

                entity.HasIndex(e => e.OrderLineStatusId)
                    .HasName("NCINDEX_tbl_Orderline_OrderlineStatusID");

                entity.HasIndex(e => e.OrganisationCustomerId)
                    .HasName("NCLIDX_tbl_OrderLine_OrganisationCustomerID");

                entity.HasIndex(e => e.ParentOrderLineId)
                    .HasName("NCINDEX_tbl_OrderLine_ParentOrderLineID");

                entity.HasIndex(e => e.PriceTypeId)
                    .HasName("NCLIDX_tbl_OrderLine_PriceTypeID");

                entity.HasIndex(e => e.ProductCategoryId)
                    .HasName("NCLIDX_tbl_OrderLine_ProductCategoryID");

                entity.HasIndex(e => e.ProductId)
                    .HasName("NCLIDX_tbl_OrderLine_ProductID");

                entity.HasIndex(e => e.ProductStatus)
                    .HasName("NCINDEX_tbl_OrderLine_ProductStatus");

                entity.HasIndex(e => e.SeatingGroupId)
                    .HasName("NCINDEX_tbl_OrderLine_SeatingGroupID");

                entity.HasIndex(e => new { e.MembershipId, e.ProductId })
                    .HasName("NCINDEX_tbl_OrderLine_MembershipID_ProductID");

                entity.HasIndex(e => new { e.OrderLineId, e.SeatingGroupId })
                    .HasName("NCLIDX_tbl_OrderLine_OrderLineID_SeatingGroupID");

                entity.HasIndex(e => new { e.OrderId, e.OrderLineId, e.PartPrepayStatus })
                    .HasName("NCINDEX_tbl_Orderline_OrderID_OrderlineID_PartPrepayStatus");

                entity.HasIndex(e => new { e.OrderId, e.OrderLineId, e.PaymentStatus })
                    .HasName("NCINDEX_tbl_Orderline_PaymentStatus_INC_OrderID_OrderlineID");

                entity.HasIndex(e => new { e.OrderId, e.ProductId, e.PaymentStatus })
                    .HasName("NCINDEX_tbl_OrderLine_PaymentStatus_inc_OrderID_ProductID");

                entity.HasIndex(e => new { e.OrderLineId, e.ParentOrderLineId, e.ProductSelectionId })
                    .HasName("NCINDEX_tbl_OrderLine_ProductSelectionID_inc_OrderLineID_ParentOrderLineID");

                entity.HasIndex(e => new { e.UnitQuantity, e.Price, e.OrderLineId, e.OrderId })
                    .HasName("NCINDEX_tbl_OrderLine_OrderLineID_OrderID_INC_UnitQuantity_Price");

                entity.HasIndex(e => new { e.OrderId, e.OrderLineId, e.IsPartPaid, e.ProductId, e.OrderLineStatusId })
                    .HasName("NCINDEX_tbl_Orderline_IsPartPaid_ProductID_OrderlineStatusID_INC_OrderID_OrderlineID");

                entity.HasIndex(e => new { e.OrderId, e.OrderLineId, e.UmbrellaOrderLineId, e.ProductId, e.OrderLineStatusId })
                    .HasName("NCINDEX_tbl_Orderline_OrderID_OrderlineID_UmbrellaOrderlineID_ProductID_OrderlineStatusID");

                entity.HasIndex(e => new { e.OrderId, e.MembershipId, e.UnitQuantity, e.FulFillmentQuantity, e.IsGuest, e.FulfilmentStatus, e.ProductId })
                    .HasName("NCINDEX_tbl_OrderLine_ProductID_inc_2_4_10_12_14_20");

                entity.HasIndex(e => new { e.OrderLineId, e.OrderId, e.OrganisationCustomerId, e.ProductCategoryId, e.UnitQuantity, e.FulfilmentStatus, e.ProductId })
                    .HasName("NCINDEX_tbl_OrderLine_ProductID_INC_OrderLineID_OrderID_OrganisationCustomerID_ProductCategoryID_UnitQuantity_FulfilmentStatus");

                entity.HasIndex(e => new { e.OrderId, e.OrderLineId, e.PaymentStatus, e.OrganisationCustomerId, e.ProductId, e.ProductCategoryId, e.PriceTypeId, e.SeatingGroupId, e.OrderLineStatusId })
                    .HasName("NCINDEX_tbl_Orderline_Multi1");

                entity.Property(e => e.OrderLineId).HasColumnName("OrderLineID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MembershipId).HasColumnName("MembershipID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OrderLineStatusId).HasColumnName("OrderLineStatusID");

                entity.Property(e => e.OrganisationCustomerId).HasColumnName("OrganisationCustomerID");

                entity.Property(e => e.OrganisationCustomerOwnerId).HasColumnName("OrganisationCustomerOwnerID");

                entity.Property(e => e.ParentOrderLineId).HasColumnName("ParentOrderLineID");

                entity.Property(e => e.ParentPriceTypeId).HasColumnName("ParentPriceTypeID");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.PriceTypeId).HasColumnName("PriceTypeID");

                entity.Property(e => e.ProductCategoryId).HasColumnName("ProductCategoryID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductSelectionId).HasColumnName("ProductSelectionID");

                entity.Property(e => e.SeatingGroupId).HasColumnName("SeatingGroupID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.UmbrellaOrderLineId).HasColumnName("UmbrellaOrderLineID");

                entity.HasOne(d => d.Membership)
                    .WithMany(p => p.TblOrderLine)
                    .HasForeignKey(d => d.MembershipId)
                    .HasConstraintName("FK_tblOrderLine_Reference_tblMembership");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TblOrderLine)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblOrderLine_Reference_tblOrder");

                entity.HasOne(d => d.OrganisationCustomer)
                    .WithMany(p => p.TblOrderLine)
                    .HasForeignKey(d => d.OrganisationCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblOrderLine_Reference_tblOrganisationCustomer");

                entity.HasOne(d => d.ParentOrderLine)
                    .WithMany(p => p.InverseParentOrderLine)
                    .HasForeignKey(d => d.ParentOrderLineId)
                    .HasConstraintName("FK_tbl_OrderLine_tbl_OrderLine");

                entity.HasOne(d => d.ParentPriceType)
                    .WithMany(p => p.TblOrderLineParentPriceType)
                    .HasForeignKey(d => d.ParentPriceTypeId)
                    .HasConstraintName("FK_tbl_OrderLine_tbl_PriceType1");

                entity.HasOne(d => d.PriceType)
                    .WithMany(p => p.TblOrderLinePriceType)
                    .HasForeignKey(d => d.PriceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_OrderLine_tbl_PriceType");

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.TblOrderLine)
                    .HasForeignKey(d => d.ProductCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblOrderLine_Reference_tblProductCat");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblOrderLine)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblOrderLine_Reference_tblProduct");

                entity.HasOne(d => d.ProductSelection)
                    .WithMany(p => p.TblOrderLine)
                    .HasForeignKey(d => d.ProductSelectionId)
                    .HasConstraintName("FK_tblOrderLine_Reference_tblProductSel");

                entity.HasOne(d => d.SeatingGroup)
                    .WithMany(p => p.TblOrderLine)
                    .HasForeignKey(d => d.SeatingGroupId)
                    .HasConstraintName("FK_tbl_OrderLine_Reference_tbl_SeatingGroup_SeatingGroupID");

                entity.HasOne(d => d.UmbrellaOrderLine)
                    .WithMany(p => p.InverseUmbrellaOrderLine)
                    .HasForeignKey(d => d.UmbrellaOrderLineId)
                    .HasConstraintName("FK_tbl_OrderLine_tbl_OrderLine_Umbrella");
            });

            modelBuilder.Entity<TblOrderLineAllocation>(entity =>
            {
                entity.HasKey(e => new { e.OrderLineId, e.TransactionDate, e.TransactionTnum });

                entity.ToTable("tbl_OrderLineAllocation");

                entity.Property(e => e.OrderLineId).HasColumnName("OrderLineID");

                entity.Property(e => e.TransactionTnum).HasColumnName("TransactionTNum");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Row).HasMaxLength(5);

                entity.Property(e => e.SeatSpan).HasMaxLength(11);

                entity.Property(e => e.Section).HasMaxLength(12);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.OrderLine)
                    .WithMany(p => p.TblOrderLineAllocation)
                    .HasForeignKey(d => d.OrderLineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_OrderLineAllocation_Reference_tblOrderLine");
            });

            modelBuilder.Entity<TblOrderLineAttribute>(entity =>
            {
                entity.HasKey(e => e.AttributeId);

                entity.ToTable("tbl_OrderLineAttribute");

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.AttributeDataTypeId).HasColumnName("AttributeDataTypeID");

                entity.Property(e => e.CommonAttributeId).HasColumnName("CommonAttributeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DisplayLabel)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Locale)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.ValidationError).HasMaxLength(50);

                entity.Property(e => e.ValidationText).HasMaxLength(100);

                entity.HasOne(d => d.AttributeDataType)
                    .WithMany(p => p.TblOrderLineAttribute)
                    .HasForeignKey(d => d.AttributeDataTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblRefAttributeDataType_tbl_OrderLineAttribute_FK1");

                entity.HasOne(d => d.CommonAttribute)
                    .WithMany(p => p.TblOrderLineAttribute)
                    .HasForeignKey(d => d.CommonAttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_OrderLineAttribute_tbl_OrderLineAttributeType_FK1");

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblOrderLineAttribute)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbLOrderLineAttribute_tblOrganisation");
            });

            modelBuilder.Entity<TblOrderLineAttributeValue>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("tbl_OrderLineAttributeValue");

                entity.HasIndex(e => e.OrderLineId)
                    .HasName("NCINDEX_tbl_OrderLineAttributeValue_OrderLineID");

                entity.HasIndex(e => new { e.AttributeId, e.OrderLineId })
                    .HasName("uc_OrderLineID_AttributeID")
                    .IsUnique();

                entity.HasIndex(e => new { e.AttributeId, e.ChoiceId, e.AttributeValue, e.OrderLineId })
                    .HasName("NCINDEX_tbl_OrderLineAttributeValue_OrderLineID_inc_AttributeID_ChoiceID_AttributeValue");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.AttributeDataTypeId).HasColumnName("AttributeDataTypeID");

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.AttributeValue).HasMaxLength(200);

                entity.Property(e => e.ChoiceId).HasColumnName("ChoiceID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderLineId).HasColumnName("OrderLineID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.TblOrderLineAttributeValue)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("tblAddress_tbl_OrderLineAttributeValue_FK1");

                entity.HasOne(d => d.AttributeDataType)
                    .WithMany(p => p.TblOrderLineAttributeValue)
                    .HasForeignKey(d => d.AttributeDataTypeId)
                    .HasConstraintName("tblRefAttributeDataType_tbl_OrderLineAttributeValue_FK1");

                entity.HasOne(d => d.Attribute)
                    .WithMany(p => p.TblOrderLineAttributeValue)
                    .HasForeignKey(d => d.AttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_OrderLineAttribute_tbl_OrderLineAttributeValue_FK1");

                entity.HasOne(d => d.Choice)
                    .WithMany(p => p.TblOrderLineAttributeValue)
                    .HasForeignKey(d => d.ChoiceId)
                    .HasConstraintName("tbl_OrderLineChoiceAttribute_tbl_OrderLineAttributeValue_FK1");

                entity.HasOne(d => d.OrderLine)
                    .WithMany(p => p.TblOrderLineAttributeValue)
                    .HasForeignKey(d => d.OrderLineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_OrderLineCustomer_tbl_OrderLineAttributeValue_FK1");
            });

            modelBuilder.Entity<TblOrderLineChoiceAttribute>(entity =>
            {
                entity.HasKey(e => e.ChoiceId);

                entity.ToTable("tbl_OrderLineChoiceAttribute");

                entity.Property(e => e.ChoiceId).HasColumnName("ChoiceID");

                entity.Property(e => e.ChoiceLabel).HasMaxLength(100);

                entity.Property(e => e.CommonAttributeId).HasColumnName("CommonAttributeID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.CommonAttribute)
                    .WithMany(p => p.TblOrderLineChoiceAttribute)
                    .HasForeignKey(d => d.CommonAttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_OrderLineCommonAttribute_tbl_OrderLineChoiceAttribute_FK1");
            });

            modelBuilder.Entity<TblOrderlineClassification>(entity =>
            {
                entity.HasKey(e => e.OrderlineId);

                entity.ToTable("tbl_OrderlineClassification");

                entity.Property(e => e.OrderlineId)
                    .HasColumnName("OrderlineID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderBaseClassificationId).HasColumnName("OrderBaseClassificationID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.OrderBaseClassification)
                    .WithMany(p => p.TblOrderlineClassification)
                    .HasForeignKey(d => d.OrderBaseClassificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_OrderlineClassification_tbl_OrderBaseClassification");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TblOrderlineClassification)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_OrderlineClassification_tbl_Order");

                entity.HasOne(d => d.Orderline)
                    .WithOne(p => p.TblOrderlineClassification)
                    .HasForeignKey<TblOrderlineClassification>(d => d.OrderlineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_OrderlineClassification_tbl_OrderLine");

                entity.HasOne(d => d.OrderlineNavigation)
                    .WithOne(p => p.InverseOrderlineNavigation)
                    .HasForeignKey<TblOrderlineClassification>(d => d.OrderlineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_OrderlineClassification_tbl_OrderlineClassification");

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblOrderlineClassification)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_OrderlineClassification_tblOrganisation");
            });

            modelBuilder.Entity<TblOrderLineCommonAttribute>(entity =>
            {
                entity.HasKey(e => e.CommonAttributeId);

                entity.ToTable("tbl_OrderLineCommonAttribute");

                entity.HasIndex(e => e.AttributeName)
                    .HasName("uc_tbl_OrderLineCommonAttribute_AttributeName")
                    .IsUnique();

                entity.Property(e => e.CommonAttributeId).HasColumnName("CommonAttributeID");

                entity.Property(e => e.AddressTypeId).HasColumnName("AddressTypeID");

                entity.Property(e => e.AttributeDataTypeId).HasColumnName("AttributeDataTypeID");

                entity.Property(e => e.AttributeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DisplayLabel).HasMaxLength(50);

                entity.Property(e => e.Locale).HasMaxLength(10);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.AddressType)
                    .WithMany(p => p.TblOrderLineCommonAttribute)
                    .HasForeignKey(d => d.AddressTypeId)
                    .HasConstraintName("tblRefAddressType_tbl_OrderLineCommonAttribute_FK1");

                entity.HasOne(d => d.AttributeDataType)
                    .WithMany(p => p.TblOrderLineCommonAttribute)
                    .HasForeignKey(d => d.AttributeDataTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblRefAttributeDataType_tbl_OrderLineCommonAttribute_FK1");
            });

            modelBuilder.Entity<TblOrderLineMemberShopItem>(entity =>
            {
                entity.HasKey(e => e.OrderLineMemberShopItemId);

                entity.ToTable("tbl_OrderLineMemberShopItem");

                entity.Property(e => e.OrderLineMemberShopItemId).HasColumnName("OrderLineMemberShopItemID");

                entity.Property(e => e.ColorId).HasColumnName("ColorID");

                entity.Property(e => e.CustomFieldId).HasColumnName("CustomFieldID");

                entity.Property(e => e.CustomizedText).HasMaxLength(100);

                entity.Property(e => e.ExtraCustomFieldId).HasColumnName("ExtraCustomFieldID");

                entity.Property(e => e.FullfillDate).HasColumnType("datetime");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OrderLineId).HasColumnName("OrderLineID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.SizeId).HasColumnName("SizeID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TblOrderLineMemberShopItem)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MemberShopItemSale_tbl_Order");

                entity.HasOne(d => d.OrderLine)
                    .WithMany(p => p.TblOrderLineMemberShopItem)
                    .HasForeignKey(d => d.OrderLineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MemberShopItemSale_tbl_OrderLine");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblOrderLineMemberShopItem)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_OrderLineMemberShopItem_tbl_Product");
            });

            modelBuilder.Entity<TblOrderLinePaymentHistory>(entity =>
            {
                entity.HasKey(e => e.OrderLinePaymentHistoryId);

                entity.ToTable("tbl_OrderLinePaymentHistory");

                entity.HasIndex(e => e.OrderPaymentHistoryId)
                    .HasName("NCLIDX_tbl_OrderLinePaymentHistory_OrderPaymentHistoryID");

                entity.HasIndex(e => new { e.Amount, e.OrderLineId })
                    .HasName("NCINDEX_tbl_OrderLinePaymentHistory_OrderLineID_INC_Amount");

                entity.Property(e => e.OrderLinePaymentHistoryId).HasColumnName("OrderLinePaymentHistoryID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.AuthCode).HasColumnType("nchar(10)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EventCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExtCcfee)
                    .HasColumnName("ExtCCFee")
                    .HasColumnType("money");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderLineId).HasColumnName("OrderLineID");

                entity.Property(e => e.OrderPaymentHistoryId).HasColumnName("OrderPaymentHistoryID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.OrderLine)
                    .WithMany(p => p.TblOrderLinePaymentHistory)
                    .HasForeignKey(d => d.OrderLineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_OrderLinePaymentHistory_Reference_tbl_OrderLine");

                entity.HasOne(d => d.OrderPaymentHistory)
                    .WithMany(p => p.TblOrderLinePaymentHistory)
                    .HasForeignKey(d => d.OrderPaymentHistoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_OrderLinePaymentHistory_Reference_tbl_OrderPaymentHistory");
            });

            modelBuilder.Entity<TblOrderLineVenuePrefJoin>(entity =>
            {
                entity.HasKey(e => new { e.OrderLineId, e.VenueId });

                entity.ToTable("tbl_OrderLineVenuePrefJoin");

                entity.Property(e => e.OrderLineId).HasColumnName("OrderLineID");

                entity.Property(e => e.VenueId).HasColumnName("VenueID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SeatingPreferenceId).HasColumnName("SeatingPreferenceID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.OrderLine)
                    .WithMany(p => p.TblOrderLineVenuePrefJoin)
                    .HasForeignKey(d => d.OrderLineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_OrderLineSeatingPreferenceJoin_tbl_OrderLine");

                entity.HasOne(d => d.SeatingPreference)
                    .WithMany(p => p.TblOrderLineVenuePrefJoin)
                    .HasForeignKey(d => d.SeatingPreferenceId)
                    .HasConstraintName("FK_tbl_OrderLineSeatingPreferenceJoin_tbl_SeatingPreference");

                entity.HasOne(d => d.Venue)
                    .WithMany(p => p.TblOrderLineVenuePrefJoin)
                    .HasForeignKey(d => d.VenueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_OrderLineSeatingPreferenceJoin_tbl_Venue");
            });

            modelBuilder.Entity<TblOrderPaymentDetail>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("tbl_OrderPaymentDetail");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentNumber).HasMaxLength(50);

                entity.Property(e => e.PaymentReference).HasMaxLength(50);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Order)
                    .WithOne(p => p.TblOrderPaymentDetail)
                    .HasForeignKey<TblOrderPaymentDetail>(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_OrderPaymentDetail_OrderID");
            });

            modelBuilder.Entity<TblOrderPaymentHistory>(entity =>
            {
                entity.HasKey(e => e.OrderPaymentHistoryId);

                entity.ToTable("tbl_OrderPaymentHistory");

                entity.HasIndex(e => new { e.CreatedDate, e.PaymentMethodId })
                    .HasName("NCLIDX_tbl_OrderPaymentHistory_CreatedDate");

                entity.HasIndex(e => new { e.OrderId, e.PaymentMethodId })
                    .HasName("NCINDEX_tbl_OrderPaymentHistory_OrderID_PaymentMethodID");

                entity.HasIndex(e => new { e.PaymentMethodId, e.CreatedDate })
                    .HasName("NCLIDX_tbl_OrderPaymentHistory_PaymentMethodID");

                entity.Property(e => e.OrderPaymentHistoryId).HasColumnName("OrderPaymentHistoryID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExtCcfee)
                    .HasColumnName("ExtCCFee")
                    .HasColumnType("money");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PaymentMethodId).HasColumnName("PaymentMethodID");

                entity.Property(e => e.PaymentMethodReference).HasMaxLength(50);

                entity.Property(e => e.PaymentRunNumber).HasMaxLength(200);

                entity.Property(e => e.RequestProcessedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TblOrderPaymentHistory)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_OrderPaymentHistory_Reference_tbl_Order");

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.TblOrderPaymentHistory)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_OrderPaymentHistory_Reference_tbl_PaymentMethod");
            });

            modelBuilder.Entity<TblOrderProcessType>(entity =>
            {
                entity.HasKey(e => e.OrderProcessTypeId);

                entity.ToTable("tbl_OrderProcessType");

                entity.Property(e => e.OrderProcessTypeId)
                    .HasColumnName("OrderProcessTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderProcessTypeName).HasMaxLength(50);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblOrderRolloverAudit>(entity =>
            {
                entity.ToTable("tbl_OrderRolloverAudit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.RunId).HasColumnName("RunID");

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblOrderRolloverAudit)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_OrderRolloverAudit_Reference_tblOrganisation");
            });

            modelBuilder.Entity<TblOrderSalesChannel>(entity =>
            {
                entity.HasKey(e => e.OrderSalesChannelId);

                entity.ToTable("tbl_OrderSalesChannel");

                entity.Property(e => e.OrderSalesChannelId)
                    .HasColumnName("OrderSalesChannelID")
                    .HasColumnType("char(3)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("nchar(30)");
            });

            modelBuilder.Entity<TblOrderSubscriptionInfo>(entity =>
            {
                entity.HasKey(e => new { e.SubscriptionId, e.RenewSubscriptionAllocationId })
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tbl_OrderSubscriptionInfo");

                entity.HasIndex(e => e.ChangeFlag)
                    .HasName("NCINDEX_tbl_OrderSubscriptionInfo_ChangeFlag");

                entity.HasIndex(e => e.RenewSubscriptionAllocationId)
                    .HasName("NCLIDX_tbl_OrderSubscriptionInfo_RenewSubscriptionAllocationID");

                entity.HasIndex(e => new { e.RenewSubscriptionAllocationId, e.ChangeFlag })
                    .HasName("NCINDEX_tbl_OrderSubscriptionInfo_RenewSubscriptionAllocationID_ChangeFlag");

                entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");

                entity.Property(e => e.RenewSubscriptionAllocationId).HasColumnName("RenewSubscriptionAllocationID");

                entity.Property(e => e.AllocationException).HasMaxLength(1000);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.RenewSubscriptionAllocation)
                    .WithMany(p => p.TblOrderSubscriptionInfo)
                    .HasForeignKey(d => d.RenewSubscriptionAllocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderSubscriptionInfo_Reference_SubscriptionAllocation");

                entity.HasOne(d => d.Subscription)
                    .WithMany(p => p.TblOrderSubscriptionInfo)
                    .HasForeignKey(d => d.SubscriptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_OrderSubscriptionInfo_SubscriptionID");
            });

            modelBuilder.Entity<TblOrganisation>(entity =>
            {
                entity.HasKey(e => e.OrganisationId);

                entity.ToTable("tblOrganisation");

                entity.HasIndex(e => e.OrganisationName)
                    .HasName("uc_tblOrganisation_OrganisationName")
                    .IsUnique();

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.BusinessId).HasColumnName("BusinessID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerListId).HasColumnName("CustomerListID");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationCode).HasMaxLength(15);

                entity.Property(e => e.OrganisationName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblOrganisationAttribute>(entity =>
            {
                entity.HasKey(e => e.AttributeId);

                entity.ToTable("tblOrganisationAttribute");

                entity.HasIndex(e => new { e.OrganisationId, e.AttributeId })
                    .HasName("IX_OrganisationID_AttributeID")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.AttributeDataTypeId).HasColumnName("AttributeDataTypeID");

                entity.Property(e => e.AttributeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CommonAttributeId).HasColumnName("CommonAttributeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DisplayLabel)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.ValidationError).HasMaxLength(50);

                entity.Property(e => e.ValidationText).HasMaxLength(500);

                entity.HasOne(d => d.AttributeDataType)
                    .WithMany(p => p.TblOrganisationAttribute)
                    .HasForeignKey(d => d.AttributeDataTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblRefAttributeDataType_tblOrganisationAttribute_FK1");

                entity.HasOne(d => d.CommonAttribute)
                    .WithMany(p => p.TblOrganisationAttribute)
                    .HasForeignKey(d => d.CommonAttributeId)
                    .HasConstraintName("tblOrganisationAttribute_tblOrganisationAttributeType_FK1");

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblOrganisationAttribute)
                    .HasForeignKey(d => d.OrganisationId)
                    .HasConstraintName("Organisations_Org Customer Attributes_FK1");
            });

            modelBuilder.Entity<TblOrganisationAttributeValue>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("tblOrganisationAttributeValue");

                entity.HasIndex(e => e.AttributeId);

                entity.HasIndex(e => new { e.OrganisationCustomerId, e.AttributeId })
                    .HasName("uc_OrganisationCustomerID_AttributeID")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.AttributeDataTypeId).HasColumnName("AttributeDataTypeID");

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.ChoiceId).HasColumnName("ChoiceID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateTimeValue).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationCustomerId).HasColumnName("OrganisationCustomerID");

                entity.Property(e => e.TextValue).HasMaxLength(200);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.TblOrganisationAttributeValue)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("tblAddress_tblOrganisationAttributeValue_FK1");

                entity.HasOne(d => d.AttributeDataType)
                    .WithMany(p => p.TblOrganisationAttributeValue)
                    .HasForeignKey(d => d.AttributeDataTypeId)
                    .HasConstraintName("tblRefAttributeDataType_tblOrganisationAttributeValue_FK1");

                entity.HasOne(d => d.Attribute)
                    .WithMany(p => p.TblOrganisationAttributeValue)
                    .HasForeignKey(d => d.AttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblOrganisationAttribute_tblOrganisationAttributeValue_FK1");

                entity.HasOne(d => d.Choice)
                    .WithMany(p => p.TblOrganisationAttributeValue)
                    .HasForeignKey(d => d.ChoiceId)
                    .HasConstraintName("tblOrganisationChoiceAttribute_tblOrganisationAttributeValue_FK1");

                entity.HasOne(d => d.OrganisationCustomer)
                    .WithMany(p => p.TblOrganisationAttributeValue)
                    .HasForeignKey(d => d.OrganisationCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblOrganisationCustomer_tblOrganisationAttributeValue_FK1");
            });

            modelBuilder.Entity<TblOrganisationCardType>(entity =>
            {
                entity.HasKey(e => new { e.OrganisationId, e.CardTypeId });

                entity.ToTable("tbl_OrganisationCardType");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.CardTypeId).HasColumnName("CardTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SortOrder).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.CardType)
                    .WithMany(p => p.TblOrganisationCardType)
                    .HasForeignKey(d => d.CardTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_OrganisationCardType_tbl_CardType");

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblOrganisationCardType)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_OrganisationCardType_tblOrganisation");
            });

            modelBuilder.Entity<TblOrganisationChoiceAttribute>(entity =>
            {
                entity.HasKey(e => e.ChoiceId);

                entity.ToTable("tblOrganisationChoiceAttribute");

                entity.Property(e => e.ChoiceId).HasColumnName("ChoiceID");

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.ChoiceName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CommonAttributeId).HasColumnName("CommonAttributeID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DisplayLabel).HasMaxLength(100);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.CommonAttribute)
                    .WithMany(p => p.TblOrganisationChoiceAttribute)
                    .HasForeignKey(d => d.CommonAttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblOrganisationCommonAttribute_tblOrganisationChoiceAttribute_FK1");
            });

            modelBuilder.Entity<TblOrganisationCommonAttribute>(entity =>
            {
                entity.HasKey(e => e.CommonAttributeId);

                entity.ToTable("tblOrganisationCommonAttribute");

                entity.HasIndex(e => e.AttributeName)
                    .HasName("uc_tblOrganisationCommonAttribute_AttributeName")
                    .IsUnique();

                entity.Property(e => e.CommonAttributeId).HasColumnName("CommonAttributeID");

                entity.Property(e => e.AddressTypeId).HasColumnName("AddressTypeID");

                entity.Property(e => e.AttributeDataTypeId).HasColumnName("AttributeDataTypeID");

                entity.Property(e => e.AttributeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DisplayLabel).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationFeatureId).HasColumnName("OrganisationFeatureID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.AddressType)
                    .WithMany(p => p.TblOrganisationCommonAttribute)
                    .HasForeignKey(d => d.AddressTypeId)
                    .HasConstraintName("tblAddressType_tblOrganisationCommonAttribute_FK1");

                entity.HasOne(d => d.AttributeDataType)
                    .WithMany(p => p.TblOrganisationCommonAttribute)
                    .HasForeignKey(d => d.AttributeDataTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblAttributeDataType_tblOrganisationCommonAttribute_FK1");

                entity.HasOne(d => d.OrganisationFeature)
                    .WithMany(p => p.TblOrganisationCommonAttribute)
                    .HasForeignKey(d => d.OrganisationFeatureId)
                    .HasConstraintName("FK_tblOrganisationCommonAttribute_tblOrganisationFeature");
            });

            modelBuilder.Entity<TblOrganisationCustomer>(entity =>
            {
                entity.HasKey(e => e.OrganisationCustomerId);

                entity.ToTable("tblOrganisationCustomer");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("NCLIDX_tblOrganisationCustomer_CustomerID");

                entity.HasIndex(e => e.OrganisationId)
                    .HasName("idx_OrganisationID");

                entity.HasIndex(e => new { e.CustomerId, e.OrganisationId })
                    .HasName("IX_OrganisationID_CustomerID")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => new { e.CustomerId, e.OrganisationCustomerId, e.OrganisationId })
                    .HasName("NCINDEX_tblOrganisationCustomer_OrganisationID_inc_CustomerID_OrganisationCustomerID");

                entity.HasIndex(e => new { e.OrganisationCustomerId, e.OrganisationId, e.ExternalReferenceId })
                    .HasName("NCINDEX_tblOrganisationCustomer_OrganisationID_ExternalReferenceID_INC_OrganisationCustomerID");

                entity.HasIndex(e => new { e.OrganisationCustomerId, e.OrganisationId, e.MemberNumber })
                    .HasName("NCINDEX_tblOrganisationCustomer_OrganisationID_MemberNumber_INC_OrganisationCustomerID");

                entity.HasIndex(e => new { e.OrganisationCustomerId, e.OrganisationId, e.MemberType })
                    .HasName("NCINDEX_tblOrganisationCustomer_OrganisationID_MemberType_INC_OrganisationCustomerID");

                entity.Property(e => e.OrganisationCustomerId).HasColumnName("OrganisationCustomerID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ExternalReferenceId)
                    .HasColumnName("ExternalReferenceID")
                    .HasMaxLength(100);

                entity.Property(e => e.MemberNumber).HasMaxLength(100);

                entity.Property(e => e.MemberSince).HasColumnType("datetime");

                entity.Property(e => e.MemberType).HasMaxLength(100);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.Tstamp)
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblOrganisationCustomer)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblCustomer_tblOrganisationCustomer_FK1");

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblOrganisationCustomer)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Organisations_Organisation Customers_FK1");
            });

            modelBuilder.Entity<TblOrganisationCustomerActivityRecord>(entity =>
            {
                entity.HasKey(e => e.OrganisationCustomerActivityRecordId);

                entity.ToTable("tblOrganisationCustomerActivityRecord");

                entity.Property(e => e.OrganisationCustomerActivityRecordId).HasColumnName("OrganisationCustomerActivityRecordID");

                entity.Property(e => e.ActivityRecordId).HasColumnName("ActivityRecordID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationCustomerId).HasColumnName("OrganisationCustomerID");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.OrganisationCustomer)
                    .WithMany(p => p.TblOrganisationCustomerActivityRecord)
                    .HasForeignKey(d => d.OrganisationCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblOrganisationCustomerActivityRecord_tblOrganisationCustomer");
            });

            modelBuilder.Entity<TblOrganisationCustomerAttachment>(entity =>
            {
                entity.HasKey(e => e.FileId);

                entity.ToTable("tbl_OrganisationCustomerAttachment");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.AttachmentTypeId).HasColumnName("AttachmentTypeID");

                entity.Property(e => e.ContentType).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FileContent).IsRequired();

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblOrganisationCustomerFeature>(entity =>
            {
                entity.HasKey(e => e.OrganisationCustomerFeatureId);

                entity.ToTable("tblOrganisationCustomerFeature");

                entity.HasIndex(e => new { e.OrganisationFeatureId, e.OrganisationId })
                    .HasName("uq_tblOrganisationCustomerFeature")
                    .IsUnique();

                entity.Property(e => e.OrganisationCustomerFeatureId).HasColumnName("OrganisationCustomerFeatureID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Enabled).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationFeatureId).HasColumnName("OrganisationFeatureID");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.HasOne(d => d.OrganisationFeature)
                    .WithMany(p => p.TblOrganisationCustomerFeature)
                    .HasForeignKey(d => d.OrganisationFeatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblOrganisationCustomerFeature_tblOrganisationFeature");

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblOrganisationCustomerFeature)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblOrganisationCustomerFeature_tblOrganisation");
            });

            modelBuilder.Entity<TblOrganisationCustomerFileJoin>(entity =>
            {
                entity.HasKey(e => e.AttachmentJoinId);

                entity.ToTable("tbl_OrganisationCustomerFileJoin");

                entity.Property(e => e.AttachmentJoinId).HasColumnName("AttachmentJoinID");

                entity.Property(e => e.ActivityRecordJoinId).HasColumnName("ActivityRecordJoinID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.ActivityRecordJoin)
                    .WithMany(p => p.TblOrganisationCustomerFileJoin)
                    .HasForeignKey(d => d.ActivityRecordJoinId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_OrganisationCustomerFileJoin_tbl_ActivityRecordJoin");

                entity.HasOne(d => d.File)
                    .WithMany(p => p.TblOrganisationCustomerFileJoin)
                    .HasForeignKey(d => d.FileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_OrganisationCustomerFileJoin_tbl_OrganisationCustomerAttachment");
            });

            modelBuilder.Entity<TblOrganisationCustomerOrderline>(entity =>
            {
                entity.HasKey(e => e.OrganisationCustomerOrderlineId);

                entity.ToTable("tblOrganisationCustomerOrderline");

                entity.Property(e => e.OrganisationCustomerOrderlineId).HasColumnName("OrganisationCustomerOrderlineID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasColumnName("OrderID")
                    .HasMaxLength(50);

                entity.Property(e => e.OrderlineId)
                    .IsRequired()
                    .HasColumnName("OrderlineID")
                    .HasMaxLength(50);

                entity.Property(e => e.OrganisationCustomerId).HasColumnName("OrganisationCustomerID");

                entity.HasOne(d => d.OrganisationCustomer)
                    .WithMany(p => p.TblOrganisationCustomerOrderline)
                    .HasForeignKey(d => d.OrganisationCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblOrganisationCustomerOrderline_OrganisationCustomerID");
            });

            modelBuilder.Entity<TblOrganisationCustomerOrderlineItem>(entity =>
            {
                entity.HasKey(e => e.OrganisationCustomerOrderlineItemId);

                entity.ToTable("tblOrganisationCustomerOrderlineItem");

                entity.Property(e => e.OrganisationCustomerOrderlineItemId).HasColumnName("OrganisationCustomerOrderlineItemID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasColumnName("OrderID")
                    .HasMaxLength(50);

                entity.Property(e => e.OrderlineId)
                    .IsRequired()
                    .HasColumnName("OrderlineID")
                    .HasMaxLength(50);

                entity.Property(e => e.OrderlineItemId)
                    .IsRequired()
                    .HasColumnName("OrderlineItemID")
                    .HasMaxLength(50);

                entity.Property(e => e.OrganisationCustomerId).HasColumnName("OrganisationCustomerID");

                entity.HasOne(d => d.OrganisationCustomer)
                    .WithMany(p => p.TblOrganisationCustomerOrderlineItem)
                    .HasForeignKey(d => d.OrganisationCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblOrganisationCustomerOrderlineItem_OrganisationCustomerID");
            });

            modelBuilder.Entity<TblOrganisationFeature>(entity =>
            {
                entity.HasKey(e => e.OrganisationFeatureId);

                entity.ToTable("tblOrganisationFeature");

                entity.HasIndex(e => e.Name)
                    .HasName("uq_tblOrganisationFeature")
                    .IsUnique();

                entity.Property(e => e.OrganisationFeatureId).HasColumnName("OrganisationFeatureID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblOrganisationFile>(entity =>
            {
                entity.HasKey(e => e.OrganisationFileId);

                entity.ToTable("tbl_OrganisationFile");

                entity.HasIndex(e => new { e.FileId, e.OrganisationId })
                    .HasName("IX_OrganisationFile_FileID_OrganisationID")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.OrganisationFileId).HasColumnName("OrganisationFileID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationFileTypeId).HasColumnName("OrganisationFileTypeID");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(255);

                entity.HasOne(d => d.File)
                    .WithMany(p => p.TblOrganisationFile)
                    .HasForeignKey(d => d.FileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_OrganisationFile_tbl_File");

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblOrganisationFile)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_OrganisationFile_tblOrganisation");
            });

            modelBuilder.Entity<TblOrganisationPaymentMethod>(entity =>
            {
                entity.HasKey(e => e.OrganisationPaymentId);

                entity.ToTable("tbl_OrganisationPaymentMethod");

                entity.HasIndex(e => new { e.PaymentMethodId, e.OrganisationId })
                    .HasName("IX_OrganisationPaymentMethod_PaymentID_OrganisationID")
                    .IsUnique();

                entity.Property(e => e.OrganisationPaymentId).HasColumnName("OrganisationPaymentID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsUsableByMembers).HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.PaymentMethodId).HasColumnName("PaymentMethodID");

                entity.Property(e => e.SortOrder).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblOrganisationPaymentMethod)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_OrganisationPaymentMethod_tblOrganisation");

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.TblOrganisationPaymentMethod)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_OrganisationPaymentMethod_tbl_PaymentMethod");
            });

            modelBuilder.Entity<TblOriginAccount>(entity =>
            {
                entity.HasKey(e => new { e.AccountNumber, e.Afile });

                entity.ToTable("tblOriginAccount");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("idx_tblOriginAccount_CustomerID");

                entity.HasIndex(e => e.ModifiedDate)
                    .HasName("UNCLIDX_temp_tblOriginAccount_ModifiedDate");

                entity.Property(e => e.Afile)
                    .HasColumnName("AFile")
                    .HasMaxLength(5);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblOriginAccount)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblCustomer_tblOriginAccount_FK1");
            });

            modelBuilder.Entity<TblOriginBillingRecordMap>(entity =>
            {
                entity.HasKey(e => e.BillingId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblOriginBillingRecordMap");

                entity.HasIndex(e => new { e.BillingDate, e.BillingTnum })
                    .HasName("IX_BillingRecordUniqueColumns")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.BillingId).HasColumnName("BillingID");

                entity.Property(e => e.BillingTnum).HasColumnName("BillingTNum");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblOriginInventoryTransactionMap>(entity =>
            {
                entity.HasKey(e => e.InventoryTransactionId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblOriginInventoryTransactionMap");

                entity.HasIndex(e => new { e.InventoryTransactionDate, e.InventoryTransactionTnum })
                    .HasName("IX_tblOriginInventoryTransactionMap_TNum_Date")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.InventoryTransactionId).HasColumnName("InventoryTransactionID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InventoryTransactionTnum).HasColumnName("InventoryTransactionTNum");
            });

            modelBuilder.Entity<TblOriginOrderMap>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblOriginOrderMap");

                entity.HasIndex(e => new { e.BasketLeaderDate, e.BasketLeaderTnum })
                    .HasName("tblOriginOrderMap_UC1")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.BasketLeaderTnum).HasColumnName("BasketLeaderTNum");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblOriginPrintRecordMap>(entity =>
            {
                entity.HasKey(e => e.PrintTransactionId);

                entity.ToTable("tblOriginPrintRecordMap");

                entity.HasIndex(e => new { e.PrintRecordDate, e.PrintRecordTnum })
                    .HasName("tblOriginPrintRecordMap_UC1")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.PrintTransactionId).HasColumnName("PrintTransactionID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.PrintRecordTnum).HasColumnName("PrintRecordTNum");
            });

            modelBuilder.Entity<TblOriginShippingRecordMap>(entity =>
            {
                entity.HasKey(e => e.ShippingRecordId);

                entity.ToTable("tblOriginShippingRecordMap");

                entity.HasIndex(e => new { e.ShippingRecordDate, e.ShippingRecordTnum })
                    .HasName("tblOriginShippingRecordMap_UC1")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.ShippingRecordId).HasColumnName("ShippingRecordID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ShippingRecordTnum).HasColumnName("ShippingRecordTNum");
            });

            modelBuilder.Entity<TblOriginTaxInvoiceMap>(entity =>
            {
                entity.HasKey(e => e.TaxInvoiceId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblOriginTaxInvoiceMap");

                entity.HasIndex(e => new { e.TaxInvoiceDate, e.TaxInvoiceTnum })
                    .HasName("IX_tblOriginTaxInvoiceMap_InvoiceDateUnique")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.TaxInvoiceId).HasColumnName("TaxInvoiceID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.TaxInvoiceTnum).HasColumnName("TaxInvoiceTNum");
            });

            modelBuilder.Entity<TblOwner>(entity =>
            {
                entity.HasKey(e => e.OwnerId);

                entity.ToTable("tbl_Owner");

                entity.Property(e => e.OwnerId).HasColumnName("OwnerID");

                entity.Property(e => e.BusinessName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OwnerName)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblPackage>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("tbl_Package");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EventDate).HasColumnType("datetime");

                entity.Property(e => e.HeroDescription).HasColumnType("ntext");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ShortTextAttribute).HasMaxLength(10);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Product)
                    .WithOne(p => p.TblPackage)
                    .HasForeignKey<TblPackage>(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPkg_Reference_tblProduct");
            });

            modelBuilder.Entity<TblPackageMembershipProductOverride>(entity =>
            {
                entity.HasKey(e => e.MembershipProductOverrideId);

                entity.ToTable("tbl_PackageMembershipProductOverride");

                entity.Property(e => e.MembershipProductOverrideId).HasColumnName("MembershipProductOverrideID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MembershipProductId).HasColumnName("MembershipProductID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.MembershipProduct)
                    .WithMany(p => p.TblPackageMembershipProductOverride)
                    .HasForeignKey(d => d.MembershipProductId)
                    .HasConstraintName("FK_tbl_PackageMembershipProductOverride_Reference_tbl_MembershipProduct_ProductID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblPackageMembershipProductOverride)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_tbl_PackageMembershipProductOverride_Reference_tbl_Package_ProductID");
            });

            modelBuilder.Entity<TblPackageUmbrellaJoin>(entity =>
            {
                entity.HasKey(e => e.PackageUmbrellaJoinId);

                entity.ToTable("tbl_PackageUmbrellaJoin");

                entity.HasIndex(e => new { e.ProductId, e.ChildProductId })
                    .HasName("UNCINDEX_tbl_PackageUmbrellaJoin_ProductID_ChildProductID")
                    .IsUnique();

                entity.Property(e => e.PackageUmbrellaJoinId).HasColumnName("PackageUmbrellaJoinID");

                entity.Property(e => e.ChildProductId).HasColumnName("ChildProductID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Tstamp)
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.ChildProduct)
                    .WithMany(p => p.TblPackageUmbrellaJoinChildProduct)
                    .HasForeignKey(d => d.ChildProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_PackageUmbrellaJoin_tbl_Package_Child");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblPackageUmbrellaJoinProduct)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_PackageUmbrellaJoin_tbl_Package");
            });

            modelBuilder.Entity<TblPartPaymentSchedule>(entity =>
            {
                entity.HasKey(e => e.PartPaymentScheduleId);

                entity.ToTable("tbl_PartPaymentSchedule");

                entity.Property(e => e.PartPaymentScheduleId).HasColumnName("PartPaymentScheduleID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderClassification).HasMaxLength(2000);

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentDescription)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PaymentGroup)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.PaymentPercentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SeasonId).HasColumnName("SeasonID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblPartPaymentSchedule)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_PartPaymentSchedule_Reference_tblOrganisation");

                entity.HasOne(d => d.Season)
                    .WithMany(p => p.TblPartPaymentSchedule)
                    .HasForeignKey(d => d.SeasonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_PartPaymentSchedule_Reference_tbl_Season");
            });

            modelBuilder.Entity<TblPaxcard>(entity =>
            {
                entity.HasKey(e => e.PaxcardId);

                entity.ToTable("tbl_Paxcard");

                entity.Property(e => e.PaxcardId).HasColumnName("PaxcardID");

                entity.Property(e => e.Afile).HasMaxLength(5);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExtractedDate).HasColumnType("datetime");

                entity.Property(e => e.IssuedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationCustomerId).HasColumnName("OrganisationCustomerID");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.PaxcardBarcode)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PaxcardTypeName).HasMaxLength(50);

                entity.Property(e => e.RequestProcessedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.OrganisationCustomer)
                    .WithMany(p => p.TblPaxcard)
                    .HasForeignKey(d => d.OrganisationCustomerId)
                    .HasConstraintName("FK_tbl_Paxcard_REF_tblOrganisationCustomer");

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblPaxcard)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_Paxcard_REF_tblOrganisation");
            });

            modelBuilder.Entity<TblPaxcardAllocation>(entity =>
            {
                entity.HasKey(e => e.PaxcardAllocationId);

                entity.ToTable("tbl_PaxcardAllocation");

                entity.Property(e => e.PaxcardAllocationId).HasColumnName("PaxcardAllocationID");

                entity.Property(e => e.Aisle).HasMaxLength(50);

                entity.Property(e => e.BlockNumber).HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.GateNumber).HasMaxLength(20);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PaxcardId).HasColumnName("PaxcardID");

                entity.Property(e => e.Row).HasMaxLength(10);

                entity.Property(e => e.Seat).HasMaxLength(10);

                entity.Property(e => e.Section).HasMaxLength(12);

                entity.Property(e => e.SectionTitleLine).HasMaxLength(100);

                entity.Property(e => e.Stair).HasMaxLength(50);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.VenueId).HasColumnName("VenueID");

                entity.HasOne(d => d.Paxcard)
                    .WithMany(p => p.TblPaxcardAllocation)
                    .HasForeignKey(d => d.PaxcardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_PaxcardAllocation_REF_tbl_Paxcard");

                entity.HasOne(d => d.Venue)
                    .WithMany(p => p.TblPaxcardAllocation)
                    .HasForeignKey(d => d.VenueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_PaxcardAllocation_REF_tbl_Venue");
            });

            modelBuilder.Entity<TblPaxvenueGate>(entity =>
            {
                entity.HasKey(e => e.PaxvenueGateId);

                entity.ToTable("tbl_PAXVenueGate");

                entity.Property(e => e.PaxvenueGateId).HasColumnName("PAXVenueGateID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Gate).HasMaxLength(100);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.Venue).HasMaxLength(3);
            });

            modelBuilder.Entity<TblPaymentMasterSchedule>(entity =>
            {
                entity.HasKey(e => e.PaymentMasterScheduleId);

                entity.ToTable("tbl_PaymentMasterSchedule");

                entity.Property(e => e.PaymentMasterScheduleId).HasColumnName("PaymentMasterScheduleID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.MasterMappingId).HasColumnName("MasterMappingID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.ScheduleName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SeasonId).HasColumnName("SeasonID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.MasterMapping)
                    .WithMany(p => p.TblPaymentMasterSchedule)
                    .HasForeignKey(d => d.MasterMappingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_PaymentMasterSchedule_tbl_MasterMapping");

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblPaymentMasterSchedule)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_PaymentMasterSchedule_tblOrganisation");

                entity.HasOne(d => d.Season)
                    .WithMany(p => p.TblPaymentMasterSchedule)
                    .HasForeignKey(d => d.SeasonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_PaymentMasterSchedule_tbl_Season");
            });

            modelBuilder.Entity<TblPaymentMethod>(entity =>
            {
                entity.HasKey(e => e.PaymentMethodId);

                entity.ToTable("tbl_PaymentMethod");

                entity.Property(e => e.PaymentMethodId).HasColumnName("PaymentMethodID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentMethodName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblPaymentRun>(entity =>
            {
                entity.HasKey(e => e.RunId);

                entity.ToTable("tbl_PaymentRun");

                entity.Property(e => e.RunId)
                    .HasColumnName("RunID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PaymentType)
                    .IsRequired()
                    .HasColumnType("nchar(10)");
            });

            modelBuilder.Entity<TblPaymentSchedule>(entity =>
            {
                entity.HasKey(e => e.PaymentRunId);

                entity.ToTable("tbl_PaymentSchedule");

                entity.Property(e => e.PaymentRunId).HasColumnName("PaymentRunID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentPercentage).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PreviousPaymentRunId).HasColumnName("PreviousPaymentRunID");

                entity.Property(e => e.SeasonId).HasColumnName("SeasonID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblPaymentSchedule)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_PaymentSchedule_Reference_tblOrganisation");

                entity.HasOne(d => d.PreviousPaymentRun)
                    .WithMany(p => p.InversePreviousPaymentRun)
                    .HasForeignKey(d => d.PreviousPaymentRunId)
                    .HasConstraintName("FK_tbl_PaymentSchedule_Reference_tbl_Season_SeasonID");

                entity.HasOne(d => d.Season)
                    .WithMany(p => p.TblPaymentSchedule)
                    .HasForeignKey(d => d.SeasonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_PaymentSchedule_Reference_tbl_Season");
            });

            modelBuilder.Entity<TblPerformance>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("tbl_Performance");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PerformanceDate).HasColumnType("datetime");

                entity.Property(e => e.SeasonDescriptionFileExpired).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.VenueId).HasColumnName("VenueID");

                entity.HasOne(d => d.Product)
                    .WithOne(p => p.TblPerformance)
                    .HasForeignKey<TblPerformance>(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPerformance_Reference_tblProduct");

                entity.HasOne(d => d.Venue)
                    .WithMany(p => p.TblPerformance)
                    .HasForeignKey(d => d.VenueId)
                    .HasConstraintName("FK_tblPerformance_Reference_tbl_Venue");
            });

            modelBuilder.Entity<TblPerformancePriceTable>(entity =>
            {
                entity.HasKey(e => e.PerformancePriceTableId);

                entity.ToTable("tbl_PerformancePriceTable");

                entity.Property(e => e.PerformancePriceTableId).HasColumnName("PerformancePriceTableID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ShowVenuePerformanceId).HasColumnName("ShowVenuePerformanceID");

                entity.Property(e => e.ShowVenuePriceTableId).HasColumnName("ShowVenuePriceTableID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.ShowVenuePerformance)
                    .WithMany(p => p.TblPerformancePriceTable)
                    .HasForeignKey(d => d.ShowVenuePerformanceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_PerformancePriceTable_Ref_tbl_ShowVenuePerformance");

                entity.HasOne(d => d.ShowVenuePriceTable)
                    .WithMany(p => p.TblPerformancePriceTable)
                    .HasForeignKey(d => d.ShowVenuePriceTableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_PerformancePriceTable_Ref_tbl_ShowVenuePriceTable");
            });

            modelBuilder.Entity<TblPerformancePriceType>(entity =>
            {
                entity.HasKey(e => e.PerformancePriceTypeId);

                entity.ToTable("tbl_PerformancePriceType");

                entity.HasIndex(e => e.PerformanceId)
                    .HasName("IC_tbl_PerformancePriceType_PerformanceID");

                entity.HasIndex(e => new { e.PerformanceId, e.PriceTypeCode })
                    .HasName("UC_tbl_PerformancePriceType_PerformanceID_PriceTypeCode")
                    .IsUnique();

                entity.Property(e => e.PerformancePriceTypeId).HasColumnName("PerformancePriceTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PerformanceId).HasColumnName("PerformanceID");

                entity.Property(e => e.PriceTypeCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Performance)
                    .WithMany(p => p.TblPerformancePriceType)
                    .HasForeignKey(d => d.PerformanceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_PerformancePriceType_PerformanceID");
            });

            modelBuilder.Entity<TblPhone>(entity =>
            {
                entity.HasKey(e => e.PhoneId);

                entity.ToTable("tblPhone");

                entity.HasIndex(e => e.PhoneNumber)
                    .HasName("idx_PhoneNumber");

                entity.Property(e => e.PhoneId).HasColumnName("PhoneID");

                entity.Property(e => e.AreaCode).HasMaxLength(10);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InternationalCode).HasMaxLength(10);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PhoneTypeId).HasColumnName("PhoneTypeID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.PhoneType)
                    .WithMany(p => p.TblPhone)
                    .HasForeignKey(d => d.PhoneTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblRefCustomerPhoneType_tblCustomerPhoneValue_FK1");
            });

            modelBuilder.Entity<TblPhoneNumberType>(entity =>
            {
                entity.HasKey(e => e.PhoneNumberTypeId);

                entity.ToTable("tbl_PhoneNumberType");

                entity.Property(e => e.PhoneNumberTypeId)
                    .HasColumnName("PhoneNumberTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.PhoneNumberType)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TblPhoneType>(entity =>
            {
                entity.HasKey(e => e.PhoneTypeId);

                entity.ToTable("tblPhoneType");

                entity.HasIndex(e => e.PhoneTypeName)
                    .HasName("uc_tblPhoneType_PhoneTypeName")
                    .IsUnique();

                entity.Property(e => e.PhoneTypeId).HasColumnName("PhoneTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PhoneTypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblPinpadUsage>(entity =>
            {
                entity.HasKey(e => e.PinpadUsageId);

                entity.ToTable("tbl_PinpadUsage");

                entity.HasIndex(e => e.MachineId)
                    .HasName("NCINDEX_tbl_PinpadUsage_MachineID");

                entity.Property(e => e.PinpadUsageId).HasColumnName("PinpadUsageID");

                entity.Property(e => e.AuthId)
                    .HasColumnName("AuthID")
                    .HasMaxLength(12);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MachineId)
                    .IsRequired()
                    .HasColumnName("MachineID")
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ReferenceNumber)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblPlaceHolderProduct>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("tbl_PlaceHolderProduct");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DisplayTo).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Product)
                    .WithOne(p => p.TblPlaceHolderProduct)
                    .HasForeignKey<TblPlaceHolderProduct>(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_PlaceHolderProduct_tbl_Product");
            });

            modelBuilder.Entity<TblPriceMarketingType>(entity =>
            {
                entity.HasKey(e => e.PriceMarketingTypeId);

                entity.ToTable("tbl_PriceMarketingType");

                entity.Property(e => e.PriceMarketingTypeId).HasColumnName("PriceMarketingTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PriceMarketingCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PriceMarketingDescription).HasMaxLength(255);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblPriceTable>(entity =>
            {
                entity.HasKey(e => new { e.ShowVenuePriceTableId, e.ShowVenuePriceCategoryId, e.PriceTypeId });

                entity.ToTable("tbl_PriceTable");

                entity.Property(e => e.ShowVenuePriceTableId).HasColumnName("ShowVenuePriceTableID");

                entity.Property(e => e.ShowVenuePriceCategoryId).HasColumnName("ShowVenuePriceCategoryID");

                entity.Property(e => e.PriceTypeId).HasColumnName("PriceTypeID");

                entity.Property(e => e.BookingFee).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InsideCharge).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Intersection).HasMaxLength(3);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PromoterNetPrice).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.PromotionCode).HasMaxLength(4);

                entity.Property(e => e.Tax).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.TicketPrice).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.TicketPrintPrice).HasMaxLength(50);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.WebAccess).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.PriceType)
                    .WithMany(p => p.TblPriceTable)
                    .HasForeignKey(d => d.PriceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_PriceTable_Ref_tbl_StandardPriceType");

                entity.HasOne(d => d.ShowVenuePriceCategory)
                    .WithMany(p => p.TblPriceTable)
                    .HasForeignKey(d => d.ShowVenuePriceCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_PriceTable_Ref_tbl_ShowVenuePriceCategory");

                entity.HasOne(d => d.ShowVenuePriceTable)
                    .WithMany(p => p.TblPriceTable)
                    .HasForeignKey(d => d.ShowVenuePriceTableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_PriceTable_Ref_tbl_ShowVenuePriceTable");
            });

            modelBuilder.Entity<TblPriceType>(entity =>
            {
                entity.HasKey(e => e.PriceTypeId);

                entity.ToTable("tbl_PriceType");

                entity.Property(e => e.PriceTypeId).HasColumnName("PriceTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.ExtRefCode).HasMaxLength(50);

                entity.Property(e => e.MappingCode).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.PriceTypeCode).HasMaxLength(5);

                entity.Property(e => e.PriceTypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblPriceType)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_PriceType_tblOrganisation");
            });

            modelBuilder.Entity<TblPriceTypeClass>(entity =>
            {
                entity.HasKey(e => e.PriceTypeClassId);

                entity.ToTable("tbl_PriceTypeClass");

                entity.Property(e => e.PriceTypeClassId).HasColumnName("PriceTypeClassID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PriceTypeClassCode)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.PriceTypeClassName).HasMaxLength(50);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblPriceTypeMap>(entity =>
            {
                entity.HasKey(e => e.PriceTypeMapId);

                entity.ToTable("tbl_PriceTypeMap");

                entity.Property(e => e.PriceTypeMapId).HasColumnName("PriceTypeMapID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ParentPriceTypeId).HasColumnName("ParentPriceTypeID");

                entity.Property(e => e.PriceTypeId).HasColumnName("PriceTypeID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.ParentPriceType)
                    .WithMany(p => p.TblPriceTypeMapParentPriceType)
                    .HasForeignKey(d => d.ParentPriceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_PriceTypeMap_tbl_PriceType1");

                entity.HasOne(d => d.PriceType)
                    .WithMany(p => p.TblPriceTypeMapPriceType)
                    .HasForeignKey(d => d.PriceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_PriceTypeMap_tbl_PriceType");
            });

            modelBuilder.Entity<TblPriceTypeMembershipProduct>(entity =>
            {
                entity.HasKey(e => new { e.PriceTypeId, e.MembershipProductId });

                entity.ToTable("tbl_PriceTypeMembershipProduct");

                entity.Property(e => e.PriceTypeId).HasColumnName("PriceTypeID");

                entity.Property(e => e.MembershipProductId).HasColumnName("MembershipProductID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.MembershipProduct)
                    .WithMany(p => p.TblPriceTypeMembershipProduct)
                    .HasForeignKey(d => d.MembershipProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_PriceTypeMembershipProduct_ProductID");

                entity.HasOne(d => d.PriceType)
                    .WithMany(p => p.TblPriceTypeMembershipProduct)
                    .HasForeignKey(d => d.PriceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_PriceTypeMembershipProduct_PriceTypeID");
            });

            modelBuilder.Entity<TblPriceTypeRule>(entity =>
            {
                entity.HasKey(e => e.PriceTypeRuleId);

                entity.ToTable("tbl_PriceTypeRule");

                entity.Property(e => e.PriceTypeRuleId).HasColumnName("PriceTypeRuleID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PerformanceId).HasColumnName("PerformanceID");

                entity.Property(e => e.RuleName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Performance)
                    .WithMany(p => p.TblPriceTypeRule)
                    .HasForeignKey(d => d.PerformanceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_PriceTypeRule_PerformanceID");
            });

            modelBuilder.Entity<TblPriceTypeRulePriceType>(entity =>
            {
                entity.HasKey(e => new { e.PriceTypeRuleId, e.PerformancePriceTypeId });

                entity.ToTable("tbl_PriceTypeRulePriceType");

                entity.Property(e => e.PriceTypeRuleId).HasColumnName("PriceTypeRuleID");

                entity.Property(e => e.PerformancePriceTypeId).HasColumnName("PerformancePriceTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.PerformancePriceType)
                    .WithMany(p => p.TblPriceTypeRulePriceType)
                    .HasForeignKey(d => d.PerformancePriceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_PriceTypeRulePriceType_PerformancePriceTypeID");

                entity.HasOne(d => d.PriceTypeRule)
                    .WithMany(p => p.TblPriceTypeRulePriceType)
                    .HasForeignKey(d => d.PriceTypeRuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_PriceTypeRulePriceType_PriceTypeRuleID");
            });

            modelBuilder.Entity<TblPrimaryMember>(entity =>
            {
                entity.HasKey(e => new { e.PrimaryOrganisationCustomerId, e.SecondaryOrganisationCustomerId });

                entity.ToTable("tbl_PrimaryMember");

                entity.HasIndex(e => e.SecondaryOrganisationCustomerId)
                    .HasName("NCLIDX_tbl_PrimaryMember_SecondaryMemberID");

                entity.Property(e => e.PrimaryOrganisationCustomerId).HasColumnName("PrimaryOrganisationCustomerID");

                entity.Property(e => e.SecondaryOrganisationCustomerId).HasColumnName("SecondaryOrganisationCustomerID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.PrimaryOrganisationCustomer)
                    .WithMany(p => p.TblPrimaryMemberPrimaryOrganisationCustomer)
                    .HasForeignKey(d => d.PrimaryOrganisationCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_PrimaryMember_tbl_Member_Primary");

                entity.HasOne(d => d.SecondaryOrganisationCustomer)
                    .WithMany(p => p.TblPrimaryMemberSecondaryOrganisationCustomer)
                    .HasForeignKey(d => d.SecondaryOrganisationCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_PrimaryMember_tbl_Member_Secondary");
            });

            modelBuilder.Entity<TblPrintRecord>(entity =>
            {
                entity.HasKey(e => e.PrintTransactionId);

                entity.ToTable("tblPrintRecord");

                entity.Property(e => e.PrintTransactionId)
                    .HasColumnName("PrintTransactionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EticketEmail).HasMaxLength(50);

                entity.Property(e => e.IsEticket).HasColumnName("IsETicket");

                entity.Property(e => e.IsPtrans).HasColumnName("IsPTrans");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PaxOrganisationCode).HasMaxLength(50);

                entity.Property(e => e.PreviousPrintTransactionId).HasColumnName("PreviousPrintTransactionID");

                entity.Property(e => e.PrintSellerCommission).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.PtransGranted)
                    .HasColumnName("PTransGranted")
                    .HasMaxLength(50);

                entity.Property(e => e.SellerPrinted)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionDateTime).HasColumnType("datetime");

                entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TblPrintRecord)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblOrder_tblPrintRecord_FK1");

                entity.HasOne(d => d.PreviousPrintTransaction)
                    .WithMany(p => p.TblPrintRecordPreviousPrintTransaction)
                    .HasForeignKey(d => d.PreviousPrintTransactionId)
                    .HasConstraintName("tblPrintRecord_tblPrintRecord_FK1");

                entity.HasOne(d => d.PrintTransaction)
                    .WithOne(p => p.TblPrintRecordPrintTransaction)
                    .HasForeignKey<TblPrintRecord>(d => d.PrintTransactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblPrintRecord_tblOriginPrintRecordMap_FK1");
            });

            modelBuilder.Entity<TblProcessLock>(entity =>
            {
                entity.HasKey(e => e.ProcessLockId);

                entity.ToTable("tbl_ProcessLock");

                entity.Property(e => e.ProcessLockId).HasColumnName("ProcessLockID");

                entity.Property(e => e.CancelledDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StopDate).HasColumnType("datetime");

                entity.Property(e => e.UniqueKeys).HasMaxLength(200);

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblProcessLock)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ProcessLock_tblOrganisation");
            });

            modelBuilder.Entity<TblProdSelProductJoin>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.ProductSelectionId });

                entity.ToTable("tbl_ProdSelProductJoin");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductSelectionId).HasColumnName("ProductSelectionID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblProdSelProductJoin)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ProdSelProductJoin_ProductID");

                entity.HasOne(d => d.ProductSelection)
                    .WithMany(p => p.TblProdSelProductJoin)
                    .HasForeignKey(d => d.ProductSelectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ProdSelProductJoin_ProductSelectionID");
            });

            modelBuilder.Entity<TblProduct>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("tbl_Product");

                entity.HasIndex(e => new { e.OrganisationId, e.Archived })
                    .HasName("NCINDEX_tbl_Product_OrganisationID_Archived");

                entity.HasIndex(e => new { e.ProductId, e.ProductClassId })
                    .HasName("NCINDEX_tbl_Product_ProductClassID");

                entity.HasIndex(e => new { e.ProductId, e.SourceProductCode, e.Allocate, e.ParentProductId, e.ExtRefHoldCode, e.SourceId })
                    .HasName("NCINDEX_tbl_Product_SourceID_INC1");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.AncillaryDescription).HasColumnType("ntext");

                entity.Property(e => e.BookingPeriodEndDate).HasColumnType("datetime");

                entity.Property(e => e.BookingPeriodStartDate).HasColumnType("datetime");

                entity.Property(e => e.ConfirmationMessage).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.ExtRefHoldCode).HasMaxLength(5);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderFulfillmentMethodId).HasColumnName("OrderFulfillmentMethodID");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.ParentProductId).HasColumnName("ParentProductID");

                entity.Property(e => e.ProductClassId).HasColumnName("ProductClassID");

                entity.Property(e => e.ProductCode).HasMaxLength(5);

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");

                entity.Property(e => e.RankingFactorId).HasColumnName("RankingFactorID");

                entity.Property(e => e.SeasonId).HasColumnName("SeasonID");

                entity.Property(e => e.SellerBookingPeriodEndDate).HasColumnType("datetime");

                entity.Property(e => e.SellerBookingPeriodStartDate).HasColumnType("datetime");

                entity.Property(e => e.SellerWaitlistPeriodEndDate).HasColumnType("datetime");

                entity.Property(e => e.SellerWaitlistPeriodStartDate).HasColumnType("datetime");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.SourceProductCode).HasMaxLength(50);

                entity.Property(e => e.StatusBannerMsg).HasMaxLength(255);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.VisiblePeriodEndDate).HasColumnType("datetime");

                entity.Property(e => e.VisiblePeriodStartDate).HasColumnType("datetime");

                entity.Property(e => e.WaitListPeriodEndDate).HasColumnType("datetime");

                entity.Property(e => e.WaitListPeriodStartDate).HasColumnType("datetime");

                entity.HasOne(d => d.OrderFulfillmentMethod)
                    .WithMany(p => p.TblProduct)
                    .HasForeignKey(d => d.OrderFulfillmentMethodId)
                    .HasConstraintName("FK_tbl_Product_tbl_FulfilmentMethod");

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblProduct)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblProduct_Reference_tblOrg");

                entity.HasOne(d => d.ProductClass)
                    .WithMany(p => p.TblProduct)
                    .HasForeignKey(d => d.ProductClassId)
                    .HasConstraintName("FK_tbl_Product_tbl_ProductClass");

                entity.HasOne(d => d.ProductType)
                    .WithMany(p => p.TblProduct)
                    .HasForeignKey(d => d.ProductTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblProduct_Reference_tblProductType");

                entity.HasOne(d => d.RankingFactor)
                    .WithMany(p => p.TblProduct)
                    .HasForeignKey(d => d.RankingFactorId)
                    .HasConstraintName("FK_tbl_Product_tbl_RankingFactor");

                entity.HasOne(d => d.Season)
                    .WithMany(p => p.TblProduct)
                    .HasForeignKey(d => d.SeasonId);

                entity.HasOne(d => d.Source)
                    .WithMany(p => p.TblProduct)
                    .HasForeignKey(d => d.SourceId)
                    .HasConstraintName("FK_tblProduct_Reference_tblProductSource");
            });

            modelBuilder.Entity<TblProductCategory>(entity =>
            {
                entity.HasKey(e => e.ProductCategoryId);

                entity.ToTable("tbl_ProductCategory");

                entity.Property(e => e.ProductCategoryId).HasColumnName("ProductCategoryID");

                entity.Property(e => e.BackgroundColour).HasMaxLength(20);

                entity.Property(e => e.CategoryCode).HasMaxLength(5);

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.ExtRefCode).HasMaxLength(50);

                entity.Property(e => e.ForegroundColour).HasMaxLength(20);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblProductCategory)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblProdCat_Reference_tblOrg");
            });

            modelBuilder.Entity<TblProductCategoryCapacity>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.ProductCategoryId });

                entity.ToTable("tbl_ProductCategoryCapacity");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductCategoryId).HasColumnName("ProductCategoryID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.TblProductCategoryCapacity)
                    .HasForeignKey(d => d.ProductCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ProductCategoryCapacity_Reference_tbl_ProductCategory");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblProductCategoryCapacity)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ProductCategoryCapacity_Reference_tbl_Product");
            });

            modelBuilder.Entity<TblProductClass>(entity =>
            {
                entity.HasKey(e => e.ProductClassId);

                entity.ToTable("tbl_ProductClass");

                entity.Property(e => e.ProductClassId)
                    .HasColumnName("ProductClassID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductClassName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblProductGroup>(entity =>
            {
                entity.HasKey(e => e.ProductGroupId);

                entity.ToTable("tbl_ProductGroup");

                entity.Property(e => e.ProductGroupId).HasColumnName("ProductGroupID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Heading)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblProductGroup)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ProductGroup_OrganisationID");
            });

            modelBuilder.Entity<TblProductMemberShopItem>(entity =>
            {
                entity.HasKey(e => e.ProductMemberShopItemId);

                entity.ToTable("tbl_ProductMemberShopItem");

                entity.Property(e => e.ProductMemberShopItemId).HasColumnName("ProductMemberShopItemID");

                entity.Property(e => e.CustomFieldName).HasMaxLength(50);

                entity.Property(e => e.CustomizedTextLabel).HasMaxLength(50);

                entity.Property(e => e.ExtraCustomFieldName).HasMaxLength(50);

                entity.Property(e => e.HeroDescription).HasColumnType("ntext");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblProductMemberShopItem)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MemberShopItem_tblOrganisation");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblProductMemberShopItem)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MemberShopItem_tbl_Product");
            });

            modelBuilder.Entity<TblProductMemberShopItemColor>(entity =>
            {
                entity.HasKey(e => e.ProductMemberShopItemColorId);

                entity.ToTable("tbl_ProductMemberShopItemColor");

                entity.Property(e => e.ProductMemberShopItemColorId).HasColumnName("ProductMemberShopItemColorID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblProductMemberShopItemColor)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ProductMemberShopItemColor_tbl_Product");
            });

            modelBuilder.Entity<TblProductMemberShopItemCustomField>(entity =>
            {
                entity.HasKey(e => e.ProductMemberShopItemCustomFieldId);

                entity.ToTable("tbl_ProductMemberShopItemCustomField");

                entity.Property(e => e.ProductMemberShopItemCustomFieldId).HasColumnName("ProductMemberShopItemCustomFieldID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblProductMemberShopItemCustomField)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ProductMemberShopItemCustomField_tbl_Product");
            });

            modelBuilder.Entity<TblProductMemberShopItemExtraCustomField>(entity =>
            {
                entity.HasKey(e => e.ProductMemberShopItemExtraCustomFieldId);

                entity.ToTable("tbl_ProductMemberShopItemExtraCustomField");

                entity.Property(e => e.ProductMemberShopItemExtraCustomFieldId).HasColumnName("ProductMemberShopItemExtraCustomFieldID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblProductMemberShopItemExtraCustomField)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ProductMemberShopItemExtraCustomField_tbl_Product");
            });

            modelBuilder.Entity<TblProductMemberShopItemImage>(entity =>
            {
                entity.HasKey(e => e.ProductMemberShopItemImageId);

                entity.ToTable("tbl_ProductMemberShopItemImage");

                entity.Property(e => e.ProductMemberShopItemImageId).HasColumnName("ProductMemberShopItemImageID");

                entity.Property(e => e.ContentType).HasMaxLength(50);

                entity.Property(e => e.FileExtension).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasMaxLength(100);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblProductMemberShopItemImage)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ProductMemberShopItemImage_tbl_Product");
            });

            modelBuilder.Entity<TblProductMemberShopItemImageUpload>(entity =>
            {
                entity.HasKey(e => e.ProductMemberShopItemUploadId);

                entity.ToTable("tbl_ProductMemberShopItemImageUpload");

                entity.Property(e => e.ProductMemberShopItemUploadId).HasColumnName("ProductMemberShopItemUploadID");

                entity.Property(e => e.ContentType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FileExtension)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ImageFull).IsRequired();

                entity.Property(e => e.ImageResized).IsRequired();

                entity.Property(e => e.ImageThumbnail).IsRequired();

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.UniqueId)
                    .IsRequired()
                    .HasColumnName("UniqueID")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblProductMemberShopItemImageUpload)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ProductMemberShopItemImageUpload_tbl_Product");
            });

            modelBuilder.Entity<TblProductMemberShopItemSize>(entity =>
            {
                entity.HasKey(e => e.ProductMemberShopItemSizeId);

                entity.ToTable("tbl_ProductMemberShopItemSize");

                entity.Property(e => e.ProductMemberShopItemSizeId).HasColumnName("ProductMemberShopItemSizeID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblProductMemberShopItemSize)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ProductMemberShopItemSize_tbl_Product");
            });

            modelBuilder.Entity<TblProductOrganisationFile>(entity =>
            {
                entity.HasKey(e => e.ProductOrganisationFileId);

                entity.ToTable("tbl_ProductOrganisationFile");

                entity.HasIndex(e => new { e.OrganisationFileId, e.ProductId, e.ProductFileUsageType })
                    .HasName("IX_ProductOrganisationFile_OrganisationFileID_ProductID_ProductFileUsageType")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.ProductOrganisationFileId).HasColumnName("ProductOrganisationFileID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationFileId).HasColumnName("OrganisationFileID");

                entity.Property(e => e.ProductFileType).HasMaxLength(50);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.OrganisationFile)
                    .WithMany(p => p.TblProductOrganisationFile)
                    .HasForeignKey(d => d.OrganisationFileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ProductOrganisationFile_tbl_OrganisationFile");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblProductOrganisationFile)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ProductOrganisationFile_tbl_Product");
            });

            modelBuilder.Entity<TblProductPricing>(entity =>
            {
                entity.HasKey(e => e.ProductPricingId);

                entity.ToTable("tbl_ProductPricing");

                entity.HasIndex(e => e.PriceTypeId)
                    .HasName("NCINDEX_tbl_ProductPricing_PriceTypeID");

                entity.HasIndex(e => e.ProductCategoryId)
                    .HasName("NCINDEX_tbl_ProductPricing_ProductCategoryID");

                entity.HasIndex(e => e.ProductId)
                    .HasName("NCINDEX_tbl_ProductPricing_ProductID");

                entity.Property(e => e.ProductPricingId).HasColumnName("ProductPricingID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ExtRefHoldCode).HasMaxLength(5);

                entity.Property(e => e.IsGacategory).HasColumnName("IsGACategory");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.PriceTypeId).HasColumnName("PriceTypeID");

                entity.Property(e => e.ProductCategoryId).HasColumnName("ProductCategoryID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.PromotionCode).HasMaxLength(20);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.PriceType)
                    .WithMany(p => p.TblProductPricing)
                    .HasForeignKey(d => d.PriceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblProdPricing_Reference_tblPriceType");

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.TblProductPricing)
                    .HasForeignKey(d => d.ProductCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblProdPricing_Reference_tblProdCat");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblProductPricing)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblProdPricing_Reference_tblMemProduct");
            });

            modelBuilder.Entity<TblProductPricingExtension>(entity =>
            {
                entity.HasKey(e => e.ProductPricingExtensionId);

                entity.ToTable("tbl_ProductPricingExtension");

                entity.HasIndex(e => e.ProductPricingId)
                    .HasName("NCINDEX_tbl_ProductPricingExtension_ProductPricingID");

                entity.Property(e => e.ProductPricingExtensionId).HasColumnName("ProductPricingExtensionID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ExtRefHoldCode).HasMaxLength(5);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ProductPricingId).HasColumnName("ProductPricingID");

                entity.Property(e => e.PromotionCode).HasMaxLength(20);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.ProductPricing)
                    .WithMany(p => p.TblProductPricingExtension)
                    .HasForeignKey(d => d.ProductPricingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ProdPricingExt_Reference_tblProdPricing");
            });

            modelBuilder.Entity<TblProductProdGroupJoin>(entity =>
            {
                entity.HasKey(e => e.ProductProdGroupJoinId);

                entity.ToTable("tbl_ProductProdGroupJoin");

                entity.Property(e => e.ProductProdGroupJoinId).HasColumnName("ProductProdGroupJoinID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductGroupId).HasColumnName("ProductGroupID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblProductProdSelJoin>(entity =>
            {
                entity.HasKey(e => new { e.ProductSelectionId, e.ProductId });

                entity.ToTable("tbl_ProductProdSelJoin");

                entity.Property(e => e.ProductSelectionId).HasColumnName("ProductSelectionID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SelectedByDefault).HasDefaultValueSql("('0')");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblProductProdSelJoin)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBL_PROD_REFERENCE_TBL_PROD");

                entity.HasOne(d => d.ProductSelection)
                    .WithMany(p => p.TblProductProdSelJoin)
                    .HasForeignKey(d => d.ProductSelectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPkgProdSelJoin_Reference_ProdSel");
            });

            modelBuilder.Entity<TblProductSelection>(entity =>
            {
                entity.HasKey(e => e.ProductSelectionId);

                entity.ToTable("tbl_ProductSelection");

                entity.Property(e => e.ProductSelectionId).HasColumnName("ProductSelectionID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.ProductSelectionBlurb).HasMaxLength(1000);

                entity.Property(e => e.ProductSelectionCode).HasMaxLength(5);

                entity.Property(e => e.ProductSelectionName).HasMaxLength(50);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblProductSelection)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ProductSelection_OrganisationID");
            });

            modelBuilder.Entity<TblProductSource>(entity =>
            {
                entity.HasKey(e => e.SourceId);

                entity.ToTable("tbl_ProductSource");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsGaseatingSource).HasColumnName("IsGASeatingSource");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductSourceName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblProductType>(entity =>
            {
                entity.HasKey(e => e.ProductTypeId);

                entity.ToTable("tbl_ProductType");

                entity.Property(e => e.ProductTypeId)
                    .HasColumnName("ProductTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductTypeName).HasMaxLength(50);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblProductUpgrade>(entity =>
            {
                entity.HasKey(e => new { e.UpgradeProductId, e.TargetProductId })
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tbl_ProductUpgrade");

                entity.Property(e => e.UpgradeProductId).HasColumnName("UpgradeProductID");

                entity.Property(e => e.TargetProductId).HasColumnName("TargetProductID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.TargetProduct)
                    .WithMany(p => p.TblProductUpgradeTargetProduct)
                    .HasForeignKey(d => d.TargetProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblProductLink_Reference_tblProduct2");

                entity.HasOne(d => d.UpgradeProduct)
                    .WithMany(p => p.TblProductUpgradeUpgradeProduct)
                    .HasForeignKey(d => d.UpgradeProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblProductLink_Reference_tblProduct1");
            });

            modelBuilder.Entity<TblProductWaitlist>(entity =>
            {
                entity.HasKey(e => e.ProductWaitlistId);

                entity.ToTable("tbl_ProductWaitlist");

                entity.Property(e => e.ProductWaitlistId).HasColumnName("ProductWaitlistID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Mms).HasColumnName("MMS");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationCustomerId).HasColumnName("OrganisationCustomerID");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Sms).HasColumnName("SMS");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.OrganisationCustomer)
                    .WithMany(p => p.TblProductWaitlist)
                    .HasForeignKey(d => d.OrganisationCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ProductWaitlist_tblOrganisationCustomer");

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblProductWaitlist)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ProductWaitlist_tblOrganisation");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblProductWaitlist)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ProductWaitlist_tbl_Product");
            });

            modelBuilder.Entity<TblProm>(entity =>
            {
                entity.HasKey(e => e.PromId);

                entity.ToTable("tbl_Prom");

                entity.Property(e => e.PromId).HasColumnName("PromID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PromCode)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.PromName).HasMaxLength(100);

                entity.Property(e => e.Region).HasMaxLength(3);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblPromoter>(entity =>
            {
                entity.HasKey(e => e.PromoterId);

                entity.ToTable("tbl_Promoter");

                entity.HasIndex(e => e.PromoterName)
                    .HasName("uc_tbl_Promoter_PromoterName")
                    .IsUnique();

                entity.Property(e => e.PromoterId).HasColumnName("PromoterID");

                entity.Property(e => e.BusinessId).HasColumnName("BusinessID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PromoterCode).HasMaxLength(5);

                entity.Property(e => e.PromoterName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Business)
                    .WithMany(p => p.TblPromoter)
                    .HasForeignKey(d => d.BusinessId)
                    .HasConstraintName("FK_tbl_Promoter_BusinessID");
            });

            modelBuilder.Entity<TblProtectionGroup>(entity =>
            {
                entity.HasKey(e => e.ProtectionGroupId);

                entity.ToTable("tbl_ProtectionGroup");

                entity.HasIndex(e => e.EntitlementGroupId)
                    .HasName("IC_tbl_ProtectionGroup_EntitlementGroupID");

                entity.HasIndex(e => new { e.EntitlementGroupId, e.ProtectionGroupId, e.StartDate, e.EndDate })
                    .HasName("IC_tbl_ProtectionGroup_EGID_PGID_SDate_EDate");

                entity.Property(e => e.ProtectionGroupId).HasColumnName("ProtectionGroupID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.EntitlementGroupId).HasColumnName("EntitlementGroupID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.EntitlementGroup)
                    .WithMany(p => p.TblProtectionGroup)
                    .HasForeignKey(d => d.EntitlementGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ProtectionGroup_EntitlementGroupID");
            });

            modelBuilder.Entity<TblProtectionGroupEntitlement>(entity =>
            {
                entity.HasKey(e => e.ProtectionGroupEntitlementId);

                entity.ToTable("tbl_ProtectionGroupEntitlement");

                entity.HasIndex(e => e.EntitlementId)
                    .HasName("IC_tbl_ProtectionGroupEntitlement_EntitlementID");

                entity.HasIndex(e => e.ProtectionGroupId)
                    .HasName("IC_tbl_ProtectionGroupEntitlement_ProtectionGroupID");

                entity.HasIndex(e => new { e.ProtectionGroupId, e.EntitlementId })
                    .HasName("UC_tbl_ProtectionGroupEntitlement_ProtectionGroupID_EntitlementID")
                    .IsUnique();

                entity.Property(e => e.ProtectionGroupEntitlementId).HasColumnName("ProtectionGroupEntitlementID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EntitlementId).HasColumnName("EntitlementID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OfferCode).HasMaxLength(50);

                entity.Property(e => e.ProtectionGroupId).HasColumnName("ProtectionGroupID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Entitlement)
                    .WithMany(p => p.TblProtectionGroupEntitlement)
                    .HasForeignKey(d => d.EntitlementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ProtectionGroupEntitlement_EntitlementID");

                entity.HasOne(d => d.ProtectionGroup)
                    .WithMany(p => p.TblProtectionGroupEntitlement)
                    .HasForeignKey(d => d.ProtectionGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ProtectionGroupEntitlement_ProtectionGroupID");
            });

            modelBuilder.Entity<TblProtectionGroupEntitlementPriceType>(entity =>
            {
                entity.HasKey(e => new { e.ProtectionGroupEntitlementId, e.PriceTypeCode });

                entity.ToTable("tbl_ProtectionGroupEntitlementPriceType");

                entity.HasIndex(e => e.ProtectionGroupEntitlementId)
                    .HasName("IC_tbl_ProtectionGroupEntitlementPriceType_ProtectionGroupEntitlementID");

                entity.Property(e => e.ProtectionGroupEntitlementId).HasColumnName("ProtectionGroupEntitlementID");

                entity.Property(e => e.PriceTypeCode).HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.ProtectionGroupEntitlement)
                    .WithMany(p => p.TblProtectionGroupEntitlementPriceType)
                    .HasForeignKey(d => d.ProtectionGroupEntitlementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ProtectionGroupEntitlementPriceType_ProtectionGroupEntitlementID");
            });

            modelBuilder.Entity<TblProtectionItem>(entity =>
            {
                entity.HasKey(e => e.ProtectionItemId);

                entity.ToTable("tbl_ProtectionItem");

                entity.HasIndex(e => e.ProtectionGroupId)
                    .HasName("IC_tbl_ProtectionItem_ProtectionGroupID");

                entity.HasIndex(e => e.ShowItemId)
                    .HasName("IC_tbl_ProtectionItem_ShowItemID");

                entity.HasIndex(e => new { e.ProtectionGroupId, e.ShowItemId, e.ProtectionItemId })
                    .HasName("IC_tbl_ProtectionItem_PGID_SIID_PIID");

                entity.Property(e => e.ProtectionItemId).HasColumnName("ProtectionItemID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProtectionGroupId).HasColumnName("ProtectionGroupID");

                entity.Property(e => e.ShowItemId).HasColumnName("ShowItemID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.ProtectionGroup)
                    .WithMany(p => p.TblProtectionItem)
                    .HasForeignKey(d => d.ProtectionGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ProtectionItem_ProtectionGroupID");

                entity.HasOne(d => d.ShowItem)
                    .WithMany(p => p.TblProtectionItem)
                    .HasForeignKey(d => d.ShowItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ProtectionItem_ShowItemID");
            });

            modelBuilder.Entity<TblProtectionItemSourcePriceType>(entity =>
            {
                entity.HasKey(e => e.ProtectionItemSourcePriceTypeId);

                entity.ToTable("tbl_ProtectionItemSourcePriceType");

                entity.HasIndex(e => e.ProtectionItemId)
                    .HasName("IC_tbl_ProtectionItemSourcePriceType_ProtectionItemID");

                entity.HasIndex(e => new { e.ProtectionItemId, e.IsAvails, e.PriceTypeCode })
                    .HasName("UK_tbl_ProtectionItemSourcePriceType_ProtectionItemID_IsAvails_PriceTypeCode")
                    .IsUnique();

                entity.Property(e => e.ProtectionItemSourcePriceTypeId).HasColumnName("ProtectionItemSourcePriceTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PriceTypeCode).HasMaxLength(20);

                entity.Property(e => e.ProtectionItemId).HasColumnName("ProtectionItemID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.ProtectionItem)
                    .WithMany(p => p.TblProtectionItemSourcePriceType)
                    .HasForeignKey(d => d.ProtectionItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ProtectionItemSourcePriceType_ProtectionItemID");
            });

            modelBuilder.Entity<TblQueryStringUniqueIdentifier>(entity =>
            {
                entity.HasKey(e => e.Guid);

                entity.ToTable("tbl_QueryStringUniqueIdentifier");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SourceCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblRankingFactor>(entity =>
            {
                entity.HasKey(e => e.RankingFactorId);

                entity.ToTable("tbl_RankingFactor");

                entity.Property(e => e.RankingFactorId).HasColumnName("RankingFactorID");

                entity.Property(e => e.BookingFactor).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NonAttendanceFactor).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NonBookingFactor).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.PayingGuestFactor).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.RankingFactor).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.RankingFactorName).HasMaxLength(100);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblRankingFactor)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_RankingFactor_tblOrganisation");
            });

            modelBuilder.Entity<TblRegion>(entity =>
            {
                entity.HasKey(e => e.RegionId);

                entity.ToTable("tbl_Region");

                entity.Property(e => e.RegionId)
                    .HasColumnName("RegionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RegionCode)
                    .IsRequired()
                    .HasColumnType("nchar(3)");

                entity.Property(e => e.TimezoneName).HasMaxLength(50);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TblRegion)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_Country_tbl_Region");
            });

            modelBuilder.Entity<TblRow>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.ToTable("tbl_Row");

                entity.HasIndex(e => new { e.SeasonSeatMapSectionId, e.RowName, e.RowId })
                    .HasName("NCINDEX_tbl_Row_SeasonSeatMapSectionID_RowName_RowID");

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RowName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.SeasonSeatMapSectionId).HasColumnName("SeasonSeatMapSectionID");

                entity.Property(e => e.Tstamp)
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.SeasonSeatMapSection)
                    .WithMany(p => p.TblRow)
                    .HasForeignKey(d => d.SeasonSeatMapSectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_Row_Reference_tbl_SeasonSeatMapSection");
            });

            modelBuilder.Entity<TblSalesChannel>(entity =>
            {
                entity.HasKey(e => e.SalesChannelId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tbl_SalesChannel");

                entity.Property(e => e.SalesChannelId).HasColumnName("SalesChannelID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblSeason>(entity =>
            {
                entity.HasKey(e => e.SeasonId);

                entity.ToTable("tbl_Season");

                entity.Property(e => e.SeasonId).HasColumnName("SeasonID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MerchandiseEventCode).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.PrepayEventCode).HasMaxLength(50);

                entity.Property(e => e.PreviousSeasonId).HasColumnName("PreviousSeasonID");

                entity.Property(e => e.SeasonCode)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.SeasonDescription).HasMaxLength(30);

                entity.Property(e => e.SeasonEndDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblSeason)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_Season_Reference_tblOrganisation");

                entity.HasOne(d => d.PreviousSeason)
                    .WithMany(p => p.InversePreviousSeason)
                    .HasForeignKey(d => d.PreviousSeasonId)
                    .HasConstraintName("FK_tbl_Season_tbl_Season_SeasonID");
            });

            modelBuilder.Entity<TblSeasonSeatMap>(entity =>
            {
                entity.HasKey(e => e.SeasonSeatMapId);

                entity.ToTable("tbl_SeasonSeatMap");

                entity.Property(e => e.SeasonSeatMapId).HasColumnName("SeasonSeatMapID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.SeasonId).HasColumnName("SeasonID");

                entity.Property(e => e.SeasonSeatMapCode)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.SeasonSeatMapName).HasMaxLength(30);

                entity.Property(e => e.Tstamp)
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.VenueId).HasColumnName("VenueID");

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblSeasonSeatMap)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SeasonSeatMap_Reference_tblOrganisation");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblSeasonSeatMap)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_tbl_SeasonSeatMap_Reference_tbl_Product");

                entity.HasOne(d => d.Season)
                    .WithMany(p => p.TblSeasonSeatMap)
                    .HasForeignKey(d => d.SeasonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SeasonSeatMap_Reference_tbl_Season");

                entity.HasOne(d => d.Venue)
                    .WithMany(p => p.TblSeasonSeatMap)
                    .HasForeignKey(d => d.VenueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SeasonSeatMap_Reference_tbl_Venue");
            });

            modelBuilder.Entity<TblSeasonSeatMapSection>(entity =>
            {
                entity.HasKey(e => e.SeasonSeatMapSectionId);

                entity.ToTable("tbl_SeasonSeatMapSection");

                entity.HasIndex(e => new { e.SeasonSeatMapId, e.SectionName, e.SeasonSeatMapSectionId })
                    .HasName("NCINDEX_tbl_SeasonSeatMapSection_SeasonSeatMapID_SectionName_SeasonSeatMapSectionID");

                entity.Property(e => e.SeasonSeatMapSectionId).HasColumnName("SeasonSeatMapSectionID");

                entity.Property(e => e.BestAvailableArea).HasMaxLength(3);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsGasection).HasColumnName("IsGASection");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RowToSeatRatio).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.SeasonSeatMapId).HasColumnName("SeasonSeatMapID");

                entity.Property(e => e.SectionName)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.Tstamp)
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.SeasonSeatMap)
                    .WithMany(p => p.TblSeasonSeatMapSection)
                    .HasForeignKey(d => d.SeasonSeatMapId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SeasonSeatMapSection_Reference_tbl_SeasonSeatMap");
            });

            modelBuilder.Entity<TblSeat>(entity =>
            {
                entity.HasKey(e => e.SeatId);

                entity.ToTable("tbl_Seat");

                entity.HasIndex(e => new { e.RowId, e.SeatName })
                    .HasName("tbl_SeatName");

                entity.Property(e => e.SeatId).HasColumnName("SeatID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InitialOriginState).HasColumnType("char(1)");

                entity.Property(e => e.InititalOriginPriceTypeType).HasMaxLength(20);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.SeatName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Tstamp)
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Row)
                    .WithMany(p => p.TblSeat)
                    .HasForeignKey(d => d.RowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_Seat_Reference_tbl_Row");
            });

            modelBuilder.Entity<TblSeatAttribute>(entity =>
            {
                entity.HasKey(e => e.SeatAttributeId);

                entity.ToTable("tbl_SeatAttribute");

                entity.HasIndex(e => e.SeatId)
                    .HasName("NCINDEX_tbl_SeatAttribute_SeatID");

                entity.HasIndex(e => e.SeatStatusId)
                    .HasName("NCIDNEX_tbl_SeatAttribute_SeatStatusID");

                entity.HasIndex(e => e.SubscriptionAllocationId)
                    .HasName("NCLIDX_tbl_SeatAttribute_SubscriptionAllocationID");

                entity.HasIndex(e => new { e.SeatAttributeId, e.SeatId, e.SubscriptionAllocationId, e.SeatStatusId })
                    .HasName("NCINDEX_tbl_SeatAttribute_SeatStatusID_inc_SeatAttributeID_SeatID_SubscriptionAllocationID");

                entity.Property(e => e.SeatAttributeId).HasColumnName("SeatAttributeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OriginErrorAdvice).HasMaxLength(255);

                entity.Property(e => e.OriginErrorKey).HasMaxLength(255);

                entity.Property(e => e.PackageId).HasColumnName("PackageID");

                entity.Property(e => e.SeatId).HasColumnName("SeatID");

                entity.Property(e => e.SeatStatusId).HasColumnName("SeatStatusID");

                entity.Property(e => e.SubscriptionAllocationId).HasColumnName("SubscriptionAllocationID");

                entity.Property(e => e.Tstamp)
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.TblSeatAttribute)
                    .HasForeignKey(d => d.PackageId)
                    .HasConstraintName("FK_tbl_SeatAttribute_Reference_tbl_Package");

                entity.HasOne(d => d.Seat)
                    .WithMany(p => p.TblSeatAttribute)
                    .HasForeignKey(d => d.SeatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SeatAttribute_Reference_tbl_Seat");

                entity.HasOne(d => d.SeatStatus)
                    .WithMany(p => p.TblSeatAttribute)
                    .HasForeignKey(d => d.SeatStatusId)
                    .HasConstraintName("FK_tbl_SeatAttribute_Reference_tbl_SeatStatus");

                entity.HasOne(d => d.SubscriptionAllocation)
                    .WithMany(p => p.TblSeatAttribute)
                    .HasForeignKey(d => d.SubscriptionAllocationId)
                    .HasConstraintName("FK_tbl_SeatAttribute_Reference_tbl_SubscriptionAllocation");
            });

            modelBuilder.Entity<TblSeatingGroup>(entity =>
            {
                entity.HasKey(e => e.SeatingGroupId);

                entity.ToTable("tbl_SeatingGroup");

                entity.Property(e => e.SeatingGroupId).HasColumnName("SeatingGroupID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LeaderMemberId).HasColumnName("LeaderMemberID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.RequestProcessedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.LeaderMember)
                    .WithMany(p => p.TblSeatingGroup)
                    .HasForeignKey(d => d.LeaderMemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SeatingGroup_tbl_Member");

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblSeatingGroup)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SeatingGroup_tbl_MembershipOrganisation");
            });

            modelBuilder.Entity<TblSeatingGroupMemberJoin>(entity =>
            {
                entity.HasKey(e => new { e.SeatingGroupId, e.OrganisationCustomerId });

                entity.ToTable("tbl_SeatingGroupMemberJoin");

                entity.Property(e => e.SeatingGroupId).HasColumnName("SeatingGroupID");

                entity.Property(e => e.OrganisationCustomerId).HasColumnName("OrganisationCustomerID");

                entity.Property(e => e.AllocationOptionId).HasColumnName("AllocationOptionID");

                entity.Property(e => e.AllocationRequest).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModfiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.OrganisationCustomer)
                    .WithMany(p => p.TblSeatingGroupMemberJoin)
                    .HasForeignKey(d => d.OrganisationCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SeatingGroupMemberJoin_tbl_Member");

                entity.HasOne(d => d.SeatingGroup)
                    .WithMany(p => p.TblSeatingGroupMemberJoin)
                    .HasForeignKey(d => d.SeatingGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SeatingGroupMemberJoin_tbl_SeatingGroup");
            });

            modelBuilder.Entity<TblSeatingPreference>(entity =>
            {
                entity.HasKey(e => e.SeatingPreferenceId);

                entity.ToTable("tbl_SeatingPreference");

                entity.HasIndex(e => e.OrganisationId)
                    .HasName("NCINDEX_tbl_SeatingPreference_OrganisationID");

                entity.HasIndex(e => e.ProductCategoryId)
                    .HasName("NCINDEX_tbl_SeatingPreference_ProductCategoryID");

                entity.HasIndex(e => e.VenueId)
                    .HasName("NCINDEX_tbl_SeatingPreference_VenueID");

                entity.HasIndex(e => new { e.SeatingPreferenceId, e.OrganisationId, e.ProductCategoryId, e.VenueId })
                    .HasName("NCINDEX_tbl_SeatingPreference_SeatingPreferenceID_OrganisationID_ProductCategoryID_VenueID");

                entity.Property(e => e.SeatingPreferenceId).HasColumnName("SeatingPreferenceID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.OriginBaa)
                    .HasColumnName("OriginBAA")
                    .HasMaxLength(3);

                entity.Property(e => e.ProductCategoryId).HasColumnName("ProductCategoryID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.VenueId).HasColumnName("VenueID");

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblSeatingPreference)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SeatingPreference_tblOrganisation");

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.TblSeatingPreference)
                    .HasForeignKey(d => d.ProductCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SeatingPreference_tbl_ProductCategory");

                entity.HasOne(d => d.Venue)
                    .WithMany(p => p.TblSeatingPreference)
                    .HasForeignKey(d => d.VenueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SeatingPreference_tbl_Venue");
            });

            modelBuilder.Entity<TblSeatStatus>(entity =>
            {
                entity.HasKey(e => e.SeatStatusId);

                entity.ToTable("tbl_SeatStatus");

                entity.Property(e => e.SeatStatusId).HasColumnName("SeatStatusID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.SeasonSeatMapId).HasColumnName("SeasonSeatMapID");

                entity.Property(e => e.SeatStatusName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.SourceSeatStatusCode).HasColumnType("char(1)");

                entity.Property(e => e.Tstamp)
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblSeatStatus)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SeatStatus_Reference_tblOrganisation");

                entity.HasOne(d => d.SeasonSeatMap)
                    .WithMany(p => p.TblSeatStatus)
                    .HasForeignKey(d => d.SeasonSeatMapId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SeatStatus_Reference_tbl_SeasonSeatMap");
            });

            modelBuilder.Entity<TblSeatZone>(entity =>
            {
                entity.HasKey(e => e.SeatZoneId);

                entity.ToTable("tbl_SeatZone");

                entity.Property(e => e.SeatZoneId).HasColumnName("SeatZoneID");

                entity.Property(e => e.BestAvailableArea)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CreatedDAte")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.SeasonId).HasColumnName("SeasonID");

                entity.Property(e => e.SeatZoneDescription).HasColumnType("ntext");

                entity.Property(e => e.SeatZoneName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Section).HasMaxLength(250);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblSeatZone)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SeatZone_Reference_tblOrganisation");

                entity.HasOne(d => d.Season)
                    .WithMany(p => p.TblSeatZone)
                    .HasForeignKey(d => d.SeasonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SeatZone_Reference_tbl_Season");
            });

            modelBuilder.Entity<TblSeatZonePreference>(entity =>
            {
                entity.HasKey(e => e.SeatZonePreferenceId);

                entity.ToTable("tbl_SeatZonePreference");

                entity.Property(e => e.SeatZonePreferenceId).HasColumnName("SeatZonePreferenceID");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.SeatZonePreferenceDescription).HasColumnType("ntext");

                entity.Property(e => e.SeatZonePreferenceName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblSeatZonePreference)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SeatZonePreference_tblOrganisation");
            });

            modelBuilder.Entity<TblSellerClass>(entity =>
            {
                entity.HasKey(e => e.SellerClassId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tbl_SellerClass");

                entity.Property(e => e.SellerClassId).HasColumnName("SellerClassID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SellerClassDesc).HasMaxLength(50);

                entity.Property(e => e.Tstamp)
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblSessionType>(entity =>
            {
                entity.HasKey(e => e.SessionTypeId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tbl_SessionType");

                entity.Property(e => e.SessionTypeId).HasColumnName("SessionTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SessionDesc).HasMaxLength(50);

                entity.Property(e => e.SessionTypeCode).HasMaxLength(1);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblSharedStore>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.ToTable("tbl_SharedStore");

                entity.Property(e => e.Key)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnType("xml");
            });

            modelBuilder.Entity<TblShippingRecord>(entity =>
            {
                entity.HasKey(e => e.ShippingRecordId);

                entity.ToTable("tblShippingRecord");

                entity.Property(e => e.ShippingRecordId)
                    .HasColumnName("ShippingRecordID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address1).HasMaxLength(200);

                entity.Property(e => e.Address2).HasMaxLength(200);

                entity.Property(e => e.Address3).HasMaxLength(200);

                entity.Property(e => e.Apartment).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(200);

                entity.Property(e => e.Comment).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.CountryCode).HasMaxLength(10);

                entity.Property(e => e.CountryName).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerName).HasMaxLength(100);

                entity.Property(e => e.Dpid)
                    .HasColumnName("DPID")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.Zip).HasMaxLength(20);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TblShippingRecord)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblOrder_tblShippingRecord_FK1");

                entity.HasOne(d => d.ShippingRecord)
                    .WithOne(p => p.TblShippingRecord)
                    .HasForeignKey<TblShippingRecord>(d => d.ShippingRecordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblShippingRecord_tblOriginShippingRecordMap_FK1");
            });

            modelBuilder.Entity<TblShoppingCart>(entity =>
            {
                entity.HasKey(e => e.CartId);

                entity.ToTable("tbl_ShoppingCart");

                entity.Property(e => e.CartId).HasColumnName("CartID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationCustomerId).HasColumnName("OrganisationCustomerID");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.ReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.OrganisationCustomer)
                    .WithMany(p => p.TblShoppingCart)
                    .HasForeignKey(d => d.OrganisationCustomerId)
                    .HasConstraintName("FK_tbl_ShoppingCart_tblOrganisationCustomer");

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblShoppingCart)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ShoppingCart_tblOrganisation");
            });

            modelBuilder.Entity<TblShoppingCartItem>(entity =>
            {
                entity.HasKey(e => e.CartItemId);

                entity.ToTable("tbl_ShoppingCartItem");

                entity.Property(e => e.CartItemId).HasColumnName("CartItemID");

                entity.Property(e => e.CartId).HasColumnName("CartID");

                entity.Property(e => e.ColorId)
                    .HasColumnName("ColorID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomValueId)
                    .HasColumnName("CustomValueID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CustomizedText)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExtraCustomValueId)
                    .HasColumnName("ExtraCustomValueID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PriceTypeId).HasColumnName("PriceTypeID");

                entity.Property(e => e.ProductCategoryId).HasColumnName("ProductCategoryID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ShoppingCartProductType).HasDefaultValueSql("((0))");

                entity.Property(e => e.SizeId)
                    .HasColumnName("SizeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.PriceType)
                    .WithMany(p => p.TblShoppingCartItem)
                    .HasForeignKey(d => d.PriceTypeId)
                    .HasConstraintName("FK_tbl_ShoppingCartItem_tbl_PriceType");

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.TblShoppingCartItem)
                    .HasForeignKey(d => d.ProductCategoryId)
                    .HasConstraintName("FK_tbl_ShoppingCartItem_tbl_ProductCategory");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblShoppingCartItem)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_tbl_ShoppingCartItem_tbl_Product");
            });

            modelBuilder.Entity<TblShow>(entity =>
            {
                entity.HasKey(e => e.ShowId);

                entity.ToTable("tbl_Show");

                entity.Property(e => e.ShowId).HasColumnName("ShowID");

                entity.Property(e => e.Comments).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Tstamp)
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<TblShowInformation>(entity =>
            {
                entity.HasKey(e => e.ShowInformationId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tbl_ShowInformation");

                entity.Property(e => e.ShowInformationId).HasColumnName("ShowInformationID");

                entity.Property(e => e.AccountFile).HasColumnType("char(3)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomAbn)
                    .HasColumnName("CustomABN")
                    .HasMaxLength(15);

                entity.Property(e => e.EventType)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.MarketingType1).HasMaxLength(8);

                entity.Property(e => e.MarketingType2).HasMaxLength(8);

                entity.Property(e => e.MarketingType3).HasMaxLength(8);

                entity.Property(e => e.MarketingType4).HasMaxLength(8);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NickName).HasMaxLength(8);

                entity.Property(e => e.ShowAbn).HasColumnName("ShowABN");

                entity.Property(e => e.ShowVenueId).HasColumnName("ShowVenueID");

                entity.Property(e => e.ShowWebSiteUrl)
                    .HasColumnName("ShowWebSiteURL")
                    .HasMaxLength(128);

                entity.Property(e => e.Tstamp)
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.ShowVenue)
                    .WithMany(p => p.TblShowInformation)
                    .HasForeignKey(d => d.ShowVenueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ShowInformation_tbl_ShowVenue");
            });

            modelBuilder.Entity<TblShowItem>(entity =>
            {
                entity.HasKey(e => e.ShowItemId);

                entity.ToTable("tbl_ShowItem");

                entity.HasIndex(e => e.ShowItemTypeId)
                    .HasName("IC_tbl_ShowItem_ShowItemTypeID");

                entity.HasIndex(e => new { e.ShowItemTypeId, e.ItemId })
                    .HasName("UC_tbl_ShowItem_ShowItemTypeID_ItemID")
                    .IsUnique();

                entity.HasIndex(e => new { e.ShowItemId, e.ShowItemTypeId, e.ItemId })
                    .HasName("NCINDEX_tbl_ShowItem_ItemID_inc_ShowItemID_ShowItemTypeID");

                entity.Property(e => e.ShowItemId).HasColumnName("ShowItemID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExclusiveEndDate).HasColumnType("datetime");

                entity.Property(e => e.ExclusiveStartDate).HasColumnType("datetime");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ShowItemTypeId).HasColumnName("ShowItemTypeID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.ShowItemType)
                    .WithMany(p => p.TblShowItem)
                    .HasForeignKey(d => d.ShowItemTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ShowItem_ShowItemTypeID");
            });

            modelBuilder.Entity<TblShowItemType>(entity =>
            {
                entity.HasKey(e => e.ShowItemTypeId);

                entity.ToTable("tbl_ShowItemType");

                entity.HasIndex(e => e.ShowItemTypeName)
                    .HasName("UC_tbl_ShowItemType_ShowItemTypeName")
                    .IsUnique();

                entity.Property(e => e.ShowItemTypeId)
                    .HasColumnName("ShowItemTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ShowItemTypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblShowTag>(entity =>
            {
                entity.HasKey(e => e.ShowTagId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tbl_ShowTag");

                entity.Property(e => e.ShowTagId).HasColumnName("ShowTagID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(42);

                entity.Property(e => e.DescriptionVenue).HasMaxLength(6);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Owner1).HasMaxLength(8);

                entity.Property(e => e.Owner2).HasMaxLength(8);

                entity.Property(e => e.Owner3).HasMaxLength(8);

                entity.Property(e => e.Owner4).HasMaxLength(8);

                entity.Property(e => e.ShowTag).HasMaxLength(11);

                entity.Property(e => e.ShowTagParentId).HasColumnName("ShowTagParentID");

                entity.Property(e => e.ShowType).HasMaxLength(6);

                entity.Property(e => e.ShowVenueId).HasColumnName("ShowVenueID");

                entity.Property(e => e.Tstamp)
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.ShowVenue)
                    .WithMany(p => p.TblShowTag)
                    .HasForeignKey(d => d.ShowVenueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ShowTag_tbl_ShowVenue");
            });

            modelBuilder.Entity<TblShowTime>(entity =>
            {
                entity.HasKey(e => new { e.ShowTimeId, e.ShowVenueId })
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tbl_ShowTime");

                entity.Property(e => e.ShowTimeId)
                    .HasColumnName("ShowTimeID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ShowVenueId).HasColumnName("ShowVenueID");

                entity.Property(e => e.BoxOfficeOpens).HasMaxLength(5);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DoorOpens).HasMaxLength(5);

                entity.Property(e => e.Finish).HasMaxLength(5);

                entity.Property(e => e.Interval1).HasMaxLength(5);

                entity.Property(e => e.Interval2).HasMaxLength(5);

                entity.Property(e => e.MainAct).HasMaxLength(5);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Support1).HasMaxLength(5);

                entity.Property(e => e.Support2).HasMaxLength(5);

                entity.Property(e => e.Support3).HasMaxLength(5);

                entity.Property(e => e.Tstamp)
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.ShowVenue)
                    .WithMany(p => p.TblShowTime)
                    .HasForeignKey(d => d.ShowVenueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ShowTime_tbl_ShowVenue");
            });

            modelBuilder.Entity<TblShowType>(entity =>
            {
                entity.HasKey(e => e.ShowTypeId);

                entity.ToTable("tbl_ShowType");

                entity.Property(e => e.ShowTypeId).HasColumnName("ShowTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ShowType).HasMaxLength(6);

                entity.Property(e => e.ShowTypeDesc).HasMaxLength(50);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblShowVenue>(entity =>
            {
                entity.HasKey(e => e.ShowVenueId);

                entity.ToTable("tbl_ShowVenue");

                entity.Property(e => e.ShowVenueId).HasColumnName("ShowVenueID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PromoterContactId).HasColumnName("PromoterContactID");

                entity.Property(e => e.PromoterId).HasColumnName("PromoterID");

                entity.Property(e => e.ShowTitle).HasMaxLength(100);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.VenueContactId).HasColumnName("VenueContactID");

                entity.Property(e => e.VenueId).HasColumnName("VenueID");

                entity.HasOne(d => d.PromoterContact)
                    .WithMany(p => p.TblShowVenuePromoterContact)
                    .HasForeignKey(d => d.PromoterContactId)
                    .HasConstraintName("FK_tbl_ShowVenue_Ref_tbl_BusinessContact_BusinessContactID");

                entity.HasOne(d => d.Promoter)
                    .WithMany(p => p.TblShowVenue)
                    .HasForeignKey(d => d.PromoterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ShowVenue_tbl_Promoter");

                entity.HasOne(d => d.VenueContact)
                    .WithMany(p => p.TblShowVenueVenueContact)
                    .HasForeignKey(d => d.VenueContactId)
                    .HasConstraintName("FK_tbl_ShowVenue_Ref_tbl_BusinessContact_VenueContactID");

                entity.HasOne(d => d.Venue)
                    .WithMany(p => p.TblShowVenue)
                    .HasForeignKey(d => d.VenueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ShowVenue_tbl_Venue");
            });

            modelBuilder.Entity<TblShowVenueBookingFee>(entity =>
            {
                entity.HasKey(e => e.BfeeClassId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tbl_ShowVenueBookingFee");

                entity.Property(e => e.BfeeClassId).HasColumnName("BFeeClassID");

                entity.Property(e => e.BfeePerTicket)
                    .HasColumnName("BFeePerTicket")
                    .HasColumnType("money");

                entity.Property(e => e.BfeePerTrans).HasColumnType("money");

                entity.Property(e => e.CalculatePerTicketBfee)
                    .HasColumnName("CalculatePerTicketBFee")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MaximumBfeePerTrans)
                    .HasColumnName("MaximumBFeePerTrans")
                    .HasColumnType("money");

                entity.Property(e => e.MinimumBfeePerTrans)
                    .HasColumnName("MinimumBFeePerTrans")
                    .HasColumnType("money");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SellerClassId).HasColumnName("SellerClassID");

                entity.Property(e => e.ShowVenueId).HasColumnName("ShowVenueID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.UseSuppBfee).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.SellerClass)
                    .WithMany(p => p.TblShowVenueBookingFee)
                    .HasForeignKey(d => d.SellerClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ShowVenue)
                    .WithMany(p => p.TblShowVenueBookingFee)
                    .HasForeignKey(d => d.ShowVenueId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblShowVenueDispatchTimes>(entity =>
            {
                entity.HasKey(e => e.DispatchTimeId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tbl_ShowVenueDispatchTimes");

                entity.Property(e => e.DispatchTimeId).HasColumnName("DispatchTimeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeliveryTypeId).HasColumnName("DeliveryTypeID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ShowVenueId).HasColumnName("ShowVenueID");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.StopDate)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.StopTime)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.DeliveryType)
                    .WithMany(p => p.TblShowVenueDispatchTimes)
                    .HasForeignKey(d => d.DeliveryTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ShowVenue)
                    .WithMany(p => p.TblShowVenueDispatchTimes)
                    .HasForeignKey(d => d.ShowVenueId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblShowVenuePerformance>(entity =>
            {
                entity.HasKey(e => e.ShowVenuePerformanceId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tbl_ShowVenuePerformance");

                entity.Property(e => e.ShowVenuePerformanceId).HasColumnName("ShowVenuePerformanceID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EndDateTime).HasColumnType("datetime");

                entity.Property(e => e.EventCode).HasMaxLength(16);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PublishDate).HasColumnType("datetime");

                entity.Property(e => e.ShowVenueId).HasColumnName("ShowVenueID");

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.ShowVenue)
                    .WithMany(p => p.TblShowVenuePerformance)
                    .HasForeignKey(d => d.ShowVenueId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblShowVenuePriceCategory>(entity =>
            {
                entity.HasKey(e => e.ShowVenuePriceCategoryId);

                entity.ToTable("tbl_ShowVenuePriceCategory");

                entity.Property(e => e.ShowVenuePriceCategoryId).HasColumnName("ShowVenuePriceCategoryID");

                entity.Property(e => e.CategoryName).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Pcat).HasColumnName("PCAT");

                entity.Property(e => e.ShowVenueId).HasColumnName("ShowVenueID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.ShowVenue)
                    .WithMany(p => p.TblShowVenuePriceCategory)
                    .HasForeignKey(d => d.ShowVenueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ShowVenuePriceCategory_Ref_tbl_ShowVenue");
            });

            modelBuilder.Entity<TblShowVenuePriceTable>(entity =>
            {
                entity.HasKey(e => e.ShowVenuePriceTableId);

                entity.ToTable("tbl_ShowVenuePriceTable");

                entity.Property(e => e.ShowVenuePriceTableId).HasColumnName("ShowVenuePriceTableID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PriceTableName).HasMaxLength(50);

                entity.Property(e => e.ShowVenueId).HasColumnName("ShowVenueID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.ShowVenue)
                    .WithMany(p => p.TblShowVenuePriceTable)
                    .HasForeignKey(d => d.ShowVenueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ShowVenuePriceTable_Ref_tbl_ShowVenue");
            });

            modelBuilder.Entity<TblShowVenueTicketFormat>(entity =>
            {
                entity.HasKey(e => e.TicketFormatId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tbl_ShowVenueTicketFormat");

                entity.Property(e => e.TicketFormatId).HasColumnName("TicketFormatID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EventComment).HasMaxLength(30);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiptFormatScript).HasMaxLength(8);

                entity.Property(e => e.ShowVenueId).HasColumnName("ShowVenueID");

                entity.Property(e => e.TicketFormatScript).HasMaxLength(8);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.ShowVenue)
                    .WithMany(p => p.TblShowVenueTicketFormat)
                    .HasForeignKey(d => d.ShowVenueId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblShowVenueTicketLine>(entity =>
            {
                entity.HasKey(e => e.TitleLineId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tbl_ShowVenueTicketLine");

                entity.Property(e => e.TitleLineId).HasColumnName("TitleLineID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ShowVenueId).HasColumnName("ShowVenueID");

                entity.Property(e => e.TitleLine).HasMaxLength(24);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.ShowVenue)
                    .WithMany(p => p.TblShowVenueTicketLine)
                    .HasForeignKey(d => d.ShowVenueId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblSitWith>(entity =>
            {
                entity.HasKey(e => e.SitWithId);

                entity.ToTable("tbl_SitWith");

                entity.Property(e => e.SitWithId).HasColumnName("SitWithID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductCategoryId).HasColumnName("ProductCategoryID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.RequestDate).HasColumnType("datetime");

                entity.Property(e => e.RequestingMemberId).HasColumnName("RequestingMemberID");

                entity.Property(e => e.SitWithMemberId).HasColumnName("SitWithMemberID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.TblSitWith)
                    .HasForeignKey(d => d.ProductCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SitWith_ProductCategoryID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblSitWith)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SitWith_ProductID");
            });

            modelBuilder.Entity<TblSourcePerformance>(entity =>
            {
                entity.HasKey(e => e.SourcePerformanceId);

                entity.ToTable("tbl_SourcePerformance");

                entity.Property(e => e.SourcePerformanceId).HasColumnName("SourcePerformanceID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SeasonId).HasColumnName("SeasonID");

                entity.Property(e => e.SeasonSeatMapId).HasColumnName("SeasonSeatMapID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Season)
                    .WithMany(p => p.TblSourcePerformance)
                    .HasForeignKey(d => d.SeasonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SourcePerformance_Reference_tbl_season");
            });

            modelBuilder.Entity<TblSourcePerformancePackageJoin>(entity =>
            {
                entity.HasKey(e => e.SourcePerformancePackageJoinId);

                entity.ToTable("tbl_SourcePerformancePackageJoin");

                entity.Property(e => e.SourcePerformancePackageJoinId).HasColumnName("SourcePerformancePackageJoinID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.SourcePerformanceId).HasColumnName("SourcePerformanceID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.VenueId).HasColumnName("VenueID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblSourcePerformancePackageJoin)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SourcePerformancePackageJoin_Reference_tbl_Package");

                entity.HasOne(d => d.SourcePerformance)
                    .WithMany(p => p.TblSourcePerformancePackageJoin)
                    .HasForeignKey(d => d.SourcePerformanceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SourcePerformancePackageJoin_Reference_tbl_SourcePerformance_SourcePerformanceID");

                entity.HasOne(d => d.Venue)
                    .WithMany(p => p.TblSourcePerformancePackageJoin)
                    .HasForeignKey(d => d.VenueId)
                    .HasConstraintName("FK_tbl_SourcePerformancePackageJoin_Reference_tbl_Venue_VenueID");
            });

            modelBuilder.Entity<TblSourceSeatAttribute>(entity =>
            {
                entity.HasKey(e => e.SourceSeatAttributeId);

                entity.ToTable("tbl_SourceSeatAttribute");

                entity.HasIndex(e => e.SeatId)
                    .HasName("NCINDEX_tbl_SourceSeatAttribute_SeatID");

                entity.Property(e => e.SourceSeatAttributeId).HasColumnName("SourceSeatAttributeID");

                entity.Property(e => e.Afile)
                    .HasColumnName("AFile")
                    .HasMaxLength(5);

                entity.Property(e => e.Comment).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationCustomerId).HasColumnName("OrganisationCustomerID");

                entity.Property(e => e.ParentProductCode).HasMaxLength(50);

                entity.Property(e => e.PcatCode)
                    .HasColumnName("PCatCode")
                    .HasMaxLength(40);

                entity.Property(e => e.PriceTypeCode).HasColumnType("char(1)");

                entity.Property(e => e.PriceTypeType).HasMaxLength(20);

                entity.Property(e => e.ProductCode).HasMaxLength(50);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.SeatId).HasColumnName("SeatID");

                entity.Property(e => e.SourceExportRunDatetime).HasColumnType("datetime");

                entity.Property(e => e.SourcePerformanceCreationKey).HasMaxLength(50);

                entity.Property(e => e.SourcePerformanceId).HasColumnName("SourcePerformanceID");

                entity.Property(e => e.SourceSeatAttributeIssueTypeId).HasColumnName("SourceSeatAttributeIssueTypeID");

                entity.Property(e => e.TransDateTime).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.OrganisationCustomer)
                    .WithMany(p => p.TblSourceSeatAttribute)
                    .HasForeignKey(d => d.OrganisationCustomerId)
                    .HasConstraintName("FK_tbl_SourceSeatAttribute_Reference_tblOrganisation");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblSourceSeatAttribute)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_tbl_SourceSeatAttribute_Reference_tbl_Package");

                entity.HasOne(d => d.Seat)
                    .WithMany(p => p.TblSourceSeatAttribute)
                    .HasForeignKey(d => d.SeatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SourceSeatAttribute_Reference_tbl_Seat");

                entity.HasOne(d => d.SourcePerformance)
                    .WithMany(p => p.TblSourceSeatAttribute)
                    .HasForeignKey(d => d.SourcePerformanceId)
                    .HasConstraintName("FK_tbl_SourceSeatAttribute_Reference_tbl_SourcePerformance");

                entity.HasOne(d => d.SourceSeatAttributeIssueType)
                    .WithMany(p => p.TblSourceSeatAttribute)
                    .HasForeignKey(d => d.SourceSeatAttributeIssueTypeId)
                    .HasConstraintName("FK_tbl_SourceSeatAttribute_Reference_tbl_SourceSeatAttributeIssueType");
            });

            modelBuilder.Entity<TblSourceSeatAttributeAudit>(entity =>
            {
                entity.HasKey(e => e.SourceSeatAttributeAuditId);

                entity.ToTable("tbl_SourceSeatAttributeAudit");

                entity.Property(e => e.SourceSeatAttributeAuditId).HasColumnName("SourceSeatAttributeAuditID");

                entity.Property(e => e.Afile)
                    .HasColumnName("AFile")
                    .HasMaxLength(5);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationCustomerId).HasColumnName("OrganisationCustomerID");

                entity.Property(e => e.ParentProductCode).HasMaxLength(50);

                entity.Property(e => e.PcatCode)
                    .HasColumnName("PCatCode")
                    .HasMaxLength(40);

                entity.Property(e => e.PriceTypeCode).HasColumnType("char(1)");

                entity.Property(e => e.PriceTypeType).HasMaxLength(20);

                entity.Property(e => e.ProductCode).HasMaxLength(50);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.SeatAttributeId).HasColumnName("SeatAttributeID");

                entity.Property(e => e.SeatId).HasColumnName("SeatID");

                entity.Property(e => e.SourcePerformanceId).HasColumnName("SourcePerformanceID");

                entity.Property(e => e.SourceSeatAttributeId).HasColumnName("SourceSeatAttributeID");

                entity.Property(e => e.SourceSeatAttributeIssueTypeId).HasColumnName("SourceSeatAttributeIssueTypeID");

                entity.Property(e => e.TransDateTime).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.SourceSeatAttributeIssueType)
                    .WithMany(p => p.TblSourceSeatAttributeAudit)
                    .HasForeignKey(d => d.SourceSeatAttributeIssueTypeId)
                    .HasConstraintName("FK_tbl_SourceSeatAttributeAudit_Reference_tbl_SourceSeatAttributeIssueType");
            });

            modelBuilder.Entity<TblSourceSeatAttributeIssueType>(entity =>
            {
                entity.HasKey(e => e.SourceSeatAttributeIssueTypeId);

                entity.ToTable("tbl_SourceSeatAttributeIssueType");

                entity.Property(e => e.SourceSeatAttributeIssueTypeId).HasColumnName("SourceSeatAttributeIssueTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SourceSeatAttributeIssueTypeCode).HasColumnType("char(1)");

                entity.Property(e => e.SourceSeatAttributeIssueTypeName).HasMaxLength(100);

                entity.Property(e => e.Tstamp)
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblStagingOriginAccount>(entity =>
            {
                entity.HasKey(e => new { e.Anum, e.AfileCode });

                entity.ToTable("tblStagingOriginAccount");

                entity.HasIndex(e => e.AdmitQty)
                    .HasName("UNCLIDX_tblStagingOriginAccount_admit_qty");

                entity.Property(e => e.Anum).HasColumnName("anum");

                entity.Property(e => e.AfileCode)
                    .HasColumnName("afile_code")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AccountComment)
                    .HasColumnName("account_comment")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AccountTypeCode).HasColumnName("account_type_code");

                entity.Property(e => e.AccountTypeName)
                    .HasColumnName("account_type_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Address1)
                    .HasColumnName("address1")
                    .HasMaxLength(34)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("address2")
                    .HasMaxLength(34)
                    .IsUnicode(false);

                entity.Property(e => e.Address3)
                    .HasColumnName("address3")
                    .HasMaxLength(34)
                    .IsUnicode(false);

                entity.Property(e => e.AdmitQty).HasColumnName("admit_qty");

                entity.Property(e => e.AlteredDate)
                    .HasColumnName("altered_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Apartment)
                    .HasColumnName("apartment")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("company_name")
                    .HasMaxLength(141)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName2)
                    .HasColumnName("company_name2")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasColumnName("country_code")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("date_of_birth")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeadFlag)
                    .HasColumnName("dead_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DoNotMailFlag)
                    .HasColumnName("do_not_mail_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Dummy)
                    .HasColumnName("dummy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAddress)
                    .HasColumnName("email_address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasColumnName("full_name")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.GroupCategory)
                    .HasColumnName("group_category")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.GroupFlag)
                    .HasColumnName("group_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.HomePhone)
                    .HasColumnName("home_phone")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.LastTransactedDate)
                    .HasColumnName("last_transacted_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LeftAddressFlag)
                    .HasColumnName("left_address_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MemberSince)
                    .HasColumnName("member_since")
                    .HasColumnType("datetime");

                entity.Property(e => e.MembershipCategory)
                    .HasColumnName("membership_category")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.MembershipEntitlement).HasColumnName("membership_entitlement");

                entity.Property(e => e.MembershipFinancialFlag)
                    .HasColumnName("membership_financial_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MembershipId)
                    .HasColumnName("membership_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasColumnName("middle_name")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.OtherPhones)
                    .HasColumnName("other_phones")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneAreaCode)
                    .HasColumnName("phone_area_code")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PrepaidFunds)
                    .HasColumnName("prepaid_funds")
                    .HasColumnType("money");

                entity.Property(e => e.PrimaryAfileCode)
                    .HasColumnName("primary_afile_code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryAnum).HasColumnName("primary_anum");

                entity.Property(e => e.RandomUrn)
                    .HasColumnName("random_urn")
                    .HasColumnType("decimal(14, 0)");

                entity.Property(e => e.SalesAmt)
                    .HasColumnName("sales_amt")
                    .HasColumnType("money");

                entity.Property(e => e.SentToAcxiomFlag)
                    .HasColumnName("sent_to_acxiom_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SiteSpecificAttribute)
                    .HasColumnName("site_specific_attribute")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SortName)
                    .HasColumnName("sort_name")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.SubAddress1)
                    .HasColumnName("sub_address1")
                    .HasMaxLength(34)
                    .IsUnicode(false);

                entity.Property(e => e.SubAddress2)
                    .HasColumnName("sub_address2")
                    .HasMaxLength(34)
                    .IsUnicode(false);

                entity.Property(e => e.SubAddress3)
                    .HasColumnName("sub_address3")
                    .HasMaxLength(34)
                    .IsUnicode(false);

                entity.Property(e => e.SubCity)
                    .HasColumnName("sub_city")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SubComment1)
                    .HasColumnName("sub_comment1")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SubComment2)
                    .HasColumnName("sub_comment2")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SubComment3)
                    .HasColumnName("sub_comment3")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SubComment4)
                    .HasColumnName("sub_comment4")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SubComment5)
                    .HasColumnName("sub_comment5")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SubComment6)
                    .HasColumnName("sub_comment6")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SubCountryCode)
                    .HasColumnName("sub_country_code")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SubDataFlag)
                    .HasColumnName("sub_data_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SubName)
                    .HasColumnName("sub_name")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.SubSiteSpecificAttribute)
                    .HasColumnName("sub_site_specific_attribute")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SubZip)
                    .HasColumnName("sub_zip")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SubsPrevQty).HasColumnName("subs_prev_qty");

                entity.Property(e => e.SubsQty).HasColumnName("subs_qty");

                entity.Property(e => e.TicketekAdminOnlyFlag)
                    .HasColumnName("ticketek_admin_only_flag")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasColumnName("zip")
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblStandardPriceType>(entity =>
            {
                entity.HasKey(e => e.PriceTypeId);

                entity.ToTable("tbl_StandardPriceType");

                entity.Property(e => e.PriceTypeId).HasColumnName("PriceTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PriceMarketingTypeId).HasColumnName("PriceMarketingTypeID");

                entity.Property(e => e.PriceTypeClassId).HasColumnName("PriceTypeClassID");

                entity.Property(e => e.PriceTypeCode).HasMaxLength(5);

                entity.Property(e => e.PriceTypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ShowVenuePriceTableId).HasColumnName("ShowVenuePriceTableID");

                entity.Property(e => e.TicketPrintName)
                    .IsRequired()
                    .HasMaxLength(9);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.PriceMarketingType)
                    .WithMany(p => p.TblStandardPriceType)
                    .HasForeignKey(d => d.PriceMarketingTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_StandardPriceType_Ref_tbl_PriceMarketingType");

                entity.HasOne(d => d.PriceTypeClass)
                    .WithMany(p => p.TblStandardPriceType)
                    .HasForeignKey(d => d.PriceTypeClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_StandardPriceType_Ref_tbl_PriceTypeClass");

                entity.HasOne(d => d.ShowVenuePriceTable)
                    .WithMany(p => p.TblStandardPriceType)
                    .HasForeignKey(d => d.ShowVenuePriceTableId)
                    .HasConstraintName("FK_tbl_StandardPriceType_Ref_tbl_ShowVenuePriceTable");
            });

            modelBuilder.Entity<TblSubscription>(entity =>
            {
                entity.HasKey(e => e.SubscriptionId);

                entity.ToTable("tbl_Subscription");

                entity.HasIndex(e => e.OrderLineId)
                    .HasName("NCLIDX_tbl_Subscription_OrderLineID");

                entity.HasIndex(e => e.OrganisationCustomerId)
                    .HasName("NCLIDX_tbl_Subscription_OrganisationCustomerID");

                entity.HasIndex(e => e.PriceTypeId)
                    .HasName("NCLIDX_tbl_Subscription_PriceTypeID");

                entity.HasIndex(e => e.ProductCategoryId)
                    .HasName("NCLIDX_tbl_Subscription_ProductCategoryID");

                entity.HasIndex(e => e.ProductId)
                    .HasName("NCLIDX_tbl_Subscription_ProductID");

                entity.HasIndex(e => e.RenewSubscriptionId)
                    .HasName("NCLIDX_tbl_Subscription_RenewSubscriptionID");

                entity.HasIndex(e => e.SubscriptionStatusId)
                    .HasName("NCLIDX_tbl_Subscription_SubscriptionStatusID");

                entity.HasIndex(e => new { e.TransactionDate, e.TransactionNum })
                    .HasName("NCINDEX_tbl_Subscription_TransactionDate_TransactionNum");

                entity.HasIndex(e => new { e.OrderLineId, e.OrganisationCustomerId, e.SubscriptionId, e.TransactionNum, e.ProductId, e.TransactionDate })
                    .HasName("NCINDEX_tbl_Subscription_ProductID_TransactionDate_inc_2_3_4_19");

                entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExtRef).HasMaxLength(10);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderLineId).HasColumnName("OrderLineID");

                entity.Property(e => e.OrganisationCustomerId).HasColumnName("OrganisationCustomerID");

                entity.Property(e => e.PaxcardId).HasColumnName("PaxcardID");

                entity.Property(e => e.PriceTypeId).HasColumnName("PriceTypeID");

                entity.Property(e => e.ProductCategoryId).HasColumnName("ProductCategoryID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.RenewSubscriptionId).HasColumnName("RenewSubscriptionID");

                entity.Property(e => e.RenewalFlagModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SubscriptionStatusId).HasColumnName("SubscriptionStatusID");

                entity.Property(e => e.TransferredDate).HasColumnType("datetime");

                entity.Property(e => e.TransferredFromSubscriptionId).HasColumnName("TransferredFromSubscriptionID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.OrderLine)
                    .WithMany(p => p.TblSubscription)
                    .HasForeignKey(d => d.OrderLineId)
                    .HasConstraintName("FK_TBL_SUBS_FK_SUBSCR_TBL_ORDE");

                entity.HasOne(d => d.OrganisationCustomer)
                    .WithMany(p => p.TblSubscription)
                    .HasForeignKey(d => d.OrganisationCustomerId)
                    .HasConstraintName("FK_TBL_SUBS_FK_SUBSCR_TBLORGAN");

                entity.HasOne(d => d.Paxcard)
                    .WithMany(p => p.TblSubscription)
                    .HasForeignKey(d => d.PaxcardId)
                    .HasConstraintName("FK_tbl_Subscription_REF_tbl_Paxcard");

                entity.HasOne(d => d.PriceType)
                    .WithMany(p => p.TblSubscription)
                    .HasForeignKey(d => d.PriceTypeId)
                    .HasConstraintName("FK_TBL_SUBS_FK_SUBSCR_TBL_PRIC");

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.TblSubscription)
                    .HasForeignKey(d => d.ProductCategoryId)
                    .HasConstraintName("FK_Subscription_Reference_ProductCategory");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblSubscription)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Subscription_Reference_Product");

                entity.HasOne(d => d.RenewSubscription)
                    .WithMany(p => p.InverseRenewSubscription)
                    .HasForeignKey(d => d.RenewSubscriptionId)
                    .HasConstraintName("FK_tbl_Subscription_RenewSubscriptionID");

                entity.HasOne(d => d.SubscriptionStatus)
                    .WithMany(p => p.TblSubscription)
                    .HasForeignKey(d => d.SubscriptionStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Subscription_Reference_SubscriptionStatus");

                entity.HasOne(d => d.TransferredFromSubscription)
                    .WithMany(p => p.InverseTransferredFromSubscription)
                    .HasForeignKey(d => d.TransferredFromSubscriptionId)
                    .HasConstraintName("FK_tbl_Subscription_TransferredFromSubscriptionID");
            });

            modelBuilder.Entity<TblSubscription1>(entity =>
            {
                entity.HasKey(e => e.SubscriptionId);

                entity.ToTable("tblSubscription");

                entity.HasIndex(e => e.SubscriptionName)
                    .HasName("uc_tblSubscription_SubscriptionName")
                    .IsUnique();

                entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Label).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SubscriptionName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblSubscriptionAllocation>(entity =>
            {
                entity.HasKey(e => e.SubscriptionAllocationId);

                entity.ToTable("tbl_SubscriptionAllocation");

                entity.HasIndex(e => e.SubscriptionId)
                    .HasName("NCLIDX_tbl_SubscriptionAllocation_SubscriptionID");

                entity.HasIndex(e => new { e.SubscriptionAllocationId, e.SubscriptionId, e.Section, e.Row, e.Seat, e.VenueId })
                    .HasName("NCINDEX_tbl_SubscriptionAllocation_VenueID_inc_1_2_3_4_5");

                entity.Property(e => e.SubscriptionAllocationId).HasColumnName("SubscriptionAllocationID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PaxcardAllocationId).HasColumnName("PaxcardAllocationID");

                entity.Property(e => e.Row).HasMaxLength(10);

                entity.Property(e => e.Seat).HasMaxLength(10);

                entity.Property(e => e.Section).HasMaxLength(12);

                entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.VenueId).HasColumnName("VenueID");

                entity.HasOne(d => d.PaxcardAllocation)
                    .WithMany(p => p.TblSubscriptionAllocation)
                    .HasForeignKey(d => d.PaxcardAllocationId)
                    .HasConstraintName("FK_tbl_SubscriptionAllocation_REF_tbl_PaxcardAllocation");

                entity.HasOne(d => d.Subscription)
                    .WithMany(p => p.TblSubscriptionAllocation)
                    .HasForeignKey(d => d.SubscriptionId)
                    .HasConstraintName("FK_SubscriptionAllocation_Reference_Subscription");

                entity.HasOne(d => d.Venue)
                    .WithMany(p => p.TblSubscriptionAllocation)
                    .HasForeignKey(d => d.VenueId)
                    .HasConstraintName("FK_tbl_SubscriptionAllocation_VenueID");
            });

            modelBuilder.Entity<TblSubscriptionAllocationPreferred>(entity =>
            {
                entity.HasKey(e => e.SubscriptionAllocationPreferredId);

                entity.ToTable("tbl_SubscriptionAllocationPreferred");

                entity.Property(e => e.SubscriptionAllocationPreferredId).HasColumnName("SubscriptionAllocationPreferredID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Row).HasMaxLength(10);

                entity.Property(e => e.Seat).HasMaxLength(10);

                entity.Property(e => e.Section).HasMaxLength(12);

                entity.Property(e => e.SubscriptionAllocationId).HasColumnName("SubscriptionAllocationID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.SubscriptionAllocation)
                    .WithMany(p => p.TblSubscriptionAllocationPreferred)
                    .HasForeignKey(d => d.SubscriptionAllocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SubscriptionAllocationPreferred_tbl_SubscriptionAllocation");
            });

            modelBuilder.Entity<TblSubscriptionChoice>(entity =>
            {
                entity.HasKey(e => e.SubscriptionChoiceId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblSubscriptionChoice");

                entity.HasIndex(e => e.SubscriptionId)
                    .HasName("IX_tblSubscriptionChoice_SubscriptionID_SubscriptionChoiceID")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.SubscriptionChoiceId).HasColumnName("SubscriptionChoiceID");

                entity.Property(e => e.ChoiceName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DisplayLabel).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Subscription)
                    .WithMany(p => p.TblSubscriptionChoice)
                    .HasForeignKey(d => d.SubscriptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblSubscriptionService_tblSubscriptionData_FK1");
            });

            modelBuilder.Entity<TblSubscriptionPackageVenue>(entity =>
            {
                entity.HasKey(e => new { e.PackageId, e.VenueId })
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tbl_SubscriptionPackageVenue");

                entity.Property(e => e.PackageId).HasColumnName("PackageID");

                entity.Property(e => e.VenueId).HasColumnName("VenueID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.TblSubscriptionPackageVenue)
                    .HasForeignKey(d => d.PackageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SubscriptionVenue_tbl_Package");

                entity.HasOne(d => d.Venue)
                    .WithMany(p => p.TblSubscriptionPackageVenue)
                    .HasForeignKey(d => d.VenueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SubscriptionVenue_tbl_Venue");
            });

            modelBuilder.Entity<TblSubscriptionPremiumSms>(entity =>
            {
                entity.HasKey(e => e.SubscriptionId);

                entity.ToTable("tbl_SubscriptionPremiumSMS");

                entity.HasIndex(e => e.PhoneNumber)
                    .HasName("UC_tbl_SubscriptionPremiumSMS_PhoneNumber")
                    .IsUnique();

                entity.Property(e => e.SubscriptionId)
                    .HasColumnName("SubscriptionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Configuration).HasColumnType("xml");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PhoneTypeId).HasColumnName("PhoneTypeID");

                entity.Property(e => e.ServiceType)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.PhoneType)
                    .WithMany(p => p.TblSubscriptionPremiumSms)
                    .HasForeignKey(d => d.PhoneTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SubscriptionPremiumSMS_tblPhoneType");

                entity.HasOne(d => d.Subscription)
                    .WithOne(p => p.TblSubscriptionPremiumSms)
                    .HasForeignKey<TblSubscriptionPremiumSms>(d => d.SubscriptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_SubscriptionPremiumSMS_tblSubscription");
            });

            modelBuilder.Entity<TblSubscriptionStatus>(entity =>
            {
                entity.HasKey(e => e.SubscriptionStatusId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tbl_SubscriptionStatus");

                entity.Property(e => e.SubscriptionStatusId).HasColumnName("SubscriptionStatusID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SubscriptionStatusName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblSysAccessLevel>(entity =>
            {
                entity.HasKey(e => e.AccessLevelId);

                entity.ToTable("tblSysAccessLevel");

                entity.Property(e => e.AccessLevelId)
                    .HasColumnName("AccessLevelID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccessLevelName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblSysApplication>(entity =>
            {
                entity.HasKey(e => e.ApplicationId);

                entity.ToTable("tblSysApplication");

                entity.HasIndex(e => e.ApplicationName)
                    .HasName("uc_tblSysApplication_ApplicationName")
                    .IsUnique();

                entity.Property(e => e.ApplicationId)
                    .HasColumnName("ApplicationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplicationDescription).HasMaxLength(100);

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblSysApplicationConfigAttribute>(entity =>
            {
                entity.HasKey(e => e.AttributeId);

                entity.ToTable("tblSysApplicationConfigAttribute");

                entity.Property(e => e.AttributeId).HasColumnName("AttributeID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.AttributeDataTypeId).HasColumnName("AttributeDataTypeID");

                entity.Property(e => e.AttributeDefaultValue)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AttributeDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AttributeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateTimeValue).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NumericValue).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.TextValue)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblSysAuditLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("tblSysAuditLog");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.ApplicationCategory).HasMaxLength(50);

                entity.Property(e => e.AuditDateTime).HasColumnType("datetime");

                entity.Property(e => e.AuditFunction).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Source).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(50);
            });

            modelBuilder.Entity<TblSysCategoryExceptionLog>(entity =>
            {
                entity.HasKey(e => e.CategoryLogId);

                entity.ToTable("tblSysCategoryExceptionLog");

                entity.Property(e => e.CategoryLogId).HasColumnName("CategoryLogID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TblSysCategoryExceptionLog)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblSysCategoryExceptionLog_tblSysLoggingCategory");

                entity.HasOne(d => d.Log)
                    .WithMany(p => p.TblSysCategoryExceptionLog)
                    .HasForeignKey(d => d.LogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblSysCategoryExceptionLog_tblSysExceptionLog1");
            });

            modelBuilder.Entity<TblSysCategoryLog>(entity =>
            {
                entity.HasKey(e => e.CategoryLogId);

                entity.ToTable("tblSysCategoryLog");

                entity.Property(e => e.CategoryLogId).HasColumnName("CategoryLogID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TblSysCategoryLog)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblSysCategoryLog_tblSysLoggingCategory");

                entity.HasOne(d => d.Log)
                    .WithMany(p => p.TblSysCategoryLog)
                    .HasForeignKey(d => d.LogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblSysCategoryLog_tblSysLog1");
            });

            modelBuilder.Entity<TblSysExceptionLog>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblSysExceptionLog");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.AppDomainName)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.CallStackInformation).HasColumnType("xml");

                entity.Property(e => e.Component).HasMaxLength(200);

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.InnerExceptionType).HasMaxLength(400);

                entity.Property(e => e.InnerText).HasMaxLength(1000);

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Message).HasMaxLength(1500);

                entity.Property(e => e.OuterExceptionType).HasMaxLength(1000);

                entity.Property(e => e.OuterText).HasMaxLength(1000);

                entity.Property(e => e.ProcessId)
                    .HasColumnName("ProcessID")
                    .HasMaxLength(256);

                entity.Property(e => e.ProcessName).HasMaxLength(512);

                entity.Property(e => e.ProductionLevel).HasMaxLength(50);

                entity.Property(e => e.Severity)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.SourceApplication).HasMaxLength(50);

                entity.Property(e => e.ThreadName).HasMaxLength(512);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.TimestampUtc)
                    .HasColumnName("TimestampUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Win32ThreadId)
                    .HasColumnName("Win32ThreadID")
                    .HasMaxLength(128);

                entity.Property(e => e.WindowsAccountName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblSysExceptionLogTest>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblSysExceptionLogTest");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.AppDomainName)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.CallStackInformation).HasColumnType("xml");

                entity.Property(e => e.Component).HasMaxLength(200);

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.InnerExceptionType).HasMaxLength(400);

                entity.Property(e => e.InnerText).HasMaxLength(1000);

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Message).HasMaxLength(1500);

                entity.Property(e => e.OuterExceptionType).HasMaxLength(1000);

                entity.Property(e => e.OuterText).HasMaxLength(1000);

                entity.Property(e => e.ProcessId)
                    .HasColumnName("ProcessID")
                    .HasMaxLength(256);

                entity.Property(e => e.ProcessName).HasMaxLength(512);

                entity.Property(e => e.ProductionLevel).HasMaxLength(50);

                entity.Property(e => e.Severity)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.SourceApplication).HasMaxLength(50);

                entity.Property(e => e.ThreadName).HasMaxLength(512);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.TimestampUtc)
                    .HasColumnName("TimestampUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Win32ThreadId)
                    .HasColumnName("Win32ThreadID")
                    .HasMaxLength(128);

                entity.Property(e => e.WindowsAccountName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblSysGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.ToTable("tblSysGroup");

                entity.HasIndex(e => e.GroupName)
                    .HasName("uc_tblSysGroup_GroupName")
                    .IsUnique();

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.BusinessId).HasColumnName("BusinessID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EmailAddress).HasMaxLength(500);

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GroupTypeId).HasColumnName("GroupTypeID");

                entity.Property(e => e.MailingAddress).HasMaxLength(100);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Business)
                    .WithMany(p => p.TblSysGroup)
                    .HasForeignKey(d => d.BusinessId)
                    .HasConstraintName("FK_tblSysGroup_Ref_tbl_Business_BusinessID");

                entity.HasOne(d => d.GroupType)
                    .WithMany(p => p.TblSysGroup)
                    .HasForeignKey(d => d.GroupTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblSysGroupType_tblSysGroup_FK1");
            });

            modelBuilder.Entity<TblSysGroupType>(entity =>
            {
                entity.HasKey(e => e.GroupTypeId);

                entity.ToTable("tblSysGroupType");

                entity.Property(e => e.GroupTypeId)
                    .HasColumnName("GroupTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GroupTypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblSysLog>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tblSysLog");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.AppDomainName)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.ApplicationId)
                    .HasColumnName("ApplicationID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Message).HasMaxLength(1500);

                entity.Property(e => e.ProcessId)
                    .HasColumnName("ProcessID")
                    .HasMaxLength(256);

                entity.Property(e => e.ProcessName).HasMaxLength(512);

                entity.Property(e => e.ProductionLevel).HasMaxLength(50);

                entity.Property(e => e.Severity)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.SourceApplication).HasMaxLength(50);

                entity.Property(e => e.ThreadName).HasMaxLength(512);

                entity.Property(e => e.Timestamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimestampUtc)
                    .HasColumnName("TimestampUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Win32ThreadId)
                    .HasColumnName("Win32ThreadID")
                    .HasMaxLength(128);

                entity.Property(e => e.WindowsAccountName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblSysLoggingCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("tblSysLoggingCategory");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<TblSysSecurityGroupTask>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("tblSysSecurityGroupTask");

                entity.HasIndex(e => new { e.GroupId, e.TaskId })
                    .HasName("uc_GroupID_TaskID")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.TblSysSecurityGroupTask)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblSysSecurityGroupTask_tblSysGroup");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.TblSysSecurityGroupTask)
                    .HasForeignKey(d => d.TaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblSysSecurityGroupTask_tblSysSecurityTask");
            });

            modelBuilder.Entity<TblSysSecurityOperation>(entity =>
            {
                entity.HasKey(e => e.OperationId);

                entity.ToTable("tblSysSecurityOperation");

                entity.HasIndex(e => e.OperationName)
                    .HasName("uc_tblSysSecurityOperation_OperationName")
                    .IsUnique();

                entity.Property(e => e.OperationId)
                    .HasColumnName("OperationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OperationDescription).HasMaxLength(100);

                entity.Property(e => e.OperationName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.TblSysSecurityOperation)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblSysSecurityOperation_tblSysApplication");
            });

            modelBuilder.Entity<TblSysSecurityTask>(entity =>
            {
                entity.HasKey(e => e.TaskId);

                entity.ToTable("tblSysSecurityTask");

                entity.HasIndex(e => e.TaskName)
                    .HasName("uc_tblSysSecurityTask_TaskName")
                    .IsUnique();

                entity.Property(e => e.TaskId)
                    .HasColumnName("TaskID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TaskDescription).HasMaxLength(100);

                entity.Property(e => e.TaskName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.TblSysSecurityTask)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblSysSecurityTask_tblSysApplication");
            });

            modelBuilder.Entity<TblSysSecurityTaskOperation>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("tblSysSecurityTaskOperation");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OperationId).HasColumnName("OperationID");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.HasOne(d => d.Operation)
                    .WithMany(p => p.TblSysSecurityTaskOperation)
                    .HasForeignKey(d => d.OperationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblSysSecurityTaskOperation_tblSysSecurityOperation");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.TblSysSecurityTaskOperation)
                    .HasForeignKey(d => d.TaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblSysSecurityTaskOperation_tblSysSecurityTask");
            });

            modelBuilder.Entity<TblSysUser>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("tblSysUser");

                entity.HasIndex(e => e.FirstName)
                    .HasName("IX_tblSysUser_Firstname");

                entity.HasIndex(e => e.LastName)
                    .HasName("IX_tblSysUser_Lastname");

                entity.HasIndex(e => e.UserName)
                    .HasName("uc_tblSysUser_UserName")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Domain)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("(N'EVEREST\\')");

                entity.Property(e => e.EmailAddress).HasMaxLength(500);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.HomeAddress).HasMaxLength(500);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.Location).HasMaxLength(50);

                entity.Property(e => e.MailingAddress).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblSysUserGroup>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("tblSysUserGroup");

                entity.HasIndex(e => new { e.GroupId, e.UserId })
                    .HasName("IX_GroupID_UserID");

                entity.HasIndex(e => new { e.UserId, e.GroupId })
                    .HasName("uc_UserID_GroupID")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.TblSysUserGroup)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblSysGroup_tblSysUserGroup_FK1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TblSysUserGroup)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblSysUser_tblSysUserGroup_FK1");
            });

            modelBuilder.Entity<TblSysUserMonitor>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("tblSysUserMonitor");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LastAccessedDate).HasColumnType("datetime");

                entity.Property(e => e.PasswordExpiry).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.TblSysUserMonitor)
                    .HasForeignKey<TblSysUserMonitor>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblSysUser_tblSysUserMonitor_FK1");
            });

            modelBuilder.Entity<TblSysUserPreference>(entity =>
            {
                entity.HasKey(e => e.UserPreferenceId);

                entity.ToTable("tblSysUserPreference");

                entity.Property(e => e.UserPreferenceId).HasColumnName("UserPreferenceID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.AttributeDataTypeId).HasColumnName("AttributeDataTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.UserPreferenceName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.TblSysUserPreference)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblSysUserPreference_REF_tblSysApplication");

                entity.HasOne(d => d.AttributeDataType)
                    .WithMany(p => p.TblSysUserPreference)
                    .HasForeignKey(d => d.AttributeDataTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblSysUserPreference_REF_tblAttributeDataType");
            });

            modelBuilder.Entity<TblSysUserPreferenceChoice>(entity =>
            {
                entity.HasKey(e => e.UserPreferenceChoiceId);

                entity.ToTable("tblSysUserPreferenceChoice");

                entity.Property(e => e.UserPreferenceChoiceId).HasColumnName("UserPreferenceChoiceID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.UserPreferenceChoiceName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UserPreferenceId).HasColumnName("UserPreferenceID");

                entity.HasOne(d => d.UserPreference)
                    .WithMany(p => p.TblSysUserPreferenceChoice)
                    .HasForeignKey(d => d.UserPreferenceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblSysUserPreferenceChoice_REF_tblSysUserPreference");
            });

            modelBuilder.Entity<TblSysUserPreferenceUser>(entity =>
            {
                entity.HasKey(e => e.UserPreferenceUserId);

                entity.ToTable("tblSysUserPreferenceUser");

                entity.Property(e => e.UserPreferenceUserId).HasColumnName("UserPreferenceUserID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserPreferenceChoiceId).HasColumnName("UserPreferenceChoiceID");

                entity.Property(e => e.UserPreferenceId).HasColumnName("UserPreferenceID");

                entity.Property(e => e.Value).HasMaxLength(255);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TblSysUserPreferenceUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblSysUserPreferenceUser_REF_tblSysUser");

                entity.HasOne(d => d.UserPreferenceChoice)
                    .WithMany(p => p.TblSysUserPreferenceUser)
                    .HasForeignKey(d => d.UserPreferenceChoiceId)
                    .HasConstraintName("FK_tblSysUserPreferenceUser_REF_tblSysUserPreferenceChoice");

                entity.HasOne(d => d.UserPreference)
                    .WithMany(p => p.TblSysUserPreferenceUser)
                    .HasForeignKey(d => d.UserPreferenceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblSysUserPreferenceUser_REF_tblSysUserPreference");
            });

            modelBuilder.Entity<TblSysVersion>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("tblSysVersion");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.DbmajorVersion).HasColumnName("DBMajorVersion");

                entity.Property(e => e.DbminorVersion).HasColumnName("DBMinorVersion");

                entity.Property(e => e.DbrevisionVersion).HasColumnName("DBRevisionVersion");

                entity.Property(e => e.RevisionDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblTagRegion>(entity =>
            {
                entity.HasKey(e => e.TagRegionId);

                entity.ToTable("tbl_TagRegion");

                entity.Property(e => e.TagRegionId).HasColumnName("TagRegionID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TagRegion)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.TagRegionDesc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblTaxInvoiceRecord>(entity =>
            {
                entity.HasKey(e => e.TaxInvoiceId);

                entity.ToTable("tblTaxInvoiceRecord");

                entity.Property(e => e.TaxInvoiceId)
                    .HasColumnName("TaxInvoiceID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Abn)
                    .HasColumnName("ABN")
                    .HasMaxLength(50);

                entity.Property(e => e.Address1).HasMaxLength(200);

                entity.Property(e => e.Address2).HasMaxLength(200);

                entity.Property(e => e.Address3).HasMaxLength(200);

                entity.Property(e => e.BfeeAmount)
                    .HasColumnName("BFeeAmount")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.CountryCode).HasMaxLength(50);

                entity.Property(e => e.CountryName).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DispatchType).HasMaxLength(50);

                entity.Property(e => e.HfeeAmount)
                    .HasColumnName("HFeeAmount")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.InvoiceName).HasMaxLength(100);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PreviousTaxInvoiceId).HasColumnName("PreviousTaxInvoiceID");

                entity.Property(e => e.PrintSellerId)
                    .HasColumnName("PrintSellerID")
                    .HasMaxLength(50);

                entity.Property(e => e.RecipientEmail).HasMaxLength(50);

                entity.Property(e => e.SaleTransactionId).HasColumnName("SaleTransactionID");

                entity.Property(e => e.TaxInvoiceDateTime).HasColumnType("datetime");

                entity.Property(e => e.TicketCost).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.TotalPaid).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.TotalTax).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.Zipcode)
                    .HasColumnName("ZIPCode")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TblTaxInvoiceRecord)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblOrder_tblTaxInvoiceRecord_FK1");

                entity.HasOne(d => d.PreviousTaxInvoice)
                    .WithMany(p => p.TblTaxInvoiceRecordPreviousTaxInvoice)
                    .HasForeignKey(d => d.PreviousTaxInvoiceId)
                    .HasConstraintName("tblTaxInvoiceRecord_tblOriginTaxInvoiceMap_FK1");

                entity.HasOne(d => d.SaleTransaction)
                    .WithMany(p => p.TblTaxInvoiceRecord)
                    .HasForeignKey(d => d.SaleTransactionId)
                    .HasConstraintName("tblTaxInvoiceRecord_InventoryTransactionID_FK1");

                entity.HasOne(d => d.TaxInvoice)
                    .WithOne(p => p.TblTaxInvoiceRecordTaxInvoice)
                    .HasForeignKey<TblTaxInvoiceRecord>(d => d.TaxInvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblTaxInvoiceRecord_tblTaxInvoiceRecord_FK2");
            });

            modelBuilder.Entity<TblThirdPartyPaymentDetail>(entity =>
            {
                entity.HasKey(e => e.ThirdPartyPaymentDetailId);

                entity.ToTable("tbl_ThirdPartyPaymentDetail");

                entity.Property(e => e.ThirdPartyPaymentDetailId).HasColumnName("ThirdPartyPaymentDetailID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasMaxLength(200);

                entity.Property(e => e.OrganisationCustomerId).HasColumnName("OrganisationCustomerID");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.ProviderReference).HasMaxLength(200);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblTicketLimit>(entity =>
            {
                entity.HasKey(e => e.TicketLimitId);

                entity.ToTable("tbl_TicketLimit");

                entity.Property(e => e.TicketLimitId).HasColumnName("TicketLimitID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ShowItemId).HasColumnName("ShowItemID");

                entity.Property(e => e.TicketLimitTypeId).HasColumnName("TicketLimitTypeID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.ShowItem)
                    .WithMany(p => p.TblTicketLimit)
                    .HasForeignKey(d => d.ShowItemId)
                    .HasConstraintName("FK_tbl_ShowItem_ShowItemID");

                entity.HasOne(d => d.TicketLimitType)
                    .WithMany(p => p.TblTicketLimit)
                    .HasForeignKey(d => d.TicketLimitTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_TicketLimit_TicketLimitTypeID");
            });

            modelBuilder.Entity<TblTicketLimitIdentifier>(entity =>
            {
                entity.HasKey(e => e.TicketLimitIdentifierId);

                entity.ToTable("tbl_TicketLimitIdentifier");

                entity.HasIndex(e => new { e.TicketLimitIdentifier, e.TicketLimitTypeId, e.TicketLimitUsageId })
                    .HasName("NCINDEX_tbl_TicketLimitIdentifier_TicketLimitTypeID_TicketLimitUsageID_inc_TicketLimitIdentifier");

                entity.Property(e => e.TicketLimitIdentifierId).HasColumnName("TicketLimitIdentifierID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TicketLimitIdentifier)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TicketLimitTypeId).HasColumnName("TicketLimitTypeID");

                entity.Property(e => e.TicketLimitUsageId).HasColumnName("TicketLimitUsageID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.TicketLimitType)
                    .WithMany(p => p.TblTicketLimitIdentifier)
                    .HasForeignKey(d => d.TicketLimitTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_TicketLimitIdentifier_TicketLimitTypeID");

                entity.HasOne(d => d.TicketLimitUsage)
                    .WithMany(p => p.TblTicketLimitIdentifier)
                    .HasForeignKey(d => d.TicketLimitUsageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_TicketLimitIdentifier_TicketLimitUsageID");
            });

            modelBuilder.Entity<TblTicketLimitType>(entity =>
            {
                entity.HasKey(e => e.TicketLimitTypeId);

                entity.ToTable("tbl_TicketLimitType");

                entity.Property(e => e.TicketLimitTypeId).HasColumnName("TicketLimitTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TicketLimitTypeName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblTicketLimitUsage>(entity =>
            {
                entity.HasKey(e => e.TicketLimitUsageId);

                entity.ToTable("tbl_TicketLimitUsage");

                entity.Property(e => e.TicketLimitUsageId).HasColumnName("TicketLimitUsageID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PerformanceCode).HasMaxLength(50);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblTicketLimitUsage)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_TicketLimitUsage_CustomerID");
            });

            modelBuilder.Entity<TblTicketType>(entity =>
            {
                entity.HasKey(e => e.TicketTypeId);

                entity.ToTable("tbl_TicketType");

                entity.Property(e => e.TicketTypeId).HasColumnName("TicketTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TicketType)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TblTimeZoneOffset>(entity =>
            {
                entity.HasKey(e => new { e.UtcstartDateTime, e.UtcendDateTime });

                entity.ToTable("tbl_TimeZoneOffset");

                entity.Property(e => e.UtcstartDateTime)
                    .HasColumnName("UTCStartDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.UtcendDateTime)
                    .HasColumnName("UTCEndDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TimeZoneName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblTransmissionCredential>(entity =>
            {
                entity.HasKey(e => e.TransmissionCredentialId);

                entity.ToTable("tbl_TransmissionCredential");

                entity.HasIndex(e => new { e.ApplicationId, e.OrganisationId })
                    .HasName("UNCINDEX_ApplicationID_OrganisationID")
                    .IsUnique();

                entity.Property(e => e.TransmissionCredentialId).HasColumnName("TransmissionCredentialID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IntegrationSourceId).HasColumnName("IntegrationSourceID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.Password).HasMaxLength(256);

                entity.Property(e => e.SecurityToken).HasMaxLength(500);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.UserName).HasMaxLength(100);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.TblTransmissionCredential)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_TransmissionCredential_REF_tblSysApplication_ApplicationID");

                entity.HasOne(d => d.IntegrationSource)
                    .WithMany(p => p.TblTransmissionCredential)
                    .HasForeignKey(d => d.IntegrationSourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_TransmissionIntegrationSource_REF_tbl_TransmissionIntegrationSource_IntegrationSourceID");

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblTransmissionCredential)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_TransmissionCredential_REF_tblOrganisation_OrganisationID");
            });

            modelBuilder.Entity<TblTransmissionEntity>(entity =>
            {
                entity.HasKey(e => e.TransmissionEntityId);

                entity.ToTable("tbl_TransmissionEntity");

                entity.Property(e => e.TransmissionEntityId)
                    .HasColumnName("TransmissionEntityID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TransmissionEntityName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblTransmissionEntityConfig>(entity =>
            {
                entity.HasKey(e => e.TransmissionEntityConfigId);

                entity.ToTable("tbl_TransmissionEntityConfig");

                entity.Property(e => e.TransmissionEntityConfigId).HasColumnName("TransmissionEntityConfigID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DoNotTransmitBetweenEndTime).HasColumnType("char(5)");

                entity.Property(e => e.DoNotTransmitBetweenStartTime).HasColumnType("char(5)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.TransmissionEntityId).HasColumnName("TransmissionEntityID");

                entity.Property(e => e.TransmitBetweenEndTime)
                    .IsRequired()
                    .HasColumnType("char(5)");

                entity.Property(e => e.TransmitBetweenStartTime)
                    .IsRequired()
                    .HasColumnType("char(5)");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblTransmissionEntityConfig)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_TransmissionEntityConfig_REF_tblOrganisation");

                entity.HasOne(d => d.TransmissionEntity)
                    .WithMany(p => p.TblTransmissionEntityConfig)
                    .HasForeignKey(d => d.TransmissionEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_TransmissionEntityConfig_REF_tbl_TransmissionEntity");
            });

            modelBuilder.Entity<TblTransmissionIntegrationSource>(entity =>
            {
                entity.HasKey(e => e.IntegrationSourceId);

                entity.ToTable("tbl_TransmissionIntegrationSource");

                entity.Property(e => e.IntegrationSourceId)
                    .HasColumnName("IntegrationSourceID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IntegrationSource)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TblTransmissionLog>(entity =>
            {
                entity.HasKey(e => e.TransmissionLogId);

                entity.ToTable("tbl_TransmissionLog");

                entity.HasIndex(e => new { e.OrganisationId, e.TransmissionEntityId })
                    .HasName("NCINDEX_tbl_TransmissionLog_OrganisationID_TransmissionEntityID");

                entity.Property(e => e.TransmissionLogId).HasColumnName("TransmissionLogID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LastBatchTransmissionDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.TransmissionEndDate).HasColumnType("datetime");

                entity.Property(e => e.TransmissionEntityId).HasColumnName("TransmissionEntityID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblTransmissionLog)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_TransmissionLog_REF_tblOrganisation");

                entity.HasOne(d => d.TransmissionEntity)
                    .WithMany(p => p.TblTransmissionLog)
                    .HasForeignKey(d => d.TransmissionEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_TransmissionLog_REF_tbl_TransmissionEntity");
            });

            modelBuilder.Entity<TblVenue>(entity =>
            {
                entity.HasKey(e => e.VenueId);

                entity.ToTable("tbl_Venue");

                entity.HasIndex(e => e.VenueCode)
                    .HasName("uc_tbl_Venue_VenueCode")
                    .IsUnique();

                entity.Property(e => e.VenueId).HasColumnName("VenueID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.VenueAddressId).HasColumnName("VenueAddressID");

                entity.Property(e => e.VenueCode)
                    .IsRequired()
                    .HasColumnType("nchar(3)");

                entity.Property(e => e.VenueDescription).HasMaxLength(255);

                entity.Property(e => e.VenueName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.TblVenue)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK_tbl_Venue_tbl_Region");

                entity.HasOne(d => d.VenueAddress)
                    .WithMany(p => p.TblVenue)
                    .HasForeignKey(d => d.VenueAddressId)
                    .HasConstraintName("FK_tbl_Venue_tblAddress");
            });

            modelBuilder.Entity<TblVenueAttribute>(entity =>
            {
                entity.HasKey(e => e.AttributeId);

                entity.ToTable("tbl_VenueAttribute");

                entity.Property(e => e.AttributeId)
                    .HasColumnName("AttributeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AttributeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AttributeValue)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.VenueId).HasColumnName("VenueID");

                entity.HasOne(d => d.Venue)
                    .WithMany(p => p.TblVenueAttribute)
                    .HasForeignKey(d => d.VenueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_VenueAttribute_tbl_Venue");
            });

            modelBuilder.Entity<TblVenueGroup>(entity =>
            {
                entity.HasKey(e => e.VenueGroupId);

                entity.ToTable("tbl_VenueGroup");

                entity.Property(e => e.VenueGroupId).HasColumnName("VenueGroupID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.VenueId).HasColumnName("VenueID");

                entity.Property(e => e.VenueManagerId).HasColumnName("VenueManagerID");

                entity.HasOne(d => d.Venue)
                    .WithMany(p => p.TblVenueGroup)
                    .HasForeignKey(d => d.VenueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_VenueGroup_Ref_tbl_Venue");

                entity.HasOne(d => d.VenueManager)
                    .WithMany(p => p.TblVenueGroup)
                    .HasForeignKey(d => d.VenueManagerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_VenueGroup_Ref_tbl_VenueManager");
            });

            modelBuilder.Entity<TblVenueManager>(entity =>
            {
                entity.HasKey(e => e.VenueManagerId);

                entity.ToTable("tbl_VenueManager");

                entity.HasIndex(e => e.VenueManagerName)
                    .HasName("uc_tbl_VenueManager_VenueName")
                    .IsUnique();

                entity.Property(e => e.VenueManagerId).HasColumnName("VenueManagerID");

                entity.Property(e => e.BusinessId).HasColumnName("BusinessID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.VenueManagerCode).HasMaxLength(5);

                entity.Property(e => e.VenueManagerDescription).HasMaxLength(255);

                entity.Property(e => e.VenueManagerName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Business)
                    .WithMany(p => p.TblVenueManager)
                    .HasForeignKey(d => d.BusinessId)
                    .HasConstraintName("FK_tbl_Venue_BusinessID");
            });

            modelBuilder.Entity<TblVenuePolicy>(entity =>
            {
                entity.HasKey(e => new { e.VenuePolicyId, e.ShowVenueId })
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tbl_VenuePolicy");

                entity.Property(e => e.VenuePolicyId)
                    .HasColumnName("VenuePolicyID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ShowVenueId).HasColumnName("ShowVenueID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Detail).HasMaxLength(128);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.ShowVenue)
                    .WithMany(p => p.TblVenuePolicy)
                    .HasForeignKey(d => d.ShowVenueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_VenuePolicy_tbl_ShowVenue");
            });

            modelBuilder.Entity<TblVenueSeatMap>(entity =>
            {
                entity.HasKey(e => e.VenueSeatMapId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tbl_VenueSeatMap");

                entity.Property(e => e.VenueSeatMapId).HasColumnName("VenueSeatMapID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SeatMap)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.ShowVenueId).HasColumnName("ShowVenueID");

                entity.Property(e => e.Tstamp)
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.ShowVenue)
                    .WithMany(p => p.TblVenueSeatMap)
                    .HasForeignKey(d => d.ShowVenueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_VenueSeatMap_tbl_ShowVenue");
            });

            modelBuilder.Entity<TblVoucher>(entity =>
            {
                entity.HasKey(e => e.VoucherId);

                entity.ToTable("tblVoucher");

                entity.HasIndex(e => new { e.TransactionDate, e.TransactionNumber })
                    .HasName("IX_tblVoucher_TDate_TNum")
                    .IsUnique();

                entity.Property(e => e.VoucherId).HasColumnName("VoucherID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PriceCategory)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.PriceTypeCode)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.RedeemedCustomerId).HasColumnName("RedeemedCustomerID");

                entity.Property(e => e.RedeemedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.VoucherStatusId).HasColumnName("VoucherStatusID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblVoucherCustomer)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblVoucher_tblCustomer");

                entity.HasOne(d => d.RedeemedCustomer)
                    .WithMany(p => p.TblVoucherRedeemedCustomer)
                    .HasForeignKey(d => d.RedeemedCustomerId)
                    .HasConstraintName("FK_tblVoucher_tblCustomer1");

                entity.HasOne(d => d.VoucherStatus)
                    .WithMany(p => p.TblVoucher)
                    .HasForeignKey(d => d.VoucherStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblVoucher_tblVoucherStatus");
            });

            modelBuilder.Entity<TblVoucher1>(entity =>
            {
                entity.HasKey(e => e.VoucherId);

                entity.ToTable("tbl_Voucher");

                entity.Property(e => e.VoucherId).HasColumnName("VoucherID");

                entity.Property(e => e.ActivationDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.LockedDate).HasColumnType("datetime");

                entity.Property(e => e.LockedUntilDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.VoucherIdentifier)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblVoucherStatus>(entity =>
            {
                entity.HasKey(e => e.VoucherStatusId);

                entity.ToTable("tblVoucherStatus");

                entity.Property(e => e.VoucherStatusId)
                    .HasColumnName("VoucherStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.VoucherStatus)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblVoucherTransaction>(entity =>
            {
                entity.HasKey(e => e.VoucherTransactionId);

                entity.ToTable("tbl_VoucherTransaction");

                entity.Property(e => e.VoucherTransactionId).HasColumnName("VoucherTransactionID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.VoucherId).HasColumnName("VoucherID");

                entity.HasOne(d => d.Voucher)
                    .WithMany(p => p.TblVoucherTransaction)
                    .HasForeignKey(d => d.VoucherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_VoucherTransaction_REF_Voucher");
            });

            modelBuilder.Entity<TblWaitlist>(entity =>
            {
                entity.HasKey(e => e.WaitlistId);

                entity.ToTable("tbl_Waitlist");

                entity.HasIndex(e => new { e.WaitlistChannelId, e.WaitlistName })
                    .HasName("UC_tbl_Waitlist_WaitlistName")
                    .IsUnique();

                entity.Property(e => e.WaitlistId).HasColumnName("WaitlistID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.WaitlistChannelId).HasColumnName("WaitlistChannelID");

                entity.Property(e => e.WaitlistName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.WaitlistChannel)
                    .WithMany(p => p.TblWaitlist)
                    .HasForeignKey(d => d.WaitlistChannelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_Waitlist_tbl_WaitlistChannel");
            });

            modelBuilder.Entity<TblWaitlistChannel>(entity =>
            {
                entity.HasKey(e => e.WaitlistChannelId);

                entity.ToTable("tbl_WaitlistChannel");

                entity.HasIndex(e => e.WaitlistChannelName)
                    .HasName("UC_tbl_WaitlistChannel_WaitlistChannelName")
                    .IsUnique();

                entity.Property(e => e.WaitlistChannelId).HasColumnName("WaitlistChannelID");

                entity.Property(e => e.AttributeName).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerTypeName).HasMaxLength(50);

                entity.Property(e => e.EntitlementGroupName).HasMaxLength(100);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.WaitlistChannelName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblWorkflowGroupType>(entity =>
            {
                entity.HasKey(e => e.WorkflowGroupTypeId);

                entity.ToTable("tbl_WorkflowGroupType");

                entity.Property(e => e.WorkflowGroupTypeId).HasColumnName("WorkflowGroupTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.WorkflowGroupTypeDescription).HasMaxLength(100);

                entity.Property(e => e.WorkflowGroupTypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblWorkflowOrganisation>(entity =>
            {
                entity.HasKey(e => new { e.OrganisationId, e.WorkflowGroupTypeId, e.WorkflowTypeId, e.WorkflowId, e.ProcessingLevel });

                entity.ToTable("tbl_WorkflowOrganisation");

                entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");

                entity.Property(e => e.WorkflowGroupTypeId).HasColumnName("WorkflowGroupTypeID");

                entity.Property(e => e.WorkflowTypeId).HasColumnName("WorkflowTypeID");

                entity.Property(e => e.WorkflowId).HasColumnName("WorkflowID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.TblWorkflowOrganisation)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_WorkflowOrganisation_tblOrganisation");

                entity.HasOne(d => d.WorkflowGroupType)
                    .WithMany(p => p.TblWorkflowOrganisation)
                    .HasForeignKey(d => d.WorkflowGroupTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_WorkflowOrganisation_tbl_WorkflowGroupType");

                entity.HasOne(d => d.WorkflowType)
                    .WithMany(p => p.TblWorkflowOrganisation)
                    .HasForeignKey(d => d.WorkflowTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_WorkflowOrganisation_tbl_WorkflowType");
            });

            modelBuilder.Entity<TblWorkflowType>(entity =>
            {
                entity.HasKey(e => e.WorkflowTypeId);

                entity.ToTable("tbl_WorkflowType");

                entity.Property(e => e.WorkflowTypeId).HasColumnName("WorkflowTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.Property(e => e.WorkflowTypeDescription).HasMaxLength(100);

                entity.Property(e => e.WorkflowTypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<Test1>(entity =>
            {
                entity.HasKey(e => e.Empid);

                entity.ToTable("test1");

                entity.Property(e => e.Empid)
                    .HasColumnName("EMPID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Fname)
                    .HasColumnName("FNAME")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Lname)
                    .HasColumnName("LNAME")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Test2>(entity =>
            {
                entity.HasKey(e => e.Empid1);

                entity.ToTable("test2");

                entity.Property(e => e.Empid1)
                    .HasColumnName("EMPID1")
                    .ValueGeneratedNever();

                entity.Property(e => e.Fname1)
                    .HasColumnName("FNAME1")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Lname1)
                    .HasColumnName("LNAME1")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TicketExtension>(entity =>
            {
                entity.HasKey(e => new { e.TransactionDate, e.TransactionNumber, e.Paxnumber });

                entity.HasIndex(e => e.MobilePhoneNumber)
                    .HasName("IX_MobilePhone");

                entity.Property(e => e.Paxnumber).HasColumnName("PAXNumber");

                entity.Property(e => e.ClaimantCustomerId).HasColumnName("ClaimantCustomerID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerFirstName).HasMaxLength(50);

                entity.Property(e => e.CustomerLastName).HasMaxLength(50);

                entity.Property(e => e.CustomerSalutation).HasMaxLength(50);

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.IdentityNumber).HasMaxLength(50);

                entity.Property(e => e.IdentityNumberType).HasMaxLength(50);

                entity.Property(e => e.MobilePhoneNumber).HasMaxLength(40);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PerformanceId).HasColumnName("PerformanceID");

                entity.Property(e => e.TransactionCustomerId).HasColumnName("TransactionCustomerID");

                entity.Property(e => e.Tstamp)
                    .IsRequired()
                    .HasColumnName("tstamp")
                    .IsRowVersion();

                entity.HasOne(d => d.ClaimantCustomer)
                    .WithMany(p => p.TicketExtensionClaimantCustomer)
                    .HasForeignKey(d => d.ClaimantCustomerId)
                    .HasConstraintName("FK_TicketExtension_REF_tblCustomer_2");

                entity.HasOne(d => d.TransactionCustomer)
                    .WithMany(p => p.TicketExtensionTransactionCustomer)
                    .HasForeignKey(d => d.TransactionCustomerId)
                    .HasConstraintName("FK_TicketExtension_REF_tblCustomer_1");
            });

            modelBuilder.Entity<ZztblOrderIdsToInsert>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("zztblOrderIDsToInsert");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .ValueGeneratedNever();
            });
        }
    }
}
