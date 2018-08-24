using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOrderLine
    {
        public TblOrderLine()
        {
            InverseParentOrderLine = new HashSet<TblOrderLine>();
            InverseUmbrellaOrderLine = new HashSet<TblOrderLine>();
            TblOrderLineAllocation = new HashSet<TblOrderLineAllocation>();
            TblOrderLineAttributeValue = new HashSet<TblOrderLineAttributeValue>();
            TblOrderLineMemberShopItem = new HashSet<TblOrderLineMemberShopItem>();
            TblOrderLinePaymentHistory = new HashSet<TblOrderLinePaymentHistory>();
            TblOrderLineVenuePrefJoin = new HashSet<TblOrderLineVenuePrefJoin>();
            TblSubscription = new HashSet<TblSubscription>();
        }

        public int OrderLineId { get; set; }
        public int OrderId { get; set; }
        public int OrganisationCustomerId { get; set; }
        public int? MembershipId { get; set; }
        public int ProductId { get; set; }
        public int ProductCategoryId { get; set; }
        public int PriceTypeId { get; set; }
        public int? ParentOrderLineId { get; set; }
        public int? ProductSelectionId { get; set; }
        public short UnitQuantity { get; set; }
        public decimal Price { get; set; }
        public short? FulFillmentQuantity { get; set; }
        public short? PaymentStatus { get; set; }
        public bool? IsGuest { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public short? FulfilmentStatus { get; set; }
        public short? ProductStatus { get; set; }
        public int? SeatingGroupId { get; set; }
        public int? ParentPriceTypeId { get; set; }
        public bool? IsPartPaid { get; set; }
        public bool? IsPrePaid { get; set; }
        public int? UmbrellaOrderLineId { get; set; }
        public short? PartPrepayStatus { get; set; }
        public int? OrganisationCustomerOwnerId { get; set; }
        public int? OrderLineStatusId { get; set; }

        public TblMembership Membership { get; set; }
        public TblOrder1 Order { get; set; }
        public TblOrganisationCustomer OrganisationCustomer { get; set; }
        public TblOrderLine ParentOrderLine { get; set; }
        public TblPriceType ParentPriceType { get; set; }
        public TblPriceType PriceType { get; set; }
        public TblProduct Product { get; set; }
        public TblProductCategory ProductCategory { get; set; }
        public TblProductSelection ProductSelection { get; set; }
        public TblSeatingGroup SeatingGroup { get; set; }
        public TblOrderLine UmbrellaOrderLine { get; set; }
        public TblOrderGuestInfo TblOrderGuestInfo { get; set; }
        public TblOrderlineClassification TblOrderlineClassification { get; set; }
        public ICollection<TblOrderLine> InverseParentOrderLine { get; set; }
        public ICollection<TblOrderLine> InverseUmbrellaOrderLine { get; set; }
        public ICollection<TblOrderLineAllocation> TblOrderLineAllocation { get; set; }
        public ICollection<TblOrderLineAttributeValue> TblOrderLineAttributeValue { get; set; }
        public ICollection<TblOrderLineMemberShopItem> TblOrderLineMemberShopItem { get; set; }
        public ICollection<TblOrderLinePaymentHistory> TblOrderLinePaymentHistory { get; set; }
        public ICollection<TblOrderLineVenuePrefJoin> TblOrderLineVenuePrefJoin { get; set; }
        public ICollection<TblSubscription> TblSubscription { get; set; }
    }
}
