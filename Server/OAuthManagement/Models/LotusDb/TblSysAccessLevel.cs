using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSysAccessLevel
    {
        public TblSysAccessLevel()
        {
            TblGroupCustomerList = new HashSet<TblGroupCustomerList>();
            TblGroupCustomerType = new HashSet<TblGroupCustomerType>();
            TblGroupOrganisation = new HashSet<TblGroupOrganisation>();
            TblGroupPromoter = new HashSet<TblGroupPromoter>();
            TblGroupVenueManager = new HashSet<TblGroupVenueManager>();
        }

        public int AccessLevelId { get; set; }
        public string AccessLevelName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<TblGroupCustomerList> TblGroupCustomerList { get; set; }
        public ICollection<TblGroupCustomerType> TblGroupCustomerType { get; set; }
        public ICollection<TblGroupOrganisation> TblGroupOrganisation { get; set; }
        public ICollection<TblGroupPromoter> TblGroupPromoter { get; set; }
        public ICollection<TblGroupVenueManager> TblGroupVenueManager { get; set; }
    }
}
