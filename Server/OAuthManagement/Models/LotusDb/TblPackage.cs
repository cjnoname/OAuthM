using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblPackage
    {
        public TblPackage()
        {
            TblConcurrentPackageSourceProduct = new HashSet<TblConcurrentPackage>();
            TblConcurrentPackageTargetProduct = new HashSet<TblConcurrentPackage>();
            TblMembershipProductPackageJoin = new HashSet<TblMembershipProductPackageJoin>();
            TblPackageMembershipProductOverride = new HashSet<TblPackageMembershipProductOverride>();
            TblPackageUmbrellaJoinChildProduct = new HashSet<TblPackageUmbrellaJoin>();
            TblPackageUmbrellaJoinProduct = new HashSet<TblPackageUmbrellaJoin>();
            TblSeatAttribute = new HashSet<TblSeatAttribute>();
            TblSourcePerformancePackageJoin = new HashSet<TblSourcePerformancePackageJoin>();
            TblSourceSeatAttribute = new HashSet<TblSourceSeatAttribute>();
            TblSubscriptionPackageVenue = new HashSet<TblSubscriptionPackageVenue>();
        }

        public int ProductId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public bool AllowGuests { get; set; }
        public bool? IgnoreMemberRights { get; set; }
        public int? AllowPartPayments { get; set; }
        public int? AllowPrePayments { get; set; }
        public string HeroDescription { get; set; }
        public DateTime? EventDate { get; set; }
        public int? SpecialEventGameType { get; set; }
        public int? QtyLimit { get; set; }
        public bool? IncludePriceTypeAdmit { get; set; }
        public bool? EnforceTicketEntitlement { get; set; }
        public bool? DisableEzyTicket { get; set; }
        public bool? DisableMobileTicket { get; set; }
        public string ShortTextAttribute { get; set; }

        public TblProduct Product { get; set; }
        public ICollection<TblConcurrentPackage> TblConcurrentPackageSourceProduct { get; set; }
        public ICollection<TblConcurrentPackage> TblConcurrentPackageTargetProduct { get; set; }
        public ICollection<TblMembershipProductPackageJoin> TblMembershipProductPackageJoin { get; set; }
        public ICollection<TblPackageMembershipProductOverride> TblPackageMembershipProductOverride { get; set; }
        public ICollection<TblPackageUmbrellaJoin> TblPackageUmbrellaJoinChildProduct { get; set; }
        public ICollection<TblPackageUmbrellaJoin> TblPackageUmbrellaJoinProduct { get; set; }
        public ICollection<TblSeatAttribute> TblSeatAttribute { get; set; }
        public ICollection<TblSourcePerformancePackageJoin> TblSourcePerformancePackageJoin { get; set; }
        public ICollection<TblSourceSeatAttribute> TblSourceSeatAttribute { get; set; }
        public ICollection<TblSubscriptionPackageVenue> TblSubscriptionPackageVenue { get; set; }
    }
}
