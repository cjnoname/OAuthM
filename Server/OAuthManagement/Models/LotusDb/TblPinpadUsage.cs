using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblPinpadUsage
    {
        public int PinpadUsageId { get; set; }
        public string ReferenceNumber { get; set; }
        public string MachineId { get; set; }
        public string AuthId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public bool IsCredit { get; set; }
        public bool IsUnionPay { get; set; }
    }
}
