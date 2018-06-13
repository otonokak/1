namespace GodelTech.AreaMonitor.DAL.Models
{
    public class WebPage : BaseEntity
    {
        public string Url { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}