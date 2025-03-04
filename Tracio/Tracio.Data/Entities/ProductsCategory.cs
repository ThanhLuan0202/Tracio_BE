using System;
using System.Collections.Generic;

namespace Tracio.Data.Entities;

public partial class ProductsCategory
{
    public int CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public string? Description { get; set; }

    public string? Status { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
