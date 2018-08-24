using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class PwTblFiles
    {
        public int FlId { get; set; }
        public byte[] FlData { get; set; }
        public string FlOriginalName { get; set; }
        public string FlExtension { get; set; }
        public string FlDescription { get; set; }
        public DateTime FlDateEntered { get; set; }
        public int FlReferenceCount { get; set; }
        public bool FlExternalUse { get; set; }
        public string FlExternalDescription { get; set; }
    }
}
