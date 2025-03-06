using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracio.Data.Entities;
using Tracio.Data.Models.ProductModel;

namespace Tracio.Data.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProduct();
        Task<Product> CreateProduct(CreateProductModel newProduct);
        Task<Product> UpdateProduct(int id, UpdateProductModel ProductUpdate);
        Task<Product> DeleteProduct(int ProductID);
        Task<Product> FindProductById(int ProductID);

    }
}
