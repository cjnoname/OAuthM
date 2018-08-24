using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOrganisation
    {
        public TblOrganisation()
        {
            TblAllocationProcessOrganisationJoin = new HashSet<TblAllocationProcessOrganisationJoin>();
            TblConfigAttribute = new HashSet<TblConfigAttribute>();
            TblConfigAttributeUserControl = new HashSet<TblConfigAttributeUserControl>();
            TblCustomerLinkedCustomer = new HashSet<TblCustomerLinkedCustomer>();
            TblEnquiryFilter = new HashSet<TblEnquiryFilter>();
            TblForeignBarcode = new HashSet<TblForeignBarcode>();
            TblGroupOrganisation = new HashSet<TblGroupOrganisation>();
            TblMasterMapping = new HashSet<TblMasterMapping>();
            TblMemberPerformanceBarcode = new HashSet<TblMemberPerformanceBarcode>();
            TblMembershipPromotion = new HashSet<TblMembershipPromotion>();
            TblMenuItem = new HashSet<TblMenuItem>();
            TblMenuItemLink = new HashSet<TblMenuItemLink>();
            TblOrderBaseClassificationGroup = new HashSet<TblOrderBaseClassificationGroup>();
            TblOrderClassification = new HashSet<TblOrderClassification>();
            TblOrderDeletion = new HashSet<TblOrderDeletion>();
            TblOrderLineAttribute = new HashSet<TblOrderLineAttribute>();
            TblOrderRolloverAudit = new HashSet<TblOrderRolloverAudit>();
            TblOrderlineClassification = new HashSet<TblOrderlineClassification>();
            TblOrganisationAttribute = new HashSet<TblOrganisationAttribute>();
            TblOrganisationCardType = new HashSet<TblOrganisationCardType>();
            TblOrganisationCustomer = new HashSet<TblOrganisationCustomer>();
            TblOrganisationCustomerFeature = new HashSet<TblOrganisationCustomerFeature>();
            TblOrganisationFile = new HashSet<TblOrganisationFile>();
            TblOrganisationPaymentMethod = new HashSet<TblOrganisationPaymentMethod>();
            TblPartPaymentSchedule = new HashSet<TblPartPaymentSchedule>();
            TblPaxcard = new HashSet<TblPaxcard>();
            TblPaymentMasterSchedule = new HashSet<TblPaymentMasterSchedule>();
            TblPaymentSchedule = new HashSet<TblPaymentSchedule>();
            TblPriceType = new HashSet<TblPriceType>();
            TblProcessLock = new HashSet<TblProcessLock>();
            TblProduct = new HashSet<TblProduct>();
            TblProductCategory = new HashSet<TblProductCategory>();
            TblProductGroup = new HashSet<TblProductGroup>();
            TblProductMemberShopItem = new HashSet<TblProductMemberShopItem>();
            TblProductSelection = new HashSet<TblProductSelection>();
            TblProductWaitlist = new HashSet<TblProductWaitlist>();
            TblRankingFactor = new HashSet<TblRankingFactor>();
            TblSeason = new HashSet<TblSeason>();
            TblSeasonSeatMap = new HashSet<TblSeasonSeatMap>();
            TblSeatStatus = new HashSet<TblSeatStatus>();
            TblSeatZone = new HashSet<TblSeatZone>();
            TblSeatZonePreference = new HashSet<TblSeatZonePreference>();
            TblSeatingPreference = new HashSet<TblSeatingPreference>();
            TblShoppingCart = new HashSet<TblShoppingCart>();
            TblTransmissionCredential = new HashSet<TblTransmissionCredential>();
            TblTransmissionEntityConfig = new HashSet<TblTransmissionEntityConfig>();
            TblTransmissionLog = new HashSet<TblTransmissionLog>();
            TblWorkflowOrganisation = new HashSet<TblWorkflowOrganisation>();
        }

        public int OrganisationId { get; set; }
        public int? BusinessId { get; set; }
        public string OrganisationName { get; set; }
        public string OrganisationCode { get; set; }
        public string Description { get; set; }
        public bool Archived { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public int? CustomerListId { get; set; }

        public TblMembershipOrganisation TblMembershipOrganisation { get; set; }
        public ICollection<TblAllocationProcessOrganisationJoin> TblAllocationProcessOrganisationJoin { get; set; }
        public ICollection<TblConfigAttribute> TblConfigAttribute { get; set; }
        public ICollection<TblConfigAttributeUserControl> TblConfigAttributeUserControl { get; set; }
        public ICollection<TblCustomerLinkedCustomer> TblCustomerLinkedCustomer { get; set; }
        public ICollection<TblEnquiryFilter> TblEnquiryFilter { get; set; }
        public ICollection<TblForeignBarcode> TblForeignBarcode { get; set; }
        public ICollection<TblGroupOrganisation> TblGroupOrganisation { get; set; }
        public ICollection<TblMasterMapping> TblMasterMapping { get; set; }
        public ICollection<TblMemberPerformanceBarcode> TblMemberPerformanceBarcode { get; set; }
        public ICollection<TblMembershipPromotion> TblMembershipPromotion { get; set; }
        public ICollection<TblMenuItem> TblMenuItem { get; set; }
        public ICollection<TblMenuItemLink> TblMenuItemLink { get; set; }
        public ICollection<TblOrderBaseClassificationGroup> TblOrderBaseClassificationGroup { get; set; }
        public ICollection<TblOrderClassification> TblOrderClassification { get; set; }
        public ICollection<TblOrderDeletion> TblOrderDeletion { get; set; }
        public ICollection<TblOrderLineAttribute> TblOrderLineAttribute { get; set; }
        public ICollection<TblOrderRolloverAudit> TblOrderRolloverAudit { get; set; }
        public ICollection<TblOrderlineClassification> TblOrderlineClassification { get; set; }
        public ICollection<TblOrganisationAttribute> TblOrganisationAttribute { get; set; }
        public ICollection<TblOrganisationCardType> TblOrganisationCardType { get; set; }
        public ICollection<TblOrganisationCustomer> TblOrganisationCustomer { get; set; }
        public ICollection<TblOrganisationCustomerFeature> TblOrganisationCustomerFeature { get; set; }
        public ICollection<TblOrganisationFile> TblOrganisationFile { get; set; }
        public ICollection<TblOrganisationPaymentMethod> TblOrganisationPaymentMethod { get; set; }
        public ICollection<TblPartPaymentSchedule> TblPartPaymentSchedule { get; set; }
        public ICollection<TblPaxcard> TblPaxcard { get; set; }
        public ICollection<TblPaymentMasterSchedule> TblPaymentMasterSchedule { get; set; }
        public ICollection<TblPaymentSchedule> TblPaymentSchedule { get; set; }
        public ICollection<TblPriceType> TblPriceType { get; set; }
        public ICollection<TblProcessLock> TblProcessLock { get; set; }
        public ICollection<TblProduct> TblProduct { get; set; }
        public ICollection<TblProductCategory> TblProductCategory { get; set; }
        public ICollection<TblProductGroup> TblProductGroup { get; set; }
        public ICollection<TblProductMemberShopItem> TblProductMemberShopItem { get; set; }
        public ICollection<TblProductSelection> TblProductSelection { get; set; }
        public ICollection<TblProductWaitlist> TblProductWaitlist { get; set; }
        public ICollection<TblRankingFactor> TblRankingFactor { get; set; }
        public ICollection<TblSeason> TblSeason { get; set; }
        public ICollection<TblSeasonSeatMap> TblSeasonSeatMap { get; set; }
        public ICollection<TblSeatStatus> TblSeatStatus { get; set; }
        public ICollection<TblSeatZone> TblSeatZone { get; set; }
        public ICollection<TblSeatZonePreference> TblSeatZonePreference { get; set; }
        public ICollection<TblSeatingPreference> TblSeatingPreference { get; set; }
        public ICollection<TblShoppingCart> TblShoppingCart { get; set; }
        public ICollection<TblTransmissionCredential> TblTransmissionCredential { get; set; }
        public ICollection<TblTransmissionEntityConfig> TblTransmissionEntityConfig { get; set; }
        public ICollection<TblTransmissionLog> TblTransmissionLog { get; set; }
        public ICollection<TblWorkflowOrganisation> TblWorkflowOrganisation { get; set; }
    }
}
