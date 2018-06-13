using System;

namespace GodelTech.AreaMonitor.Bll.Dto
{
    public class WebPageUpdateDto
    {
        public byte[] PageContent { get; set; }

        public DateTime ScheduledDate { get; set; }

        public int Status { get; set; }

        public DateTime ProcessingDate { get; set; }

        public int UserWebPageId { get; set; }
    }
}
