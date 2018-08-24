using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSysGroup
    {
        public TblSysGroup()
        {
            TblGroupCustomerList = new HashSet<TblGroupCustomerList>();
            TblGroupCustomerType = new HashSet<TblGroupCustomerType>();
            TblGroupOrganisation = new HashSet<TblGroupOrganisation>();
            TblGroupPromoter = new HashSet<TblGroupPromoter>();
            TblGroupVenueManager = new HashSet<TblGroupVenueManager>();
            TblSysSecurityGroupTask = new HashSet<TblSysSecurityGroupTask>();
            TblSysUserGroup = new HashSet<TblSysUserGroup>();
        }

        public int GroupId { get; set; }
        public int GroupTypeId { get; set; }
        public string GroupName { get; set; }
        public bool IsDisabled { get; set; }
        public int? BusinessId { get; set; }
        public string Description { get; set; }
        public string MailingAddress { get; set; }
        public string Phone { get; set; }
        public string EmailAddress { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblBusiness Business { get; set; }
        public TblSysGroupType GroupType { get; set; }
        public ICollection<TblGroupCustomerList> TblGroupCustomerList { get; set; }
        public ICollection<TblGroupCustomerType> TblGroupCustomerType { get; set; }
        public ICollection<TblGroupOrganisation> TblGroupOrganisation { get; set; }
        public ICollection<TblGroupPromoter> TblGroupPromoter { get; set; }
        public ICollection<TblGroupVenueManager> TblGroupVenueManager { get; set; }
        public ICollection<TblSysSecurityGroupTask> TblSysSecurityGroupTask { get; set; }
        public ICollection<TblSysUserGroup> TblSysUserGroup { get; set; }
    }
}
