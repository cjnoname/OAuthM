using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOriginOrderMap
    {
        public int OrderId { get; set; }
        public int BasketLeaderTnum { get; set; }
        public int BasketLeaderDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public TblOrder TblOrder { get; set; }
    }
}
