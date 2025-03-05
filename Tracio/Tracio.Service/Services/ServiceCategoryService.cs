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
    public class ServiceCategoryService : IServiceCategoryService
    {
        private readonly IServiceCategoryRepository _repo;

        public ServiceCategoryService(IServiceCategoryRepository repo)
        {
            _repo = repo;
        }
        public Task<ServiceCategory> CreateServiceCategory(ServiceCategory newServiceCategory)
        {
            return _repo.CreateServiceCategory(newServiceCategory);
        }

        public Task<ServiceCategory> DeleteServiceCategory(int ServiceCategoryID)
        {
            return _repo.DeleteServiceCategory(ServiceCategoryID);
        }

        public Task<ServiceCategory> FindServiceCategoryById(int ServiceCategoryID)
        {
            return _repo.FindServiceCategoryById(ServiceCategoryID);
        }

        public Task<IEnumerable<ServiceCategory>> GetAllService()
        {
            return _repo.GetAllService();
        }

        public Task<ServiceCategory> UpdateServiceCategory(int id, ServiceCategory ServiceCategoryUpdate)
        {
            return _repo.UpdateServiceCategory(id,  ServiceCategoryUpdate);
        }
    }
}
