using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class InTblVenueSectionGroup
    {
        public int VenueSectionGroupId { get; set; }
        public int GroupId { get; set; }
        public string SectionGroupName { get; set; }
        public string SectionNames { get; set; }
        public byte[] Tstamp { get; set; }

        public InTblGroups Group { get; set; }
    }
}
