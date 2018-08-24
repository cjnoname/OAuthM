using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblNotification
    {
        public TblNotification()
        {
            TblEventWorksFile = new HashSet<TblEventWorksFile>();
            TblNotificationBuild = new HashSet<TblNotificationBuild>();
            TblNotificationPart = new HashSet<TblNotificationPart>();
        }

        public int NotificationId { get; set; }
        public string State { get; set; }
        public int OwnerId { get; set; }
        public int AssignedId { get; set; }
        public string Name { get; set; }
        public DateTime? DueDate { get; set; }
        public int ShowVenueId { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public byte[] Tstamp { get; set; }
        public DateTime? ArchiveDate { get; set; }
        public int? Year { get; set; }
        public int? CopiedFromNotificationId { get; set; }

        public TblShowVenue ShowVenue { get; set; }
        public ICollection<TblEventWorksFile> TblEventWorksFile { get; set; }
        public ICollection<TblNotificationBuild> TblNotificationBuild { get; set; }
        public ICollection<TblNotificationPart> TblNotificationPart { get; set; }
    }
}
