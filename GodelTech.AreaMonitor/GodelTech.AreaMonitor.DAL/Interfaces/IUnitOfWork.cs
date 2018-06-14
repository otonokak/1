using System;
using System.Threading.Tasks;

namespace GodelTech.AreaMonitor.Dal.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; }

        IUserWebPageRepository UserWebPageRepository { get; }

        IWebPageRepository WebPageRepository { get; }

        IWebPageUpdateRepository WebPageUpdateRepository { get; }

        Task SaveAsync();
    }
}