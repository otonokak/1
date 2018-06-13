using System.Threading.Tasks;

namespace GodelTech.AreaMonitor.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        Task SaveAsync();
    }
}
