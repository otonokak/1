using System.Collections.Generic;
using System.Threading.Tasks;
using GodelTech.AreaMonitor.Bll.Dto;
using GodelTech.AreaMonitor.Bll.Infrastructure;

namespace GodelTech.AreaMonitor.Bll.Interfaces
{
    public interface IWebPageService
    {
        Task<OperationDetails> CreateWebPageAsync(WebPageDto webPageDto);

        Task<WebPageDto> GetWebPageByIdAsync(int id);

        Task<IEnumerable<WebPageDto>> GetAllWebPages();

        Task<OperationDetails> UpdateWebPageAsync(WebPageDto webPageDto);
    }
}
