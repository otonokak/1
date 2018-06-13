using GodelTech.AreaMonitor.DAL.Context;
using GodelTech.AreaMonitor.DAL.Interfaces;
using GodelTech.AreaMonitor.DAL.Models;

namespace GodelTech.AreaMonitor.DAL.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(AreaMonitorContext context)
            : base(context)
        {
        }
    }
}
