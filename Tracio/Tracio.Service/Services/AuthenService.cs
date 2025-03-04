using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracio.Data.Entities;
using Tracio.Data.Interfaces;
using Tracio.Data.Models.LoginModel;
using Tracio.Service.Interfaces;

namespace Tracio.Service.Services
{
    public class AuthenService : IAuthenService
    {
        private readonly IAuthenRepository _repo;
        public AuthenService(IAuthenRepository repo)
        {
            _repo = repo;
        }
        

        public bool IsTokenBlacklisted(string token)
        {
            throw new NotImplementedException();
        }

        public Task<string> Login(LoginModel loingModel)
        {
            return _repo.Login(loingModel);
        }

        public Task<User> Register(User newUser)
        {
            return _repo.Register(newUser);
        }
    }
}
