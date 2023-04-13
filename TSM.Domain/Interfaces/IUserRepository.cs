using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSM.Domain.Entities;

namespace TSM.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetById(int id);

        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
    }
}
