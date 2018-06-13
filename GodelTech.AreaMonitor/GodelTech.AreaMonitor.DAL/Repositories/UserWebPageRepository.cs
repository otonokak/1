using GodelTech.AreaMonitor.DAL.Context;
using GodelTech.AreaMonitor.DAL.Interfaces;
using GodelTech.AreaMonitor.DAL.Models;

namespace GodelTech.AreaMonitor.DAL.Repositories
{
    public class UserWebPageRepository : BaseRepository<UserWebPage>, IUserWebPageRepository
    {
        public UserWebPageRepository(AreaMonitorContext context)
            : base(context)
        {
        }
    }
}