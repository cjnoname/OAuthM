using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSysUser
    {
        public TblSysUser()
        {
            TblSysUserGroup = new HashSet<TblSysUserGroup>();
            TblSysUserPreferenceUser = new HashSet<TblSysUserPreferenceUser>();
        }

        public int UserId { get; set; }
        public string Domain { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MailingAddress { get; set; }
        public string HomeAddress { get; set; }
        public string Phone { get; set; }
        public string EmailAddress { get; set; }
        public string Location { get; set; }
        public bool IsLocked { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblSysUserMonitor TblSysUserMonitor { get; set; }
        public ICollection<TblSysUserGroup> TblSysUserGroup { get; set; }
        public ICollection<TblSysUserPreferenceUser> TblSysUserPreferenceUser { get; set; }
    }
}
