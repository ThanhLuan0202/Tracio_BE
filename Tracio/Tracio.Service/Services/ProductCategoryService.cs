using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracio.Data.Interfaces;
using Tracio.Data.Models;
using Tracio.Service.Interfaces;

namespace Tracio.Service.Services
{
    public class ProductCategoryService : IProductCategoryService
    {
        public readonly IProductCategoryRepository _repo;


        public ProductCategoryService(IProductCategoryRepository repo)
        {
            _repo = repo;
        }
        public Task<ProductsCategory> CreateProductCategory(ProductsCategory newProductCategory)
        {
           return  _repo.CreateProductCategory(newProductCategory);
        }

        public Task<ProductsCategory> DeleteProductCategory(int productCategoryID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductsCategory>> GetAllCategory()
        {
            return _repo.GetAllCategory();
        }

        public Task<ProductsCategory> UpdateProductCategory( int id, ProductsCategory productCategoryUpdate)
        {
            return _repo.UpdateProductCategory(id, productCategoryUpdate);
        }
    }
}
