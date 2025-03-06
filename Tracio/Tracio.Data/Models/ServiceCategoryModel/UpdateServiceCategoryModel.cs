using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracio.Data.Models.ServiceCategoryModel
{
    public class UpdateServiceCategoryModel
    {

        public string CategoryName { get; set; }

        public string? Description { get; set; }

        public string? Status = "Active";

    }
}
