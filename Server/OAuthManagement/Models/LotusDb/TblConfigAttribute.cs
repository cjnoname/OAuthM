using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblConfigAttribute
    {
        public TblConfigAttribute()
        {
            TblConfigAttributeGroup = new HashSet<TblConfigAttributeGroup>();
            TblConfigAttributeList = new HashSet<TblConfigAttributeList>();
            TblConfigAttributeUrl = new HashSet<TblConfigAttributeUrl>();
            TblConfigAttributeValue = new HashSet<TblConfigAttributeValue>();
        }

        public int AttributeId { get; set; }
        public int OrganisationId { get; set; }
        public int ApplicationId { get; set; }
        public int ControlTypeId { get; set; }
        public string AttributeDefaultValue { get; set; }
        public string AttributeErrorMsg { get; set; }
        public bool AttributeMandatory { get; set; }
        public bool AttributeForceSave { get; set; }
        public string AttributeCss { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public string AttributeDescription { get; set; }

        public TblSysApplication Application { get; set; }
        public TblConfigAttributeControl ControlType { get; set; }
        public TblOrganisation Organisation { get; set; }
        public ICollection<TblConfigAttributeGroup> TblConfigAttributeGroup { get; set; }
        public ICollection<TblConfigAttributeList> TblConfigAttributeList { get; set; }
        public ICollection<TblConfigAttributeUrl> TblConfigAttributeUrl { get; set; }
        public ICollection<TblConfigAttributeValue> TblConfigAttributeValue { get; set; }
    }
}
