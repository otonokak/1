using System.Collections.Generic;
using System.Threading.Tasks;
using GodelTech.AreaMonitor.Bll.Dto;
using GodelTech.AreaMonitor.Bll.Infrastructure;

namespace GodelTech.AreaMonitor.Bll.Interfaces
{
    public interface IUserWebPageService
    {
        Task<OperationDetails> CreateUserWebPageAsync(UserWebPageDto userWebPageDto);

        Task<UserWebPageDto> GetUserWebPageByIdAsync(int id);

        Task<IEnumerable<UserWebPageDto>> GetAllUserWebPages();

        Task<OperationDetails> UpdateUserWebPageAsync(UserWebPageDto userWebPageDto);

        Task<OperationDetails> DeleteUserWebPageAsync(int id);
    }
}
