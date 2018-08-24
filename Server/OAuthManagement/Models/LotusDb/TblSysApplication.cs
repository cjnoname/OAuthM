using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSysApplication
    {
        public TblSysApplication()
        {
            TblConfigAttribute = new HashSet<TblConfigAttribute>();
            TblConfigAttributeStore = new HashSet<TblConfigAttributeStore>();
            TblConfigAttributeUserControl = new HashSet<TblConfigAttributeUserControl>();
            TblMenuItem = new HashSet<TblMenuItem>();
            TblMenuItemLink = new HashSet<TblMenuItemLink>();
            TblSysSecurityOperation = new HashSet<TblSysSecurityOperation>();
            TblSysSecurityTask = new HashSet<TblSysSecurityTask>();
            TblSysUserPreference = new HashSet<TblSysUserPreference>();
            TblTransmissionCredential = new HashSet<TblTransmissionCredential>();
        }

        public int ApplicationId { get; set; }
        public string ApplicationName { get; set; }
        public string ApplicationDescription { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<TblConfigAttribute> TblConfigAttribute { get; set; }
        public ICollection<TblConfigAttributeStore> TblConfigAttributeStore { get; set; }
        public ICollection<TblConfigAttributeUserControl> TblConfigAttributeUserControl { get; set; }
        public ICollection<TblMenuItem> TblMenuItem { get; set; }
        public ICollection<TblMenuItemLink> TblMenuItemLink { get; set; }
        public ICollection<TblSysSecurityOperation> TblSysSecurityOperation { get; set; }
        public ICollection<TblSysSecurityTask> TblSysSecurityTask { get; set; }
        public ICollection<TblSysUserPreference> TblSysUserPreference { get; set; }
        public ICollection<TblTransmissionCredential> TblTransmissionCredential { get; set; }
    }
}
