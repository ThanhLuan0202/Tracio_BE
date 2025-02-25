using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Tracio.Data.Models;
using Tracio.Data.Models.ProductCategoryModel;
using Tracio.Service.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tracio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsCategoryController : ControllerBase
    {
        public readonly IProductCategoryService _service;
        public readonly IMapper _mapper;

        public ProductsCategoryController(IProductCategoryService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        // GET: api/<CategoryController>
        [HttpGet]
        public  async Task<ActionResult<IEnumerable<ProductsCategory>>> GetAllProductCategory()
        {
            var productCategory = await _service.GetAllCategory();

            return Ok(_mapper.Map<List<ViewProductCategoryModel>>(productCategory));

        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CategoryController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
