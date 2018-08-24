using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblForeignBarcode
    {
        public int ForeignBarcodeId { get; set; }
        public string BarcodeNumber { get; set; }
        public int OrganisationId { get; set; }
        public int SeasonId { get; set; }
        public int? Status { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public int? ProductId { get; set; }
        public int? PriceTypeId { get; set; }

        public TblOrganisation Organisation { get; set; }
        public TblPriceType PriceType { get; set; }
        public TblProduct Product { get; set; }
        public TblSeason Season { get; set; }
    }
}
