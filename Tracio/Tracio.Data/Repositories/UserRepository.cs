using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracio.Data.Data;
using Tracio.Data.Entities;
using Tracio.Data.Interfaces;

namespace Tracio.Data.Repositories
{
    public class UserRepository : Repository<User> ,IUserRepository
    {
        private readonly TracioDbContext _dbContext;
        public UserRepository(TracioDbContext dbContext) : base(dbContext) 
        {
            _dbContext = dbContext;
        }
        public async Task<User> GetUserByEmail(string email)
        {
            var existUser =  Entities.FirstOrDefault(x => x.Email.ToLower().Equals(email) && x.Status.Equals("Active"));

            if (existUser == null)
            {
                throw new Exception("User not exist !");
            }

            return existUser;
        }
    }
}
