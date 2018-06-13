using System;
using System.Threading.Tasks;
using GodelTech.AreaMonitor.Bll.Dto;
using GodelTech.AreaMonitor.Bll.Infrastructure;
using GodelTech.AreaMonitor.Bll.Interfaces;

namespace GodelTech.AreaMonitor.Bll.Services
{
    public class UserService : BaseService, IUserService
    {
        public Task<OperationDetails> CreateUserAsync(UserDto userDto)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> UpdateUserAsync(UserDto userDto)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> DeleteUserAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> GetUserByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> GetUserByIdAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
