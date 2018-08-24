using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblNotificationBuild
    {
        public TblNotificationBuild()
        {
            TblNotificationBuildResult = new HashSet<TblNotificationBuildResult>();
        }

        public int NotificationBuildId { get; set; }
        public int NotificationId { get; set; }
        public int BuildTypeId { get; set; }
        public int BuiltPerformances { get; set; }
        public int UnBuiltPerformances { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public byte[] Tstamp { get; set; }

        public TblBuildType BuildType { get; set; }
        public TblNotification Notification { get; set; }
        public ICollection<TblNotificationBuildResult> TblNotificationBuildResult { get; set; }
    }
}
