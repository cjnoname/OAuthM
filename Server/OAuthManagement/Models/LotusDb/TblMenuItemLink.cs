using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblMenuItemLink
    {
        public int MenuItemLinkId { get; set; }
        public int MenuItemId { get; set; }
        public int OrganisationId { get; set; }
        public int ApplicationId { get; set; }
        public string MenuGroupName { get; set; }
        public int? DisplayIndex { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblSysApplication Application { get; set; }
        public TblMenuItem MenuItem { get; set; }
        public TblOrganisation Organisation { get; set; }
    }
}
