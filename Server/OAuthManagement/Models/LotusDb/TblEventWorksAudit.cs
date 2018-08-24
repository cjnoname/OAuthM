using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblEventWorksAudit
    {
        public int LogId { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public int NotificationId { get; set; }
        public string NotificationName { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public DateTime Timestamp { get; set; }
        public string State { get; set; }
    }
}
