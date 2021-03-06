﻿using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblGiftCard
    {
        public int GiftCardId { get; set; }
        public int? VoucherId { get; set; }
        public string GiftCardIdentifier { get; set; }
        public string CompanyCode { get; set; }
        public string ProductCode { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }

        public TblVoucher1 Voucher { get; set; }
    }
}
