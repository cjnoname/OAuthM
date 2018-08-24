using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblEnquiryFilter
    {
        public TblEnquiryFilter()
        {
            InverseDrillDown1 = new HashSet<TblEnquiryFilter>();
            InverseDrillDown2 = new HashSet<TblEnquiryFilter>();
            InverseDrillDown3 = new HashSet<TblEnquiryFilter>();
            InverseDrillDown4 = new HashSet<TblEnquiryFilter>();
            InverseDrillDown5 = new HashSet<TblEnquiryFilter>();
            TblEnquiryFilterParam = new HashSet<TblEnquiryFilterParam>();
        }

        public int EnquiryFilterId { get; set; }
        public int OrganisationId { get; set; }
        public string EnquiryName { get; set; }
        public int DbobjectType { get; set; }
        public string DbobjectName { get; set; }
        public string Description { get; set; }
        public int? EnquiryEditId { get; set; }
        public int? DrillDown1Id { get; set; }
        public int? DrillDown2Id { get; set; }
        public int? DrillDown3Id { get; set; }
        public int? DrillDown4Id { get; set; }
        public int? DrillDown5Id { get; set; }
        public string Category { get; set; }
        public string PageTitle { get; set; }
        public int? HideColumns { get; set; }
        public int? HideGridLines { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public int? Timeout { get; set; }

        public TblEnquiryFilter DrillDown1 { get; set; }
        public TblEnquiryFilter DrillDown2 { get; set; }
        public TblEnquiryFilter DrillDown3 { get; set; }
        public TblEnquiryFilter DrillDown4 { get; set; }
        public TblEnquiryFilter DrillDown5 { get; set; }
        public TblEnquiryEdit EnquiryEdit { get; set; }
        public TblOrganisation Organisation { get; set; }
        public ICollection<TblEnquiryFilter> InverseDrillDown1 { get; set; }
        public ICollection<TblEnquiryFilter> InverseDrillDown2 { get; set; }
        public ICollection<TblEnquiryFilter> InverseDrillDown3 { get; set; }
        public ICollection<TblEnquiryFilter> InverseDrillDown4 { get; set; }
        public ICollection<TblEnquiryFilter> InverseDrillDown5 { get; set; }
        public ICollection<TblEnquiryFilterParam> TblEnquiryFilterParam { get; set; }
    }
}
