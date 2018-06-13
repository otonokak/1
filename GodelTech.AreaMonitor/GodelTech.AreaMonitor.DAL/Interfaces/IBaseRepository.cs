using System.Threading.Tasks;
using GodelTech.AreaMonitor.DAL.Models;

namespace GodelTech.AreaMonitor.DAL.Interfaces
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