using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracio.Data.Entities;
using Tracio.Data.Models;

namespace Tracio.Service.Interfaces
{
    public interface IProductCategoryService
    {
        Task<IEnumerable<ProductsCategory>> GetAllCategory();
        Task<ProductsCategory> CreateProductCategory(ProductsCategory newProductCategory);
        Task<ProductsCategory> UpdateProductCategory(int id, ProductsCategory productCategoryUpdate);
        Task<ProductsCategory> DeleteProductCategory(int productCategoryID);
        Task<ProductsCategory> FindProductCategoryById(int productCategoryID);

    }
}
