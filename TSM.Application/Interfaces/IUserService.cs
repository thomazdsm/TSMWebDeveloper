using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSM.Application.ViewModels;

namespace TSM.Application.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserViewModel>> GetUsers();
        Task<UserViewModel> GetById(int id);

        void AddUser(UserViewModel user);
        void UpdateUser(UserViewModel user);
        void DeleteUser(int id);
    }
}
