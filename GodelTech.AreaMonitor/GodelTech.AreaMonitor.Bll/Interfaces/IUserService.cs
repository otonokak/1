using System.Security.Claims;
using System.Threading.Tasks;
using GodelTech.AreaMonitor.Bll.Dto;
using GodelTech.AreaMonitor.Bll.Infrastructure;

namespace GodelTech.AreaMonitor.Bll.Interfaces
{
    public interface IUserService
    {
        Task<OperationDetails> Create(UserDto userDto);

        Task<ClaimsIdentity> Authenticate(UserDto userDto);

        Task<UserDto> FindByEmail(string email);

        Task<OperationDetails> UpdateUser(UserDto userDto);

        Task<OperationDetails> DeleteUser(UserDto userDto);
    }
}
