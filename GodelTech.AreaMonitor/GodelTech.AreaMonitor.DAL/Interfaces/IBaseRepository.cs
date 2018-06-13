using System.Threading.Tasks;
using GodelTech.AreaMonitor.Dal.Models;

namespace GodelTech.AreaMonitor.Dal.Interfaces
{
    public interface IBaseRepository<T>
        where T : BaseEntity
    {
        Task CreateAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);

        Task<T> GetByIdAsync(int id);
    }
}