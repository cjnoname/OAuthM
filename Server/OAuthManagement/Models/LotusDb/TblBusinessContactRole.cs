using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblBusinessContactRole
    {
        public TblBusinessContactRole()
        {
            TblBusinessContact = new HashSet<TblBusinessContact>();
        }

        public int BusinessContactRoleId { get; set; }
        public string RoleName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<TblBusinessContact> TblBusinessContact { get; set; }
    }
}
