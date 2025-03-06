using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Tracio.Data;
using Tracio.Data.Entities;
using Tracio.Data.Models.ServiceCategoryModel;
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
            return Ok( _mapper.Map<List<ViewServiceCategoryModel>>(query));
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
        [Authorize(Roles = "Staff")]
        public async Task<ActionResult<ServiceCategory>> CreateServiceCategory([FromBody] CreateServiceCategoryModel createServiceCategoryModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var newServiceCategory =  _mapper.Map<ServiceCategory>(createServiceCategoryModel);

            newServiceCategory = await _service.CreateServiceCategory(newServiceCategory);

            return Ok(_mapper.Map<ViewServiceCategoryModel>(newServiceCategory));


        }

        // PUT api/<ServiceCategoryController>/5
        [HttpPut("{id}")]
        [Authorize(Roles = "Staff")]

        public async Task<ActionResult<ServiceCategory>> UpdateServiceCategory(int id, [FromBody] UpdateServiceCategoryModel updateServiceCategoryModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var updateServiceCategory = _mapper.Map<ServiceCategory>(updateServiceCategoryModel);
            updateServiceCategory = await _service.UpdateServiceCategory(id,updateServiceCategory);

            return Ok(_mapper.Map<ViewServiceCategoryModel>(updateServiceCategory));
        }

        // DELETE api/<ServiceCategoryController>/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Staff")]

        public async Task<ActionResult<ServiceCategory>> Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var delete = await _service.DeleteServiceCategory(id);
             
            return Ok(_mapper.Map<ServiceCategory>(delete));
        }
    }
}
