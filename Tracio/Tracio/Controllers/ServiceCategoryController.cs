using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Tracio.Data;
using Tracio.Data.Entities;
using Tracio.Service.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tracio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceCategoryController : ControllerBase
    {
        public readonly IServiceCategoryService _service;
        public readonly IMapper _mapper;
        public readonly IUnitOfWork _unitOfWork;


        public ServiceCategoryController(IServiceCategoryService service, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _service = service;
            _mapper = mapper;
            _unitOfWork = unitOfWork;

        }
        // GET: api/<ServiceCategoryController>
        [HttpGet]
        public async Task< ActionResult<IEnumerable<ServiceCategory>>> GetAll()
        {
            var query = await _service.GetAllService();
            return Ok( _mapper.Map<ServiceCategory>(query));
        }

        // GET api/<ServiceCategoryController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceCategory>> GetById(int id)
        {
            var serviceCategory = await _service.FindServiceCategoryById(id);
            return Ok(_mapper.Map<ServiceCategory>( serviceCategory));
        }

        // POST api/<ServiceCategoryController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ServiceCategoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ServiceCategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
