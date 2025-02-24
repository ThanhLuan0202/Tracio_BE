using System;
using System.Collections.Generic;

namespace Tracio.Data.Models;

public partial class BlogCategory
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public string? Description { get; set; }
}
