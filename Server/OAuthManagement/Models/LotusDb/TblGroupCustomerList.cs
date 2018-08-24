using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblGroupCustomerList
    {
        public int RecordId { get; set; }
        public int GroupId { get; set; }
        public int CustomerListId { get; set; }
        public int AccessLevelId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblSysAccessLevel AccessLevel { get; set; }
        public TblCustomerList CustomerList { get; set; }
        public TblSysGroup Group { get; set; }
    }
}
