using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblCountry
    {
        public TblCountry()
        {
            TblRegion = new HashSet<TblRegion>();
        }

        public int CountryId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string DialingCode { get; set; }

        public ICollection<TblRegion> TblRegion { get; set; }
    }
}
