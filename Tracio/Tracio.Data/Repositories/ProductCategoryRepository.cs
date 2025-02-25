using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracio.Data.Data;
using Tracio.Data.Interfaces;
using Tracio.Data.Models;
using Tracio.Data.Models.ProductCategoryModel;

namespace Tracio.Data.Repositories
{
    public class ProductCategoryRepository : Repository<ProductsCategory>,IProductCategoryRepository
    {
        private readonly TracioDbContext _dbContext;

        public ProductCategoryRepository(TracioDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<ProductsCategory> CreateProductCategory(ProductsCategory newProductCategory)
        {
            throw new NotImplementedException();
        }

        public Task<ProductsCategory> DeleteProductCategory(int productCategoryID)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductsCategory>> GetAllCategory()
        {
            var query = Entities.Where(x => x.Status.ToLower().Equals("Active"));
            return await query.ToListAsync();
        }

        public Task<ProductsCategory> UpdateProductCategory(ProductsCategory productCategoryUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
