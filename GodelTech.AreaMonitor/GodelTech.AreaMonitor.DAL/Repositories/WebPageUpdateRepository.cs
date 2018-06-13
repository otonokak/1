using GodelTech.AreaMonitor.Dal.Context;
using GodelTech.AreaMonitor.Dal.Interfaces;
using GodelTech.AreaMonitor.Dal.Models;

namespace GodelTech.AreaMonitor.Dal.Repositories
{
    public class WebPageUpdateRepository : BaseRepository<WebPageUpdate>, IWebPageUpdateRepository
    {
        public WebPageUpdateRepository(AreaMonitorContext context)
            : base(context)
        {
        }
    }
}
