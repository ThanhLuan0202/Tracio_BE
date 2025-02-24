using System;
using System.Collections.Generic;

namespace Tracio.Data.Models;

public partial class Blog
{
    public int BlogId { get; set; }

    public int? AuthorId { get; set; }

    public string Title { get; set; } = null!;

    public string? Content { get; set; }

    public int? TagId { get; set; }

    public int? ViewCount { get; set; }

    public int? LikeCount { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public virtual User? Author { get; set; }
}
