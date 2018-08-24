using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class PwTblSessionState
    {
        public int StateId { get; set; }
        public DateTime StateCreation { get; set; }
        public int StateLength { get; set; }
        public byte[] StateData { get; set; }
        public bool StateVerify { get; set; }
    }
}
