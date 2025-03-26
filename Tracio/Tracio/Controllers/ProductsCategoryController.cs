using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Tracio.Data;
using Tracio.Data.Entities;
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
        public readonly IUnitOfWork _unitOfWork;


        public ProductsCategoryController(IProductCategoryService service, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _service = service;
            _mapper = mapper;
            _unitOfWork = unitOfWork;

        }
        // GET: api/<CategoryController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductsCategory>>> GetAllProductCategory()
        {
            var productCategory = await _service.GetAllCategory();

            return Ok(_mapper.Map<List<ViewProductCategoryModel>>(productCategory));

        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductsCategory>> GetProductCategoryById(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var productCategory = await _service.FindProductCategoryById(id);
            return Ok(_mapper.Map<ViewProductCategoryModel>(productCategory));
        }

        // POST api/<CategoryController>
        [HttpPost("create-category")]
        //[Authorize(Roles = "Staff")]

        public async Task<ActionResult<ProductsCategory>> CreateProductCategory([FromBody] CreateProductCategoryModel createProductCategoryModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //_unitOfWork.BeginTransaction();

            try
            {
                var productCategory = _mapper.Map<ProductsCategory>(createProductCategoryModel);
                productCategory = await _service.CreateProductCategory(productCategory);
                //_unitOfWork.CommitTransaction();
                return Ok(_mapper.Map<ViewProductCategoryModel>(productCategory));
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

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        //[Authorize(Roles = "Staff")]

        public async Task<ActionResult<ProductsCategory>> UpdateProductCategory(int id, [FromBody] UpdateProductCategoryModel updateProductCategoryModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //_unitOfWork.BeginTransaction();

            try
            {
                var productCategoryUpdate = _mapper.Map<ProductsCategory>(updateProductCategoryModel);
                productCategoryUpdate = await _service.UpdateProductCategory(id, productCategoryUpdate);
                //_unitOfWork.CommitTransaction();
                return Ok(_mapper.Map<ViewProductCategoryModel>(productCategoryUpdate));
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

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Staff")]

        public async Task<ActionResult<ProductsCategory>> DeleteProductCategory(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
               var productCategory = await _service.DeleteProductCategory(id);

                return Ok(_mapper.Map<ViewProductCategoryModel>(productCategory));
            }catch(KeyNotFoundException ex)
            {
                return NotFound(new {message = ex.Message});
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new {message = ex.Message});
            }

        }
    }
}
