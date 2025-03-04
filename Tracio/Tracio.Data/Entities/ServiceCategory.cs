using System;
using System.Collections.Generic;

namespace Tracio.Data.Entities;

public partial class ServiceCategory
{
    public int CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public string? Description { get; set; }

    public string? Status { get; set; }

    public virtual ICollection<Service> Services { get; set; } = new List<Service>();
}
