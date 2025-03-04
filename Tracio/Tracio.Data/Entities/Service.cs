using System;
using System.Collections.Generic;

namespace Tracio.Data.Entities;

public partial class Service
{
    public int ServiceId { get; set; }

    public string? ServiceName { get; set; }

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public int? Availability { get; set; }

    public double? EstimatedTime { get; set; }

    public double? Rating { get; set; }

    public int? CategoryId { get; set; }

    public string? Status { get; set; }

    public virtual ICollection<BookingService> BookingServices { get; set; } = new List<BookingService>();

    public virtual ServiceCategory? Category { get; set; }
}
