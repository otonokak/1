using GodelTech.AreaMonitor.Dal.Context;
using GodelTech.AreaMonitor.Dal.Interfaces;
using GodelTech.AreaMonitor.Dal.Models;

namespace GodelTech.AreaMonitor.Dal.Repositories
{
    public class UserWebPageRepository : BaseRepository<UserWebPage>, IUserWebPageRepository
    {
        public UserWebPageRepository(AreaMonitorContext context)
            : base(context)
        {
        }
    }
}