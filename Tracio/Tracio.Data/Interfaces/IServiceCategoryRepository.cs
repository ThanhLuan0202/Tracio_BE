using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracio.Data.Entities;
using Tracio.Data.Models;

namespace Tracio.Data.Interfaces
{
    public interface IServiceCategoryRepository
    {
        Task<IEnumerable<ServiceCategory>> GetAllService();
        Task<ServiceCategory> CreateServiceCategory(ServiceCategory newServiceCategory);
        Task<ServiceCategory> UpdateServiceCategory(int id, ServiceCategory ServiceCategoryUpdate);
        Task<ServiceCategory> DeleteServiceCategory(int ServiceCategoryID);
        Task<ServiceCategory> FindServiceCategoryById(int ServiceCategoryID);

    }
}
