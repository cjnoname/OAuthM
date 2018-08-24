using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class BaseTable
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }
        public string ComputedCol { get; set; }
    }
}
