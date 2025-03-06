using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracio.Data.Models.ProductModel
{
    public class CreateProductModel
    {
        public string? ProductName { get; set; }

        public string? Description { get; set; }

        public int? StockQuantity { get; set; }

        public int? CategoryId { get; set; }

        public string? Condition { get; set; }

        public DateTime? CreatedTime = DateTime.UtcNow.AddHours(7);

        public IFormFile? Image { get; set; }


        public string? Status = "Active";
    }
}
