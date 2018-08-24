using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblMember
    {
        public TblMember()
        {
            TblMemberRollover = new HashSet<TblMemberRollover>();
            TblMembership = new HashSet<TblMembership>();
            TblMembershipGroup = new HashSet<TblMembershipGroup>();
            TblOrderDelegation = new HashSet<TblOrderDelegation>();
            TblPrimaryMemberPrimaryOrganisationCustomer = new HashSet<TblPrimaryMember>();
            TblPrimaryMemberSecondaryOrganisationCustomer = new HashSet<TblPrimaryMember>();
            TblSeatingGroup = new HashSet<TblSeatingGroup>();
            TblSeatingGroupMemberJoin = new HashSet<TblSeatingGroupMemberJoin>();
        }

        public int OrganisationCustomerId { get; set; }
        public string MemberNumber { get; set; }
        public short? FailedLoginAttempts { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public string UserName { get; set; }
        public byte[] Password { get; set; }
        public bool IsLocked { get; set; }
        public DateTime? MemberSince { get; set; }
        public string ExtRefCode { get; set; }

        public TblOrganisationCustomer OrganisationCustomer { get; set; }
        public ICollection<TblMemberRollover> TblMemberRollover { get; set; }
        public ICollection<TblMembership> TblMembership { get; set; }
        public ICollection<TblMembershipGroup> TblMembershipGroup { get; set; }
        public ICollection<TblOrderDelegation> TblOrderDelegation { get; set; }
        public ICollection<TblPrimaryMember> TblPrimaryMemberPrimaryOrganisationCustomer { get; set; }
        public ICollection<TblPrimaryMember> TblPrimaryMemberSecondaryOrganisationCustomer { get; set; }
        public ICollection<TblSeatingGroup> TblSeatingGroup { get; set; }
        public ICollection<TblSeatingGroupMemberJoin> TblSeatingGroupMemberJoin { get; set; }
    }
}
