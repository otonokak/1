using System;
using System.Data;

namespace GodelTech.AreaMonitor.Dal.Models
{
    public class WebPageUpdate : BaseEntity
    {
        public byte[] PageContent { get; set; }

        public DateTime ScheduledDate { get; set; }

        public bool Status { get; set; }

        public DateTime ProcessingDate { get; set; }

        public virtual UserWebPage UserWebPage { get; set; }

        public int UserWebPageId { get; set; }
    }
}
