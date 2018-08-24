using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSysUserPreferenceChoice
    {
        public TblSysUserPreferenceChoice()
        {
            TblSysUserPreferenceUser = new HashSet<TblSysUserPreferenceUser>();
        }

        public int UserPreferenceChoiceId { get; set; }
        public int UserPreferenceId { get; set; }
        public string UserPreferenceChoiceName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblSysUserPreference UserPreference { get; set; }
        public ICollection<TblSysUserPreferenceUser> TblSysUserPreferenceUser { get; set; }
    }
}
