using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracio.Data.Entities;

namespace Tracio.Data.Interfaces
{
    public interface IServiceRepository
    {
        Task<IEnumerable<Service>> GetAll();
        Task<Service> CreateService(Service service);
        Task<Service> UpdateService(int id, Service service);
        Task<Service> Delete(int id);
        Task<Service> FindServiceById (int id);




    }
}
