using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracio.Data.Entities;
using Tracio.Data.Interfaces;
using Tracio.Service.Interfaces;

namespace Tracio.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repo;

        public UserService(IUserRepository repo)
        {
            _repo = repo;
        }
        public Task<User> GetUserByEmail(string email)
        {
            return _repo.GetUserByEmail(email);
        }
    }
}
