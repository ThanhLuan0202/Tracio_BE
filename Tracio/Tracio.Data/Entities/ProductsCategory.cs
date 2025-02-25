using System;
using System.Collections.Generic;

namespace Tracio.Data.Models;

public partial class ProductsCategory
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;
    public string Status { get; set; }

    public string? Description { get; set; }
}
