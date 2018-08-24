using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblEnquiryFilterParam
    {
        public int EnquiryFilterParamId { get; set; }
        public int EnquiryFilterId { get; set; }
        public int Sequence { get; set; }
        public string ParamName { get; set; }
        public int ParamDataTypeId { get; set; }
        public string ColumnName { get; set; }
        public int? UseDefault { get; set; }
        public string DefaultValue { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] Tstamp { get; set; }
        public bool? IsOptional { get; set; }
        public string InputMask { get; set; }
        public string InputHelpText { get; set; }
        public string ToolTip { get; set; }

        public TblEnquiryFilter EnquiryFilter { get; set; }
        public TblAttributeDataType ParamDataType { get; set; }
    }
}
