using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblMembership
    {
        public TblMembership()
        {
            TblMemGroupMembershipJoin = new HashSet<TblMemGroupMembershipJoin>();
            TblOrderDelegation = new HashSet<TblOrderDelegation>();
            TblOrderLine = new HashSet<TblOrderLine>();
        }

        public int MembershipId { get; set; }
        public string MembershipNumber { get; set; }
        public int OrganisationCustomerId { get; set; }
        public int MembershipProductId { get; set; }
        public int RightsEntitlement { get; set; }
        public int? MaxTicketEntitlement { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int? SeatZonePreferenceId { get; set; }

        public TblMembershipProduct MembershipProduct { get; set; }
        public TblMember OrganisationCustomer { get; set; }
        public TblSeatZonePreference SeatZonePreference { get; set; }
        public ICollection<TblMemGroupMembershipJoin> TblMemGroupMembershipJoin { get; set; }
        public ICollection<TblOrderDelegation> TblOrderDelegation { get; set; }
        public ICollection<TblOrderLine> TblOrderLine { get; set; }
    }
}
