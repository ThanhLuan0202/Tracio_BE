﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracio.Data.Models.ServiceCategoryModel
{
    public class CreateServiceCategoryModel
    {

        public string CategoryName { get; set; } = null!;

        public string? Description { get; set; }
        public string? Status = "Active";

    }
}
