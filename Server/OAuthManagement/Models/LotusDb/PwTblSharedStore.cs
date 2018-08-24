using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class PwTblSharedStore
    {
        public int SsId { get; set; }
        public DateTime SsDateCreated { get; set; }
        public DateTime SsDateModified { get; set; }
        public string SsCrc { get; set; }
        public string SsKey { get; set; }
        public string SsValue { get; set; }
    }
}
