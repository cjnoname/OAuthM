using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class InTblAuditLog
    {
        public int Id { get; set; }
        public decimal? Application { get; set; }
        public DateTime? Dt { get; set; }
        public decimal? Source { get; set; }
        public decimal? Category { get; set; }
        public decimal? EventId { get; set; }
        public decimal? Severity { get; set; }
        public string Userid { get; set; }
        public string Object { get; set; }
        public string Info { get; set; }
    }
}
