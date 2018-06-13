using GodelTech.AreaMonitor.Dal.Context;
using GodelTech.AreaMonitor.Dal.Interfaces;
using GodelTech.AreaMonitor.Dal.Models;

namespace GodelTech.AreaMonitor.Dal.Repositories
{
    public class WebPageRepository : BaseRepository<WebPage>, IWebPageRepository
    {
        public WebPageRepository(AreaMonitorContext context)
            : base(context)
        {
        }
    }
}
