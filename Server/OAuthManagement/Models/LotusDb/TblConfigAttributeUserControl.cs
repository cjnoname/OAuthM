using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblConfigAttributeUserControl
    {
        public TblConfigAttributeUserControl()
        {
            TblConfigAttributeGroup = new HashSet<TblConfigAttributeGroup>();
        }

        public int GroupId { get; set; }
        public int OrganisationId { get; set; }
        public int ApplicationId { get; set; }
        public string AttributeGroupName { get; set; }
        public int EntityId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblSysApplication Application { get; set; }
        public TblConfigAttributeEntity Entity { get; set; }
        public TblOrganisation Organisation { get; set; }
        public ICollection<TblConfigAttributeGroup> TblConfigAttributeGroup { get; set; }
    }
}
