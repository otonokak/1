using GodelTech.AreaMonitor.Dal.Context;
using GodelTech.AreaMonitor.Dal.Interfaces;
using GodelTech.AreaMonitor.Dal.Models;

namespace GodelTech.AreaMonitor.Dal.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(AreaMonitorContext context)
            : base(context)
        {
        }
    }
}
