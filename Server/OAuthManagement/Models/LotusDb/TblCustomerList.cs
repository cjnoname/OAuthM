using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblCustomerList
    {
        public TblCustomerList()
        {
            TblCustomer = new HashSet<TblCustomer>();
            TblGroupCustomerList = new HashSet<TblGroupCustomerList>();
            TblMembershipOrganisation = new HashSet<TblMembershipOrganisation>();
        }

        public int CustomerListId { get; set; }
        public string ListName { get; set; }
        public string Description { get; set; }
        public int? BusinessId { get; set; }
        public bool? IsVisible { get; set; }
        public bool IsDisabled { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public ICollection<TblCustomer> TblCustomer { get; set; }
        public ICollection<TblGroupCustomerList> TblGroupCustomerList { get; set; }
        public ICollection<TblMembershipOrganisation> TblMembershipOrganisation { get; set; }
    }
}
