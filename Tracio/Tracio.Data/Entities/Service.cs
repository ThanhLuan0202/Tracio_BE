using System;
using System.Collections.Generic;

namespace Tracio.Data.Models;

public partial class Service
{
    public int ServiceId { get; set; }

    public string ServiceName { get; set; } = null!;

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public double? EstimatedTime { get; set; }

    public double? Rating { get; set; }

    public int? CategoryId { get; set; }

    public virtual ICollection<BookingService> BookingServices { get; set; } = new List<BookingService>();

    public virtual ServiceCategory? Category { get; set; }
}
