using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOrganisationCustomer
    {
        public TblOrganisationCustomer()
        {
            TblActivityRecordJoin = new HashSet<TblActivityRecordJoin>();
            TblAutomaticRenewalPaymentMethod = new HashSet<TblAutomaticRenewalPaymentMethod>();
            TblMemberPerformanceBarcode = new HashSet<TblMemberPerformanceBarcode>();
            TblMemberRanking = new HashSet<TblMemberRanking>();
            TblMembershipSeat = new HashSet<TblMembershipSeat>();
            TblOrder1 = new HashSet<TblOrder1>();
            TblOrderLine = new HashSet<TblOrderLine>();
            TblOrganisationAttributeValue = new HashSet<TblOrganisationAttributeValue>();
            TblOrganisationCustomerActivityRecord = new HashSet<TblOrganisationCustomerActivityRecord>();
            TblOrganisationCustomerOrderline = new HashSet<TblOrganisationCustomerOrderline>();
            TblOrganisationCustomerOrderlineItem = new HashSet<TblOrganisationCustomerOrderlineItem>();
            TblPaxcard = new HashSet<TblPaxcard>();
            TblProductWaitlist = new HashSet<TblProductWaitlist>();
            TblShoppingCart = new HashSet<TblShoppingCart>();
            TblSourceSeatAttribute = new HashSet<TblSourceSeatAttribute>();
            TblSubscription = new HashSet<TblSubscription>();
        }

        public int CustomerId { get; set; }
        public int OrganisationId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int OrganisationCustomerId { get; set; }
        public string MemberNumber { get; set; }
        public string MemberType { get; set; }
        public string ExternalReferenceId { get; set; }
        public DateTime? MemberSince { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblCustomer Customer { get; set; }
        public TblOrganisation Organisation { get; set; }
        public TblMember TblMember { get; set; }
        public ICollection<TblActivityRecordJoin> TblActivityRecordJoin { get; set; }
        public ICollection<TblAutomaticRenewalPaymentMethod> TblAutomaticRenewalPaymentMethod { get; set; }
        public ICollection<TblMemberPerformanceBarcode> TblMemberPerformanceBarcode { get; set; }
        public ICollection<TblMemberRanking> TblMemberRanking { get; set; }
        public ICollection<TblMembershipSeat> TblMembershipSeat { get; set; }
        public ICollection<TblOrder1> TblOrder1 { get; set; }
        public ICollection<TblOrderLine> TblOrderLine { get; set; }
        public ICollection<TblOrganisationAttributeValue> TblOrganisationAttributeValue { get; set; }
        public ICollection<TblOrganisationCustomerActivityRecord> TblOrganisationCustomerActivityRecord { get; set; }
        public ICollection<TblOrganisationCustomerOrderline> TblOrganisationCustomerOrderline { get; set; }
        public ICollection<TblOrganisationCustomerOrderlineItem> TblOrganisationCustomerOrderlineItem { get; set; }
        public ICollection<TblPaxcard> TblPaxcard { get; set; }
        public ICollection<TblProductWaitlist> TblProductWaitlist { get; set; }
        public ICollection<TblShoppingCart> TblShoppingCart { get; set; }
        public ICollection<TblSourceSeatAttribute> TblSourceSeatAttribute { get; set; }
        public ICollection<TblSubscription> TblSubscription { get; set; }
    }
}
