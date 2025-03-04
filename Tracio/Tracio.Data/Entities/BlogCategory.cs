using System;
using System.Collections.Generic;

namespace Tracio.Data.Entities;

public partial class BlogCategory
{
    public int CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Blog> Blogs { get; set; } = new List<Blog>();
}
