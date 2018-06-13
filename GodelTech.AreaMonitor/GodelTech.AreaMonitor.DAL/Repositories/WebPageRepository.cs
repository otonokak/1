using GodelTech.AreaMonitor.DAL.Context;
using GodelTech.AreaMonitor.DAL.Interfaces;
using GodelTech.AreaMonitor.DAL.Models;

namespace GodelTech.AreaMonitor.DAL.Repositories
{
    public class WebPageRepository : BaseRepository<WebPage>, IWebPageRepository
    {
        public WebPageRepository(AreaMonitorContext context)
            : base(context)
        {
        }
    }
}
