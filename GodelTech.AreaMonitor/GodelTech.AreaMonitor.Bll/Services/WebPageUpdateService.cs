using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GodelTech.AreaMonitor.Bll.Dto;
using GodelTech.AreaMonitor.Bll.Infrastructure;
using GodelTech.AreaMonitor.Bll.Interfaces;
using GodelTech.AreaMonitor.Dal.Interfaces;

namespace GodelTech.AreaMonitor.Bll.Services
{
    public class WebPageUpdateService : BaseService, IWebPageUpdateService
    {
        public WebPageUpdateService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public Task<OperationDetails> CreateWebPageUpdateAsync(WebPageUpdateDto webPageUpdateDto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<WebPageUpdateDto>> GetAllWebPageUpdatesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<WebPageUpdateDto> GetWebPageUpdateByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> UpdateWebPageUpdateAsync(WebPageUpdateDto webPageUpdateDto)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> DeleteWebPageUpdateAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
