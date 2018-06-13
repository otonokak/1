using System;
using System.Security.Claims;
using System.Threading.Tasks;
using GodelTech.AreaMonitor.Bll.Dto;
using GodelTech.AreaMonitor.Bll.Infrastructure;
using GodelTech.AreaMonitor.Bll.Interfaces;

namespace GodelTech.AreaMonitor.Bll.Services
{
    public class UserService : BaseService, IUserService
    {
        public Task<ClaimsIdentity> Authenticate(UserDto userDto)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> Create(UserDto userDto)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> DeleteUser(UserDto userDto)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> FindByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> UpdateUser(UserDto userDto)
        {
            throw new NotImplementedException();
        }
    }
}
