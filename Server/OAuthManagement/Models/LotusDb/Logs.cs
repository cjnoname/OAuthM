using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class Logs
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double? Salary { get; set; }
        public string Department { get; set; }
    }
}
