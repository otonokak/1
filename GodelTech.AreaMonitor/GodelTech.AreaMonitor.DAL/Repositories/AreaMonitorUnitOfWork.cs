﻿using System;
using System.Threading.Tasks;
using Autofac;
using GodelTech.AreaMonitor.Dal.Context;
using GodelTech.AreaMonitor.Dal.Interfaces;

namespace GodelTech.AreaMonitor.Dal.Repositories
{
    public class AreaMonitorUnitOfWork : IAreaMonitorUnitOfWork
    {
        private readonly AreaMonitorContext context;
        private readonly ILifetimeScope lifetimeScope;

        public AreaMonitorUnitOfWork(AreaMonitorContext context, ILifetimeScope lifetimeScope)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
            this.lifetimeScope = lifetimeScope ?? throw new ArgumentNullException(nameof(lifetimeScope));
        }

        public IUserRepository UserRepository => GetRepository<IUserRepository>();

        public IUserWebPageRepository UserWebPageRepository => GetRepository<IUserWebPageRepository>();

        public IWebPageRepository WebPageRepository => GetRepository<IWebPageRepository>();

        public IWebPageUpdateRepository WebPageUpdateRepository => GetRepository<IWebPageUpdateRepository>();

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
