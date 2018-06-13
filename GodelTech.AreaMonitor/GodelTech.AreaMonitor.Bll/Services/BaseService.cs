using System;
using GodelTech.AreaMonitor.Dal.Interfaces;

namespace GodelTech.AreaMonitor.Bll.Services
{
    public abstract class BaseService
    {
        protected readonly IUnitOfWork UnitOfWork;

        protected BaseService(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork ?? throw new ArgumentException(nameof(unitOfWork));
        }
    }
}
