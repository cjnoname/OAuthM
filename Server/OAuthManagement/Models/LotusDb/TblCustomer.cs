using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblCustomer
    {
        public TblCustomer()
        {
            TblAutomaticRenewalPaymentMethod = new HashSet<TblAutomaticRenewalPaymentMethod>();
            TblBankAccount = new HashSet<TblBankAccount>();
            TblCustomerAccountBalanceJournal = new HashSet<TblCustomerAccountBalanceJournal>();
            TblCustomerActivityRecord = new HashSet<TblCustomerActivityRecord>();
            TblCustomerAddress = new HashSet<TblCustomerAddress>();
            TblCustomerCredentials = new HashSet<TblCustomerCredentials>();
            TblCustomerCreditCard = new HashSet<TblCustomerCreditCard>();
            TblCustomerCustomerType = new HashSet<TblCustomerCustomerType>();
            TblCustomerHold = new HashSet<TblCustomerHold>();
            TblCustomerLinkedCustomerCustomer = new HashSet<TblCustomerLinkedCustomer>();
            TblCustomerLinkedCustomerLinkedCustomer = new HashSet<TblCustomerLinkedCustomer>();
            TblCustomerLinkedGroup = new HashSet<TblCustomerLinkedGroup>();
            TblCustomerPhone = new HashSet<TblCustomerPhone>();
            TblCustomerPreferenceValue = new HashSet<TblCustomerPreferenceValue>();
            TblCustomerSubscription = new HashSet<TblCustomerSubscription>();
            TblCustomerWaitlist = new HashSet<TblCustomerWaitlist>();
            TblEntitlementUsage = new HashSet<TblEntitlementUsage>();
            TblInventoryTransaction = new HashSet<TblInventoryTransaction>();
            TblOrder = new HashSet<TblOrder>();
            TblOrganisationCustomer = new HashSet<TblOrganisationCustomer>();
            TblOriginAccount = new HashSet<TblOriginAccount>();
            TblTicketLimitUsage = new HashSet<TblTicketLimitUsage>();
            TblVoucherCustomer = new HashSet<TblVoucher>();
            TblVoucherRedeemedCustomer = new HashSet<TblVoucher>();
            TicketExtensionClaimantCustomer = new HashSet<TicketExtension>();
            TicketExtensionTransactionCustomer = new HashSet<TicketExtension>();
        }

        public int CustomerId { get; set; }
        public int CustomerListId { get; set; }
        public string Gender { get; set; }
        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string BusinessName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Comments { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsLocked { get; set; }
        public string PowerWebUsername { get; set; }
        public bool IsPowerWebUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? DisabledDate { get; set; }
        public int? DisabledBy { get; set; }
        public DateTime? LockedDate { get; set; }
        public int? LockedBy { get; set; }
        public byte[] Tstamp { get; set; }
        public byte[] Password { get; set; }
        public string EmailAddress { get; set; }
        public DateTime? ProfileModifiedDate { get; set; }
        public bool? IsLoginDisabled { get; set; }
        public DateTime? LoginDisabledDate { get; set; }
        public int? LoginDisabledBy { get; set; }

        public TblCustomerList CustomerList { get; set; }
        public TblCustomerAccountBalance TblCustomerAccountBalance { get; set; }
        public ICollection<TblAutomaticRenewalPaymentMethod> TblAutomaticRenewalPaymentMethod { get; set; }
        public ICollection<TblBankAccount> TblBankAccount { get; set; }
        public ICollection<TblCustomerAccountBalanceJournal> TblCustomerAccountBalanceJournal { get; set; }
        public ICollection<TblCustomerActivityRecord> TblCustomerActivityRecord { get; set; }
        public ICollection<TblCustomerAddress> TblCustomerAddress { get; set; }
        public ICollection<TblCustomerCredentials> TblCustomerCredentials { get; set; }
        public ICollection<TblCustomerCreditCard> TblCustomerCreditCard { get; set; }
        public ICollection<TblCustomerCustomerType> TblCustomerCustomerType { get; set; }
        public ICollection<TblCustomerHold> TblCustomerHold { get; set; }
        public ICollection<TblCustomerLinkedCustomer> TblCustomerLinkedCustomerCustomer { get; set; }
        public ICollection<TblCustomerLinkedCustomer> TblCustomerLinkedCustomerLinkedCustomer { get; set; }
        public ICollection<TblCustomerLinkedGroup> TblCustomerLinkedGroup { get; set; }
        public ICollection<TblCustomerPhone> TblCustomerPhone { get; set; }
        public ICollection<TblCustomerPreferenceValue> TblCustomerPreferenceValue { get; set; }
        public ICollection<TblCustomerSubscription> TblCustomerSubscription { get; set; }
        public ICollection<TblCustomerWaitlist> TblCustomerWaitlist { get; set; }
        public ICollection<TblEntitlementUsage> TblEntitlementUsage { get; set; }
        public ICollection<TblInventoryTransaction> TblInventoryTransaction { get; set; }
        public ICollection<TblOrder> TblOrder { get; set; }
        public ICollection<TblOrganisationCustomer> TblOrganisationCustomer { get; set; }
        public ICollection<TblOriginAccount> TblOriginAccount { get; set; }
        public ICollection<TblTicketLimitUsage> TblTicketLimitUsage { get; set; }
        public ICollection<TblVoucher> TblVoucherCustomer { get; set; }
        public ICollection<TblVoucher> TblVoucherRedeemedCustomer { get; set; }
        public ICollection<TicketExtension> TicketExtensionClaimantCustomer { get; set; }
        public ICollection<TicketExtension> TicketExtensionTransactionCustomer { get; set; }
    }
}
