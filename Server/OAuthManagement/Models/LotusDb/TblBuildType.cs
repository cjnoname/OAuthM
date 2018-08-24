using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblBuildType
    {
        public TblBuildType()
        {
            TblNotificationBuild = new HashSet<TblNotificationBuild>();
        }

        public int BuildTypeId { get; set; }
        public string BuildTypeDescription { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<TblNotificationBuild> TblNotificationBuild { get; set; }
    }
}
