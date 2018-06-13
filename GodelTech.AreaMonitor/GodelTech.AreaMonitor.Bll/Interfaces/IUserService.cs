using System.Threading.Tasks;
using GodelTech.AreaMonitor.Bll.Dto;
using GodelTech.AreaMonitor.Bll.Infrastructure;

namespace GodelTech.AreaMonitor.Bll.Interfaces
{
    public interface IUserService
    {
        Task<OperationDetails> CreateUserAsync(UserDto userDto);

        Task<UserDto> GetUserByIdAsync(string id);

        Task<UserDto> GetUserByEmailAsync(string email);

        Task<OperationDetails> UpdateUserAsync(UserDto userDto);

        Task<OperationDetails> DeleteUserAsync(int id);
    }
}
