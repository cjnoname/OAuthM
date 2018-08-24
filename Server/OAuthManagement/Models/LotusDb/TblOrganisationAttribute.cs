﻿using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOrganisationAttribute
    {
        public TblOrganisationAttribute()
        {
            TblOrganisationAttributeValue = new HashSet<TblOrganisationAttributeValue>();
        }

        public int AttributeId { get; set; }
        public int OrganisationId { get; set; }
        public int CommonAttributeId { get; set; }
        public int AttributeDataTypeId { get; set; }
        public string AttributeName { get; set; }
        public string DisplayLabel { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsRequired { get; set; }
        public string ValidationText { get; set; }
        public string ValidationError { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblAttributeDataType AttributeDataType { get; set; }
        public TblOrganisationCommonAttribute CommonAttribute { get; set; }
        public TblOrganisation Organisation { get; set; }
        public ICollection<TblOrganisationAttributeValue> TblOrganisationAttributeValue { get; set; }
    }
}
