using GodelTech.AreaMonitor.DAL.Context;
using GodelTech.AreaMonitor.DAL.Interfaces;
using GodelTech.AreaMonitor.DAL.Models;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Threading.Tasks;

namespace GodelTech.AreaMonitor.DAL.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : BaseEntity
    {
        protected readonly AreaMonitorContext context;
        protected readonly DbSet<T> entities;

        public BaseRepository(AreaMonitorContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        public async Task CreateAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            entities.Add(entity);
            await GetByIdAsync(entity.Id);
        }

        public async Task DeleteAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            entities.Remove(entity);
            await GetByIdAsync(entity.Id);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await entities.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            entities.AddOrUpdate(entity);
            await GetByIdAsync(entity.Id);
        }
    }
}