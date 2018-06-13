using System;
using System.Threading.Tasks;
using Autofac;
using GodelTech.AreaMonitor.DAL.Context;
using GodelTech.AreaMonitor.DAL.Interfaces;

namespace GodelTech.AreaMonitor.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AreaMonitorContext context;
        private readonly ILifetimeScope lifetimeScope;

        public UnitOfWork(AreaMonitorContext context, ILifetimeScope lifetimeScope)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
            this.lifetimeScope = lifetimeScope ?? throw new ArgumentNullException(nameof(lifetimeScope));
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }

        private T GetRepository<T>() where T 
            : class
        {
            T repository = lifetimeScope.Resolve<T>();
            return repository;
        }

        private bool disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed && disposing)
            {
                context.Dispose();
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
