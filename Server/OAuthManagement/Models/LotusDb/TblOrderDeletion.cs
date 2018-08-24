using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblOrderDeletion
    {
        public int OrderDeletionId { get; set; }
        public int OrderId { get; set; }
        public int? OrderLineId { get; set; }
        public int OrganisationId { get; set; }
        public int? SeasonId { get; set; }
        public DateTime? RequestProcessedDate { get; set; }
        public string ResponseMessage { get; set; }
        public int? RequestFail { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public string OrderXml { get; set; }
        public int? SubscriptionId { get; set; }
        public int? SubscriptionAllocationId { get; set; }

        public TblOrganisation Organisation { get; set; }
        public TblSeason Season { get; set; }
    }
}
