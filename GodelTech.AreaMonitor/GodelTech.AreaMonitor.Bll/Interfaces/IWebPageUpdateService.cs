using System.Collections.Generic;
using System.Threading.Tasks;
using GodelTech.AreaMonitor.Bll.Dto;
using GodelTech.AreaMonitor.Bll.Infrastructure;

namespace GodelTech.AreaMonitor.Bll.Interfaces
{
    public interface IWebPageUpdateService
    {
        Task<OperationDetails> CreateWebPageUpdateAsync(WebPageUpdateDto webPageUpdateDto);

        Task<WebPageUpdateDto> GetWebPageUpdateByIdAsync(int id);

        Task<IEnumerable<WebPageUpdateDto>> GetAllWebPageUpdatesAsync();

        Task<OperationDetails> UpdateWebPageUpdateAsync(WebPageUpdateDto webPageUpdateDto);

        Task<OperationDetails> DeleteWebPageUpdateAsync(int id);
    }
}
