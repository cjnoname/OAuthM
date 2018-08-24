using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSubscription
    {
        public TblSubscription()
        {
            InverseRenewSubscription = new HashSet<TblSubscription>();
            InverseTransferredFromSubscription = new HashSet<TblSubscription>();
            TblEzyTicketGenerationLog = new HashSet<TblEzyTicketGenerationLog>();
            TblMembershipTicketGenerationLog = new HashSet<TblMembershipTicketGenerationLog>();
            TblOrderSubscriptionInfo = new HashSet<TblOrderSubscriptionInfo>();
            TblSubscriptionAllocation = new HashSet<TblSubscriptionAllocation>();
        }

        public int? ProductId { get; set; }
        public int? OrderLineId { get; set; }
        public int? OrganisationCustomerId { get; set; }
        public int SubscriptionId { get; set; }
        public int? PriceTypeId { get; set; }
        public int? ProductCategoryId { get; set; }
        public string ExtRef { get; set; }
        public int SubscriptionStatusId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public int? RenewSubscriptionId { get; set; }
        public int? TransferredTo { get; set; }
        public DateTime? TransferredDate { get; set; }
        public int? TransferredFromSubscriptionId { get; set; }
        public int? TransactionDate { get; set; }
        public int? TransactionNum { get; set; }
        public int? PaxcardId { get; set; }
        public bool? OptinRollingRenew { get; set; }
        public int? SubscriptionGroup { get; set; }
        public bool? IsRenewed { get; set; }
        public DateTime? RenewalFlagModifiedDate { get; set; }

        public TblOrderLine OrderLine { get; set; }
        public TblOrganisationCustomer OrganisationCustomer { get; set; }
        public TblPaxcard Paxcard { get; set; }
        public TblPriceType PriceType { get; set; }
        public TblProduct Product { get; set; }
        public TblProductCategory ProductCategory { get; set; }
        public TblSubscription RenewSubscription { get; set; }
        public TblSubscriptionStatus SubscriptionStatus { get; set; }
        public TblSubscription TransferredFromSubscription { get; set; }
        public ICollection<TblSubscription> InverseRenewSubscription { get; set; }
        public ICollection<TblSubscription> InverseTransferredFromSubscription { get; set; }
        public ICollection<TblEzyTicketGenerationLog> TblEzyTicketGenerationLog { get; set; }
        public ICollection<TblMembershipTicketGenerationLog> TblMembershipTicketGenerationLog { get; set; }
        public ICollection<TblOrderSubscriptionInfo> TblOrderSubscriptionInfo { get; set; }
        public ICollection<TblSubscriptionAllocation> TblSubscriptionAllocation { get; set; }
    }
}
