using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblBallotEntry
    {
        public TblBallotEntry()
        {
            TblBallotEntryMember = new HashSet<TblBallotEntryMember>();
            TblBallotGroupEntryBallotEntry = new HashSet<TblBallotGroupEntryBallotEntry>();
        }

        public int BallotEntryId { get; set; }
        public int BallotId { get; set; }
        public int? BallotSeatingChoiceId { get; set; }
        public int? BallotProcessStatusId { get; set; }
        public byte? PriorityBandAllocationOrder { get; set; }
        public DateTime? RegistrationDateTime { get; set; }
        public string DisabledComments { get; set; }
        public string CreditCardName { get; set; }
        public byte[] CreditCardNumber { get; set; }
        public string CreditCardExpiry { get; set; }
        public int? ProcessingOrder { get; set; }
        public int? BasketLeaderTransactionDate { get; set; }
        public int? BasketLeaderTransactionNumber { get; set; }
        public int? AllocationTransactionDate { get; set; }
        public int? AllocationTransactionNumber { get; set; }
        public string AllocationSeating { get; set; }
        public int? CustomerId { get; set; }
        public string OriginAccountFile { get; set; }
        public int? OriginAccountNumber { get; set; }
        public string DeliveryType { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public string CreditCardHolderName { get; set; }
        public string RegistrationChannelCode { get; set; }
        public string RegistrationSellerCode { get; set; }
        public string RegistrationPerformanceCode { get; set; }
        public int? RegistrationPriceCategory { get; set; }
        public string RegistrationSourcePriceType { get; set; }
        public string AllocationPerformanceCode { get; set; }
        public decimal? SalesAmount { get; set; }
        public decimal? AmountPaid { get; set; }
        public decimal? HandlingFeeAmount { get; set; }

        public TblBallot Ballot { get; set; }
        public TblBallotProcessStatus BallotProcessStatus { get; set; }
        public TblBallotSeatingChoice BallotSeatingChoice { get; set; }
        public TblBallotEntryCustomer TblBallotEntryCustomer { get; set; }
        public ICollection<TblBallotEntryMember> TblBallotEntryMember { get; set; }
        public ICollection<TblBallotGroupEntryBallotEntry> TblBallotGroupEntryBallotEntry { get; set; }
    }
}
