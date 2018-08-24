using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblNotificationPart
    {
        public int PartId { get; set; }
        public string Name { get; set; }
        public bool Complete { get; set; }
        public int NotificationId { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblNotification Notification { get; set; }
    }
}
