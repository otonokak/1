using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GodelTech.AreaMonitor.Bll.Dto;
using GodelTech.AreaMonitor.Bll.Infrastructure;
using GodelTech.AreaMonitor.Bll.Interfaces;

namespace GodelTech.AreaMonitor.Bll.Services
{
    public class WebPageService : BaseService, IWebPageService
    {
        public Task<OperationDetails> CreateWebPageAsync(WebPageDto webPageDto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<WebPageDto>> GetAllWebPagesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<WebPageDto> GetWebPageByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> UpdateWebPageAsync(WebPageDto webPageDto)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> DeleteWebPageAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
