using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblActivityRecordJoin
    {
        public TblActivityRecordJoin()
        {
            TblOrganisationCustomerFileJoin = new HashSet<TblOrganisationCustomerFileJoin>();
        }

        public int ActivityRecordJoinId { get; set; }
        public int OrganisationCustomerId { get; set; }
        public int ActivityRecordId { get; set; }
        public int SellerId { get; set; }
        public int? FollowUpSellerId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblCustomerActivityRecord ActivityRecord { get; set; }
        public TblOrganisationCustomer OrganisationCustomer { get; set; }
        public ICollection<TblOrganisationCustomerFileJoin> TblOrganisationCustomerFileJoin { get; set; }
    }
}
