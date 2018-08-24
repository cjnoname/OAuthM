using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblContact
    {
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public string PhoneCountryCode { get; set; }
        public string PhoneAreaCode { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxCountryCode { get; set; }
        public string FaxAreaCode { get; set; }
        public string FaxNumber { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
    }
}
