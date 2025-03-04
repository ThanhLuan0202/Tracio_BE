using System;
using System.Collections.Generic;

namespace Tracio.Data.Entities;

public partial class Review
{
    public int ReviewId { get; set; }

    public int? UserId { get; set; }

    public int? TargetId { get; set; }

    public string? TargetType { get; set; }

    public int? Rating { get; set; }

    public string? Content { get; set; }

    public DateTime? CreatedTime { get; set; }

    public virtual User? User { get; set; }
}
