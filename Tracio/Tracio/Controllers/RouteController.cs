using Microsoft.AspNetCore.Mvc;
using Tracio.Data.Entities;
using Tracio.Data.Models.ProductModel;
using Tracio.Service.Interfaces;
using Route = Tracio.Data.Entities.Route;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tracio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RouteController : ControllerBase
    {

        private readonly IRouteService _service;
        public RouteController(IRouteService service)
        {
            _service = service;

        }
        // GET: api/<RouteController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Route>>> GetAll()
        {

            var allRoute = await _service.GetAll();
            return Ok(allRoute);
        }

        // GET api/<RouteController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RouteController>
       /* [HttpPost]
        public async Task<ActionResult<Route>> Add([FromForm] Route route)
        {
            var newRoute
        }
*/
        // PUT api/<RouteController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RouteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
