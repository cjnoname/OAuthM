using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblCardType
    {
        public TblCardType()
        {
            TblCreditCardDetails = new HashSet<TblCreditCardDetails>();
            TblOrganisationCardType = new HashSet<TblOrganisationCardType>();
        }

        public int CardTypeId { get; set; }
        public string CardTypeDetail { get; set; }
        public bool? HasCvc { get; set; }
        public bool? RequiresCvc { get; set; }
        public bool? RequiresFromDate { get; set; }
        public string PrefixPattern { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public string ExtRefCode { get; set; }
        public string OriginPayTypeCode { get; set; }

        public ICollection<TblCreditCardDetails> TblCreditCardDetails { get; set; }
        public ICollection<TblOrganisationCardType> TblOrganisationCardType { get; set; }
    }
}
