using Microsoft.EntityFrameworkCore;
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
        public async Task<ServiceCategory> CreateServiceCategory(ServiceCategory newServiceCategory)
        {
            var checkServiceCategory = await Entities.FirstOrDefaultAsync(x => x.CategoryName.ToLower().Equals(newServiceCategory.CategoryName));

            if (checkServiceCategory != null)
            {
                throw new Exception($"Service Category name: {newServiceCategory.CategoryName} is exist !");
            }
            await Entities.AddAsync(newServiceCategory);
            await _dbContext.SaveChangesAsync();
            return newServiceCategory;
        }

        public async Task<ServiceCategory> DeleteServiceCategory(int ServiceCategoryID)
        {
            var existServiceCategory = await Entities.FirstOrDefaultAsync(x => x.CategoryId.Equals(ServiceCategoryID) && x.Status.Equals("Active"));

            if (existServiceCategory == null)
            {
                throw new Exception($"Service category not exist!");
            }

            existServiceCategory.Status = "Inactive";
            await _dbContext.SaveChangesAsync();
            return existServiceCategory;
        }

        public async Task<ServiceCategory> FindServiceCategoryById(int ServiceCategoryID)
        {
            var find = await Entities.FirstOrDefaultAsync(x => x.CategoryId.Equals(ServiceCategoryID) && x.Status == "Active");
            if (find == null)
            {
                throw new Exception($"Service Category not exist!");
            }


            return find;
        }

        public async Task<IEnumerable<ServiceCategory>> GetAllService()
        {
            var query =  Entities.Where(x => x.Status.Equals("Active"));

            return await query.ToListAsync();
        }

        public async Task<ServiceCategory> UpdateServiceCategory(int id, ServiceCategory ServiceCategoryUpdate)
        {
            var checkServiceCategory = await Entities.FirstOrDefaultAsync(x => x.CategoryId.Equals(id));
            if (checkServiceCategory == null)
            {
                throw new Exception($"Service Category is not exits");
            }
            checkServiceCategory.CategoryName = ServiceCategoryUpdate.CategoryName;
            checkServiceCategory.Description = ServiceCategoryUpdate.Description;

            await _dbContext.SaveChangesAsync();
            return checkServiceCategory;

        }
    }
}
