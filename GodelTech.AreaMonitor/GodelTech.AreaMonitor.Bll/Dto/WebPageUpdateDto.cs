﻿using System;
using GodelTech.AreaMonitor.Bll.Enum;

namespace GodelTech.AreaMonitor.Bll.Dto
{
    public class WebPageUpdateDto
    {
        public byte[] PageContent { get; set; }

        public DateTime ScheduledDate { get; set; }

        public DateTime ProcessingDate { get; set; }

        public int UserWebPageId { get; set; }

        public WebPageUpdateStatus Status { get; set; }
    }
}
