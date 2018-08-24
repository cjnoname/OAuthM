using System;
using System.Collections.Generic;

namespace OAuthManagement.Models.LotusDb
{
    public partial class PwTblScheduledBoxContent
    {
        public int ScheduledBoxContentId { get; set; }
        public DateTime ActivateAt { get; set; }
        public DateTime DeactivateAt { get; set; }
        public string BoxName { get; set; }
        public string Html { get; set; }
        public bool Enabled { get; set; }
        public string ScheduledBoxContentName { get; set; }
        public string SoftixCode { get; set; }
        public string ShowUrlOverride { get; set; }
        public string ShowTemplateUserControlOverride { get; set; }
    }
}
