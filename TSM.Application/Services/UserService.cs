using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSM.Application.Interfaces;
using TSM.Application.ViewModels;
using TSM.Domain.Interfaces;

namespace TSM.Application.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _repository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task<IEnumerable<UserViewModel>> GetUsers()
        {
            throw new NotImplementedException();
        }

        public Task<UserViewModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void AddUser(UserViewModel user)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(UserViewModel user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }
    }
}
