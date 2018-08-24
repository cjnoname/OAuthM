using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblMenuItemTarget
    {
        public TblMenuItemTarget()
        {
            TblMenuItem = new HashSet<TblMenuItem>();
        }

        public int MenuItemTargetId { get; set; }
        public string TargetLocation { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<TblMenuItem> TblMenuItem { get; set; }
    }
}
