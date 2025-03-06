using Firebase.Storage;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracio.Data.Data;
using Tracio.Data.Entities;
using Tracio.Data.Interfaces;
using Tracio.Data.Models.ProductModel;

namespace Tracio.Data.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly TracioDbContext _dbContext;
        private readonly IConfiguration _configuration;


        public ProductRepository(TracioDbContext dbContext, IConfiguration configuration) : base(dbContext)
        {
            _dbContext = dbContext;
            _configuration = configuration;
        }
        public async Task<Product> CreateProduct(CreateProductModel Product)
        {
            if (Product == null)
            {
                throw new ArgumentNullException(nameof(Product));

            }
            var newProduct = new Product
            {
                ProductName = Product.ProductName,
                CategoryId = Product.CategoryId,
                CreatedTime = DateTime.Now,
                Description = Product.Description,
                StockQuantity = Product.StockQuantity,
                Condition = Product.Condition,
                Status = Product.Status

            };
            if (Product.Image != null)
            {
                var imageUrl = await UploadFileAsyncc(Product.Image);
                newProduct.Image = imageUrl;
            }
            await Entities.AddAsync(newProduct);
            await _dbContext.SaveChangesAsync();
            return newProduct;


        }

        public async Task<Product> DeleteProduct(int ProductID)
        {
            var existProduct = Entities.FirstOrDefault(x => x.ProductId.Equals(ProductID) && x.Status == "Active");
            if (existProduct == null)
            {
                throw new Exception($"Product {ProductID} is not existed !!");
            }
            existProduct.Status = "Inactive";
            await _dbContext.SaveChangesAsync();
            return existProduct;
        }

        public async Task<Product> FindProductById(int ProductID)
        {
            var existProduct = await Entities.FirstOrDefaultAsync(x => x.ProductId.Equals(ProductID) && x.Status.ToLower().Equals("Active"));
            if (existProduct == null)
            {
                throw new Exception($"Product  {nameof(ProductID)} not found");
            }

            return existProduct;
        }

        public async Task<IEnumerable<Product>> GetAllProduct()
        {
            var query = Entities.Where(x => x.Status.ToLower().Equals("Active"));
            return await query.ToListAsync();
        }
        public async Task<Product> UpdateProduct(int id, UpdateProductModel product)
        {
            var existProduct = await FindProductById(id);
            if (existProduct == null)
            {
                throw new Exception($"Product {id} is not existed !!");
            }
            if (product.Image != null)
            {
                var imageUrl = await UploadFileAsyncc(product.Image);
                existProduct.Image = imageUrl;
            }
            existProduct.ProductName = product.ProductName;
            existProduct.Description = product.Description;
            existProduct.StockQuantity = product.StockQuantity;
            existProduct.CategoryId = product.CategoryId;
            existProduct.Condition = product.Condition;
            existProduct.CreatedTime = product.CreatedTime;

            _dbContext.SaveChanges();

            return existProduct;

        }

        public async Task<string> UploadFileAsyncc(IFormFile file)
        {
            if (file.Length > 0)
            {
                var stream = file.OpenReadStream();
                var bucket = _configuration["FireBase:Bucket"];

                var task = new FirebaseStorage(bucket)
                    .Child("Image_Course")
                    .Child(file.FileName)
                    .PutAsync(stream);

                var downloadUrl = await task;
                return downloadUrl;
            }
            return null;
        }
    }
}
