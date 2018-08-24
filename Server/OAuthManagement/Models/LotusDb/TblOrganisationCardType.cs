using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOrganisationCardType
    {
        public int OrganisationId { get; set; }
        public int CardTypeId { get; set; }
        public bool? DisabledOnMemberSite { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public int SortOrder { get; set; }

        public TblCardType CardType { get; set; }
        public TblOrganisation Organisation { get; set; }
    }
}
