namespace GodelTech.AreaMonitor.Dal.Models
{
    public class UserWebPage : BaseEntity
    {
        public string Name { get; set; }

        public string XPath { get; set; }

        public virtual User User { get; set; }

        public int UserId { get; set; }

        public virtual WebPage WebPage { get; set; }

        public int WebPageId { get; set; }
    }
}
