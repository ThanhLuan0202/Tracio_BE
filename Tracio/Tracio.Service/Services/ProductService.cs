using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracio.Data.Entities;
using Tracio.Data.Interfaces;
using Tracio.Data.Models.ProductModel;
using Tracio.Service.Interfaces;

namespace Tracio.Service.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;
        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }
        public Task<Product> CreateProduct(CreateProductModel newProduct)
        {
            return _repo.CreateProduct(newProduct);
        }

        public Task<Product> DeleteProduct(int ProductID)
        {
           return (_repo.DeleteProduct(ProductID));
        }

        public Task<Product> FindProductById(int ProductID)
        {
            return _repo.FindProductById(ProductID);
        }

        public Task<IEnumerable<Product>> GetAllProduct()
        {
           return _repo.GetAllProduct();
        }

        public Task<Product> UpdateProduct(int id, UpdateProductModel ProductUpdate)
        {
            return _repo.UpdateProduct(id, ProductUpdate);
        }
    }
}
