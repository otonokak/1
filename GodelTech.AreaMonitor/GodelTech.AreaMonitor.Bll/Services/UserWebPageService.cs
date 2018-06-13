using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GodelTech.AreaMonitor.Bll.Dto;
using GodelTech.AreaMonitor.Bll.Infrastructure;
using GodelTech.AreaMonitor.Bll.Interfaces;
using GodelTech.AreaMonitor.DAL.Interfaces;

namespace GodelTech.AreaMonitor.Bll.Services
{
    public class UserWebPageService : BaseService, IUserWebPageService
    {
        public UserWebPageService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public Task<OperationDetails> CreateUserWebPageAsync(UserWebPageDto userWebPageDto)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> DeleteUserWebPageAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserWebPageDto>> GetAllUserWebPagesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserWebPageDto> GetUserWebPageByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationDetails> UpdateUserWebPageAsync(UserWebPageDto userWebPageDto)
        {
            throw new NotImplementedException();
        }
    }
}
