using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblAddress
    {
        public TblAddress()
        {
            TblActivityTypeAttributeValue = new HashSet<TblActivityTypeAttributeValue>();
            TblCustomerAddress = new HashSet<TblCustomerAddress>();
            TblCustomerTypeAttributeValue = new HashSet<TblCustomerTypeAttributeValue>();
            TblOrderLineAttributeValue = new HashSet<TblOrderLineAttributeValue>();
            TblOrganisationAttributeValue = new HashSet<TblOrganisationAttributeValue>();
            TblVenue = new HashSet<TblVenue>();
        }

        public int AddressId { get; set; }
        public int AddressTypeId { get; set; }
        public string HouseNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postcode { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public int? Dpid { get; set; }
        public string AddressBarcode { get; set; }
        public DateTime? CleanedDate { get; set; }

        public TblAddressType AddressType { get; set; }
        public ICollection<TblActivityTypeAttributeValue> TblActivityTypeAttributeValue { get; set; }
        public ICollection<TblCustomerAddress> TblCustomerAddress { get; set; }
        public ICollection<TblCustomerTypeAttributeValue> TblCustomerTypeAttributeValue { get; set; }
        public ICollection<TblOrderLineAttributeValue> TblOrderLineAttributeValue { get; set; }
        public ICollection<TblOrganisationAttributeValue> TblOrganisationAttributeValue { get; set; }
        public ICollection<TblVenue> TblVenue { get; set; }
    }
}
