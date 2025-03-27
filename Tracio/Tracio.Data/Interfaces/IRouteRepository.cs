using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracio.Data.Entities;

namespace Tracio.Data.Interfaces
{
    public  interface IRouteRepository
    {

        Task<IEnumerable<Route>> GetAll();
        Task<Route> CreateRouteCategory(Route route);
        Task<Route> UpdateRoute(int id, Route route);
        Task<Route> DeleteRoute(int routeId);
        Task<Route> FindRouteById(int routeId);
    }
}
