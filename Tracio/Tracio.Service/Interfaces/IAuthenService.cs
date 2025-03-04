using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Tracio.Data.Entities;
using Tracio.Data.Models.LoginModel;

namespace Tracio.Service.Interfaces
{
    public interface IAuthenService
    {
        Task<string> Login(LoginModel loingModel);
        Task<User> Register(User newUser);
        //Task<bool> Logout(HttpContext httpContext);
        bool IsTokenBlacklisted(string token);
    }
}
