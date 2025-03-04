using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracio.Data.Data;
using Tracio.Data.Entities;
using Tracio.Data.Interfaces;
using Tracio.Data.Models;

namespace Tracio.Data.Repositories
{
    public class ServiceCategoryRepository : Repository<ServiceCategory> ,IServiceCategoryRepository
    {
        private readonly TracioDbContext _dbContext;

        public ServiceCategoryRepository(TracioDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;  
        }
        public Task<ServiceCategory> CreateServiceCategory(ServiceCategory newServiceCategory)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceCategory> DeleteServiceCategory(int ServiceCategoryID)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceCategory> FindServiceCategoryById(int ServiceCategoryID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ServiceCategory>> GetAllService()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceCategory> UpdateServiceCategory(int id, ServiceCategory ServiceCategoryUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
