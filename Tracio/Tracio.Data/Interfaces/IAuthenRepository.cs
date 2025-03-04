using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracio.Data.Entities;
using Tracio.Data.Models;
using Tracio.Data.Models.LoginModel;

namespace Tracio.Data.Interfaces
{
    public interface IAuthenRepository
    {
        Task<string> Login(LoginModel model);
        Task<User> Register(User newUser);
        Task<bool> Logout(string userId);

    }
}
