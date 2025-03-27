using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracio.Data.Basic;
using Tracio.Data.Entities;
using Tracio.Data.Interfaces;

namespace Tracio.Data.Repositories
{
    public class RouteRepository : GenericRepository<Route>, IRouteRepository
    {
        public RouteRepository()
        {
            
        }

        public async Task<Route> CreateRouteCategory(Route route)
        {
            var newRoute = await _context.AddAsync(route);
            return route;
        }

        public Task<Route> DeleteRoute(int routeId)
        {
            throw new NotImplementedException();
        }

        public Task<Route> FindRouteById(int routeId)
        {
            throw new NotImplementedException();
        }

    
        public Task<Route> UpdateRoute(int id, Route route)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Route>> GetAll()
        {
            return await _context.Routes
               .Include(x => x.RouteCheckpoints)
               .Include(x => x.GroupRoutes).Where(x => x.Status.Equals("Active")).ToListAsync();
        }
    }
}
