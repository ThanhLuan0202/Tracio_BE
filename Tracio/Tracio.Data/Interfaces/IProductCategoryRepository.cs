using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracio.Data.Models;
using Tracio.Data.Models.ProductCategoryModel;

namespace Tracio.Data.Interfaces
{
    public interface IProductCategoryRepository
    {
        Task<IEnumerable<ProductsCategory>> GetAllCategory();
        Task<ProductsCategory> CreateProductCategory(ProductsCategory newProductCategory);
        Task<ProductsCategory> UpdateProductCategory(int id, ProductsCategory productCategoryUpdate);
        Task<ProductsCategory> DeleteProductCategory(int productCategoryID);
    }
}
