using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracio.Data.Models.ProductCategoryModel
{
    public class ViewProductCategoryModel
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public string Status { get; set; }
        public string? Description { get; set; }

    }
}
