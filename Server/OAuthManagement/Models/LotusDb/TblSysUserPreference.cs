using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSysUserPreference
    {
        public TblSysUserPreference()
        {
            TblSysUserPreferenceChoice = new HashSet<TblSysUserPreferenceChoice>();
            TblSysUserPreferenceUser = new HashSet<TblSysUserPreferenceUser>();
        }

        public int UserPreferenceId { get; set; }
        public int ApplicationId { get; set; }
        public int AttributeDataTypeId { get; set; }
        public string UserPreferenceName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblSysApplication Application { get; set; }
        public TblAttributeDataType AttributeDataType { get; set; }
        public ICollection<TblSysUserPreferenceChoice> TblSysUserPreferenceChoice { get; set; }
        public ICollection<TblSysUserPreferenceUser> TblSysUserPreferenceUser { get; set; }
    }
}
