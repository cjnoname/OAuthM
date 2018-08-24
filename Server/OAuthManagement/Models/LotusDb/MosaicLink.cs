using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class MosaicLink
    {
        public int Dpid { get; set; }
        public string MosaicType { get; set; }
        public string MosaicGroup { get; set; }
    }
}
