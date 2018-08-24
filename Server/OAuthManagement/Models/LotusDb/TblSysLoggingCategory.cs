using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class TblSysLoggingCategory
    {
        public TblSysLoggingCategory()
        {
            TblSysCategoryExceptionLog = new HashSet<TblSysCategoryExceptionLog>();
            TblSysCategoryLog = new HashSet<TblSysCategoryLog>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public ICollection<TblSysCategoryExceptionLog> TblSysCategoryExceptionLog { get; set; }
        public ICollection<TblSysCategoryLog> TblSysCategoryLog { get; set; }
    }
}
