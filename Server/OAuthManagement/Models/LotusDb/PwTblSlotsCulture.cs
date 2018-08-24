using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class PwTblSlotsCulture
    {
        public int ScId { get; set; }
        public int ScSlid { get; set; }
        public string ScNcvcode { get; set; }
        public string ScHeading { get; set; }
        public string ScImageLarge { get; set; }
        public string ScSummary { get; set; }

        public PwTblSlots ScSl { get; set; }
    }
}
