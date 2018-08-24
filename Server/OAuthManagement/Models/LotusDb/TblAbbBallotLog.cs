using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblAbbBallotLog
    {
        public int LogId { get; set; }
        public string BallotCode { get; set; }
        public string ActionDescription { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
