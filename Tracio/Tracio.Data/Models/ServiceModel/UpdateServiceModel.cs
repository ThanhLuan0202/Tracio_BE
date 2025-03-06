using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracio.Data.Models.ServiceModel
{
    public class UpdateServiceModel
    {
        public string? ServiceName { get; set; }

        public string? Description { get; set; }

        public decimal? Price { get; set; }

        public int? Availability { get; set; }

        public double? EstimatedTime { get; set; }

        public double? Rating { get; set; }

        public int? CategoryId { get; set; }

        public string? Status = "Active";
    }
}
