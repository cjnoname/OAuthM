using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSysUserPreferenceUser
    {
        public int UserPreferenceUserId { get; set; }
        public int UserPreferenceId { get; set; }
        public int? UserPreferenceChoiceId { get; set; }
        public int UserId { get; set; }
        public string Value { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblSysUser User { get; set; }
        public TblSysUserPreference UserPreference { get; set; }
        public TblSysUserPreferenceChoice UserPreferenceChoice { get; set; }
    }
}
