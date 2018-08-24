using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblAddressType
    {
        public TblAddressType()
        {
            TblActivityTypeCommonAttribute = new HashSet<TblActivityTypeCommonAttribute>();
            TblAddress = new HashSet<TblAddress>();
            TblCustomerTypeCommonAttribute = new HashSet<TblCustomerTypeCommonAttribute>();
            TblOrderLineCommonAttribute = new HashSet<TblOrderLineCommonAttribute>();
            TblOrganisationCommonAttribute = new HashSet<TblOrganisationCommonAttribute>();
        }

        public int AddressTypeId { get; set; }
        public string AddressTypeName { get; set; }
        public bool? HouseNumberIsEnabled { get; set; }
        public bool? HouseNumberIsRequired { get; set; }
        public string HouseNumberLabel { get; set; }
        public bool? ApartmentNumberIsEnabled { get; set; }
        public bool? ApartmentNumberIsRequired { get; set; }
        public string ApartmentNumberLabel { get; set; }
        public bool? AddressLine1IsEnabled { get; set; }
        public bool? AddressLine1IsRequired { get; set; }
        public string AddressLine1Label { get; set; }
        public bool? AddressLine2IsEnabled { get; set; }
        public bool? AddressLine2IsRequired { get; set; }
        public string AddressLine2Label { get; set; }
        public bool? AddressLine3IsEnabled { get; set; }
        public bool? AddressLine3IsRequired { get; set; }
        public string AddressLine3Label { get; set; }
        public bool? CityIsEnabled { get; set; }
        public bool? CityIsRequired { get; set; }
        public string CityLabel { get; set; }
        public bool? StateIsEnabled { get; set; }
        public bool? StateIsRequired { get; set; }
        public string StateLabel { get; set; }
        public bool? CountryCodeIsEnabled { get; set; }
        public bool? CountryCodeIsRequired { get; set; }
        public string CountryCodeLabel { get; set; }
        public bool? CountryNameIsEnabled { get; set; }
        public bool? CountryNameIsRequired { get; set; }
        public string CountryNameLabel { get; set; }
        public bool? PostCodeIsEnabled { get; set; }
        public bool? PostCodeIsRequired { get; set; }
        public string PostCodeLabel { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<TblActivityTypeCommonAttribute> TblActivityTypeCommonAttribute { get; set; }
        public ICollection<TblAddress> TblAddress { get; set; }
        public ICollection<TblCustomerTypeCommonAttribute> TblCustomerTypeCommonAttribute { get; set; }
        public ICollection<TblOrderLineCommonAttribute> TblOrderLineCommonAttribute { get; set; }
        public ICollection<TblOrganisationCommonAttribute> TblOrganisationCommonAttribute { get; set; }
    }
}
