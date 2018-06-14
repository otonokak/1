using System;
using GodelTech.AreaMonitor.Dal.Interfaces;

namespace GodelTech.AreaMonitor.Bll.Services
{
    public abstract class BaseService
    {
        protected IAreaMonitorUnitOfWork unitOfWork { get; }

        protected BaseService(IAreaMonitorUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork ?? throw new ArgumentException(nameof(unitOfWork));
        }
    }
}
