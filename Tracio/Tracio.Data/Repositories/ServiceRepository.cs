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
    public class ServiceRepository : Repository<Service> ,IServiceRepository
    {
        private readonly TracioDbContext _dbContext;
        public ServiceRepository(TracioDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<Service> CreateService(Service service)
        {
            throw new NotImplementedException();
        }

        public Task<Service> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Service> FindServiceById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Service>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Service> UpdateService(int id, Service service)
        {
            throw new NotImplementedException();
        }
    }
}
