using System.Threading.Tasks;

namespace GodelTech.AreaMonitor.Dal.Interfaces
{
    public interface IUnitOfWork
    {
        Task SaveAsync();
    }
}
