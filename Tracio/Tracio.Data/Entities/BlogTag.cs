using System;
using System.Collections.Generic;

namespace Tracio.Data.Entities;

public partial class BlogTag
{
    public int TagId { get; set; }

    public string? TagName { get; set; }

    public virtual ICollection<Blog> Blogs { get; set; } = new List<Blog>();
}
