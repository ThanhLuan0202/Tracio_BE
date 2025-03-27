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
    public class RouteService : IRouteService
    {

        private readonly IRouteRepository _repo;
        public RouteService(IRouteRepository repo)
        {
            _repo = repo;
        }
        public Task<Route> CreateRouteCategory(Route route)
        {
            throw new NotImplementedException();
        }

        public Task<Route> DeleteRoute(int routeId)
        {
            throw new NotImplementedException();
        }

        public Task<Route> FindRouteById(int routeId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Route>> GetAll()
        {
            return _repo.GetAll();
        }

        public Task<Route> UpdateRoute(int id, Route route)
        {
            throw new NotImplementedException();
        }
    }
}
