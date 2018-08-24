using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblMenuItem
    {
        public TblMenuItem()
        {
            TblMenuItemLink = new HashSet<TblMenuItemLink>();
            TblMenuItemOperation = new HashSet<TblMenuItemOperation>();
        }

        public int MenuItemId { get; set; }
        public int MenuItemNumber { get; set; }
        public int OrganisationId { get; set; }
        public int ApplicationId { get; set; }
        public int MenuItemTargetId { get; set; }
        public string DisplayLabel { get; set; }
        public string Url { get; set; }
        public string Tooltip { get; set; }
        public string ImageUrl { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public int? ParentMenuItemNumber { get; set; }

        public TblSysApplication Application { get; set; }
        public TblMenuItemTarget MenuItemTarget { get; set; }
        public TblOrganisation Organisation { get; set; }
        public ICollection<TblMenuItemLink> TblMenuItemLink { get; set; }
        public ICollection<TblMenuItemOperation> TblMenuItemOperation { get; set; }
    }
}
