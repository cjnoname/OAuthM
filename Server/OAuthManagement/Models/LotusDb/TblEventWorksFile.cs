using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblEventWorksFile
    {
        public int FileId { get; set; }
        public int NotificationId { get; set; }
        public string Context { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public TblFile File { get; set; }
        public TblNotification Notification { get; set; }
    }
}
