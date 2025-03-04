using System;
using System.Collections.Generic;

namespace Tracio.Data.Entities;

public partial class Blog
{
    public int BlogId { get; set; }

    public int? AuthorId { get; set; }

    public int? CategoryId { get; set; }

    public string? Title { get; set; }

    public string? Content { get; set; }

    public int? TagId { get; set; }

    public int? LikeCount { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? Status { get; set; }

    public virtual User? Author { get; set; }

    public virtual BlogCategory? Category { get; set; }

    public virtual ICollection<RouteReference> RouteReferences { get; set; } = new List<RouteReference>();

    public virtual BlogTag? Tag { get; set; }
}
