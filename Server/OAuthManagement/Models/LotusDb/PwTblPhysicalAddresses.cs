using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class PwTblPhysicalAddresses
    {
        public int PaId { get; set; }
        public string PaSource { get; set; }
        public string PaAddressLine1 { get; set; }
        public string PaAddressLine2 { get; set; }
        public string PaCity { get; set; }
        public string PaState { get; set; }
        public string PaCountry { get; set; }
        public string PaPostcode { get; set; }
        public decimal? PaLatitude { get; set; }
        public decimal? PaLongitude { get; set; }
    }
}
