using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class PwTblShowPerCulture
    {
        public int ScId { get; set; }
        public int ScShid { get; set; }
        public string ScNcvcode { get; set; }
        public string ScTitle { get; set; }
        public string ScSummary { get; set; }
        public string ScSynopsis { get; set; }
        public byte ScPsvid { get; set; }
        public string ScKeywords { get; set; }
        public string ScShowImageLarge { get; set; }
        public string ScShowImageMedium { get; set; }
        public string ScShowImageSmall { get; set; }
        public string ScAltTextLarge { get; set; }
        public string ScAltTextMedium { get; set; }
        public string ScAltTextSmall { get; set; }

        public PwTblNeutralCultureValues ScNcvcodeNavigation { get; set; }
        public PwTblPublishStatusValues ScPsv { get; set; }
        public PwTblShows ScSh { get; set; }
    }
}
