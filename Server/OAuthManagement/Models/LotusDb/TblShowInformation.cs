using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblShowInformation
    {
        public int ShowInformationId { get; set; }
        public int ShowVenueId { get; set; }
        public string NickName { get; set; }
        public string EventType { get; set; }
        public string MarketingType1 { get; set; }
        public string MarketingType2 { get; set; }
        public string MarketingType3 { get; set; }
        public string MarketingType4 { get; set; }
        public string AccountFile { get; set; }
        public string ShowWebSiteUrl { get; set; }
        public bool? CustomerAccountRequired { get; set; }
        public int? ShowAbn { get; set; }
        public string CustomAbn { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public byte[] Tstamp { get; set; }

        public TblShowVenue ShowVenue { get; set; }
    }
}
