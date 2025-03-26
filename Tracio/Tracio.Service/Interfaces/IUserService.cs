using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracio.Data.Entities;

namespace Tracio.Service.Interfaces
{
    public interface IUserService
    {
        Task<User> GetUserByEmail(string email);

    }
}
