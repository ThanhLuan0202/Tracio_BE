using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Tracio.Data.Entities;
using Tracio.Data.Models.ProductModel;
using Tracio.Service.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tracio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;
        private readonly IMapper _mapper;

        public ProductController(IProductService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        // GET: api/<ProductController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAll()
        {
            return Ok(await _service.GetAllProduct());
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetById(int id)
        {
            return Ok(await _service.FindProductById(id));
        }

        // POST api/<ProductController>
        [HttpPost]
        public async Task<ActionResult<Product>> Add([FromForm] CreateProductModel createProductModel)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var result = await _service.CreateProduct(createProductModel);
                return Ok(_mapper.Map<ViewProductModel>(result));
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new { message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message });
            }
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Product>> Update(int id, [FromForm] UpdateProductModel updateProductModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var productUpdate = await _service.UpdateProduct(id, updateProductModel);

            return Ok(_mapper.Map<ViewProductModel>(productUpdate));
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
