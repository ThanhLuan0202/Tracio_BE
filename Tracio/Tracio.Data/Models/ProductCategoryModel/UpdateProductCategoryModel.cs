using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracio.Data.Models.ProductCategoryModel
{
    public class UpdateProductCategoryModel
    {
        public string CategoryName { get; set; } = null!;

        public string? Description { get; set; }
    }
}
