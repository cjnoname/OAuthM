using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblProductMemberShopItem
    {
        public int ProductMemberShopItemId { get; set; }
        public int OrganisationId { get; set; }
        public int ProductId { get; set; }
        public bool HasSizes { get; set; }
        public bool HasColors { get; set; }
        public bool HasProductPhotos { get; set; }
        public bool HasCustomizedText { get; set; }
        public int? CustomizedTextLength { get; set; }
        public string CustomizedTextLabel { get; set; }
        public bool HasCustomField { get; set; }
        public string CustomFieldName { get; set; }
        public bool HasExtraCustomField { get; set; }
        public string ExtraCustomFieldName { get; set; }
        public decimal Price { get; set; }
        public bool TrackAvailability { get; set; }
        public int AvailableItems { get; set; }
        public string HeroDescription { get; set; }
        public bool? AllowPartPayments { get; set; }
        public bool? AllowPrePayments { get; set; }
        public bool? DisableEzyTicket { get; set; }
        public bool? DisableMobileTicket { get; set; }

        public TblOrganisation Organisation { get; set; }
        public TblProduct Product { get; set; }
    }
}
