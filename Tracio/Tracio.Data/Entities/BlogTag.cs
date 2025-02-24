using System;
using System.Collections.Generic;

namespace Tracio.Data.Models;

public partial class BlogTag
{
    public int TagId { get; set; }

    public string TagName { get; set; } = null!;
}
