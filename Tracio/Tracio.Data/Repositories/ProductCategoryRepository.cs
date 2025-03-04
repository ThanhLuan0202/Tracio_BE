using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracio.Data.Data;
using Tracio.Data.Entities;
using Tracio.Data.Interfaces;
using Tracio.Data.Models;
using Tracio.Data.Models.ProductCategoryModel;

namespace Tracio.Data.Repositories
{
    public class ProductCategoryRepository : Repository<ProductsCategory>,IProductCategoryRepository
    {
        private readonly TracioDbContext _dbContext;
        private readonly IUnitOfWork _unitOfWork;

        public ProductCategoryRepository(TracioDbContext dbContext, IUnitOfWork unitOfWork) : base(dbContext)
        {
            _dbContext = dbContext;
            _unitOfWork = unitOfWork;
        }

        public async Task<ProductsCategory> CreateProductCategory(ProductsCategory newProductCategory)
        {
            if (newProductCategory == null)
            {
                throw new ArgumentNullException(nameof(newProductCategory));
            }

            var existProductCategory = await Entities.FirstOrDefaultAsync(x => x.CategoryName.ToLower().Equals(newProductCategory.CategoryName));
            if (existProductCategory != null)
            {
                throw new Exception($"Product Category {newProductCategory.CategoryName} is exist!");
            }

            await Entities.AddAsync(newProductCategory);
            await _dbContext.SaveChangesAsync();
            return newProductCategory;
            
        }

        public async Task<ProductsCategory> DeleteProductCategory(int productCategoryID)
        {
            var existProductCategory = await Entities.FirstOrDefaultAsync(x => x.CategoryId.Equals(productCategoryID));
            if (existProductCategory == null)
            {
                throw new Exception($"Product Category {nameof(ProductsCategory)} not found");
            }
             existProductCategory.Status = "Inactive";
            await _dbContext.SaveChangesAsync();
            return existProductCategory;


        }

        public async Task<ProductsCategory> FindProductCategoryById(int productCategoryID)
        {
            var existProductCategory = await Entities.FirstOrDefaultAsync(x => x.CategoryId.Equals(productCategoryID) && x.Status.ToLower().Equals("Active"));
            if (existProductCategory == null)
            {
                throw new Exception($"Product Category {nameof(ProductsCategory)} not found");
            }

            return existProductCategory;
        }

        public async Task<IEnumerable<ProductsCategory>> GetAllCategory()
        {
            var query = Entities.Where(x => x.Status.ToLower().Equals("Active"));
            return await query.ToListAsync();
        }

        public async Task<ProductsCategory> UpdateProductCategory(int id, ProductsCategory productCategoryUpdate)
        {
            if (productCategoryUpdate == null)
            {
                throw new ArgumentNullException(nameof(productCategoryUpdate));
            }
            var existProductCategory = await Entities.FirstOrDefaultAsync(x => x.CategoryId.Equals(id));

            if (existProductCategory == null)
            {
                throw new Exception($"Product Category id: {id} not exist");
            }

            if (productCategoryUpdate.CategoryName.ToLower().Equals(existProductCategory.CategoryName))
            {
                throw new Exception($"Product Category name {productCategoryUpdate.CategoryName} is exist!");
            }

            existProductCategory.CategoryName = productCategoryUpdate.CategoryName;
            existProductCategory.Description = productCategoryUpdate.Description;

            await _dbContext.SaveChangesAsync();

            return existProductCategory;

        }
    }
}
