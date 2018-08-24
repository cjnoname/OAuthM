using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblNotificationBuildResult
    {
        public int NotificationBuildResultId { get; set; }
        public int NotificationBuildId { get; set; }
        public int BuildMessageId { get; set; }
        public int? ShowVenuePerformanceId { get; set; }
        public int? ShowTagId { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public byte[] Tstamp { get; set; }

        public TblBuildMessage BuildMessage { get; set; }
        public TblNotificationBuild NotificationBuild { get; set; }
    }
}
