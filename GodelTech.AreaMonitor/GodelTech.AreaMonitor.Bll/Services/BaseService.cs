using System;
using GodelTech.AreaMonitor.Dal.Interfaces;

namespace GodelTech.AreaMonitor.Bll.Services
{
    public abstract class BaseService
    {
        protected readonly IAreaMonitorUnitOfWork UnitOfWork;

        protected BaseService(IAreaMonitorUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork ?? throw new ArgumentException(nameof(unitOfWork));
        }
    }
}
