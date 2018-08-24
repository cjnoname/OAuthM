using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblProductSelection
    {
        public TblProductSelection()
        {
            TblOrderLine = new HashSet<TblOrderLine>();
            TblProdSelProductJoin = new HashSet<TblProdSelProductJoin>();
            TblProductProdSelJoin = new HashSet<TblProductProdSelJoin>();
        }

        public int ProductSelectionId { get; set; }
        public string ProductSelectionName { get; set; }
        public short? Number { get; set; }
        public bool UseMemberRights { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public int OrganisationId { get; set; }
        public string ProductSelectionCode { get; set; }
        public int ProductSelectionType { get; set; }
        public string ProductSelectionBlurb { get; set; }
        public int? OrderTypes { get; set; }
        public bool DisplayQuantityInfo { get; set; }
        public bool Archived { get; set; }

        public TblOrganisation Organisation { get; set; }
        public ICollection<TblOrderLine> TblOrderLine { get; set; }
        public ICollection<TblProdSelProductJoin> TblProdSelProductJoin { get; set; }
        public ICollection<TblProductProdSelJoin> TblProductProdSelJoin { get; set; }
    }
}
