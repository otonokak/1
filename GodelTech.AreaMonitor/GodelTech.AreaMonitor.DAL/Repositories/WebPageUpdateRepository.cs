using GodelTech.AreaMonitor.DAL.Context;
using GodelTech.AreaMonitor.DAL.Interfaces;
using GodelTech.AreaMonitor.DAL.Models;

namespace GodelTech.AreaMonitor.DAL.Repositories
{
    public class WebPageUpdateRepository : BaseRepository<WebPageUpdate>, IWebPageUpdateRepository
    {
        public WebPageUpdateRepository(AreaMonitorContext context)
            : base(context)
        {
        }
    }
}
