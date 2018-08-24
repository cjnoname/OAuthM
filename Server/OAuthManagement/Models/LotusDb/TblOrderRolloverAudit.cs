using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOrderRolloverAudit
    {
        public int Id { get; set; }
        public int RunId { get; set; }
        public int OrganisationId { get; set; }
        public int OrderId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public TblOrganisation Organisation { get; set; }
    }
}
