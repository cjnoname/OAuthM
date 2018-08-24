using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblProductCategory
    {
        public TblProductCategory()
        {
            TblOrderLine = new HashSet<TblOrderLine>();
            TblProductCategoryCapacity = new HashSet<TblProductCategoryCapacity>();
            TblProductPricing = new HashSet<TblProductPricing>();
            TblSeatingPreference = new HashSet<TblSeatingPreference>();
            TblShoppingCartItem = new HashSet<TblShoppingCartItem>();
            TblSitWith = new HashSet<TblSitWith>();
            TblSubscription = new HashSet<TblSubscription>();
        }

        public int ProductCategoryId { get; set; }
        public int OrganisationId { get; set; }
        public string CategoryCode { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string ForegroundColour { get; set; }
        public string BackgroundColour { get; set; }
        public bool Archived { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public string ExtRefCode { get; set; }
        public bool? IsDefaultForMerchandise { get; set; }

        public TblOrganisation Organisation { get; set; }
        public ICollection<TblOrderLine> TblOrderLine { get; set; }
        public ICollection<TblProductCategoryCapacity> TblProductCategoryCapacity { get; set; }
        public ICollection<TblProductPricing> TblProductPricing { get; set; }
        public ICollection<TblSeatingPreference> TblSeatingPreference { get; set; }
        public ICollection<TblShoppingCartItem> TblShoppingCartItem { get; set; }
        public ICollection<TblSitWith> TblSitWith { get; set; }
        public ICollection<TblSubscription> TblSubscription { get; set; }
    }
}
