using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblMembershipProduct
    {
        public TblMembershipProduct()
        {
            TblMembership = new HashSet<TblMembership>();
            TblMembershipOrganisation = new HashSet<TblMembershipOrganisation>();
            TblMembershipProductPackageJoin = new HashSet<TblMembershipProductPackageJoin>();
            TblMembershipPromotion = new HashSet<TblMembershipPromotion>();
            TblOrderBaseClassificationGroup = new HashSet<TblOrderBaseClassificationGroup>();
            TblPackageMembershipProductOverride = new HashSet<TblPackageMembershipProductOverride>();
            TblPriceTypeMembershipProduct = new HashSet<TblPriceTypeMembershipProduct>();
        }

        public int ProductId { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int? RightsEntitlement { get; set; }
        public int? MaxTicketEntitlement { get; set; }
        public int? MaxGuestsAllowed { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public int? DurationMonths { get; set; }
        public bool? AllowPrepayments { get; set; }

        public TblProduct Product { get; set; }
        public ICollection<TblMembership> TblMembership { get; set; }
        public ICollection<TblMembershipOrganisation> TblMembershipOrganisation { get; set; }
        public ICollection<TblMembershipProductPackageJoin> TblMembershipProductPackageJoin { get; set; }
        public ICollection<TblMembershipPromotion> TblMembershipPromotion { get; set; }
        public ICollection<TblOrderBaseClassificationGroup> TblOrderBaseClassificationGroup { get; set; }
        public ICollection<TblPackageMembershipProductOverride> TblPackageMembershipProductOverride { get; set; }
        public ICollection<TblPriceTypeMembershipProduct> TblPriceTypeMembershipProduct { get; set; }
    }
}
