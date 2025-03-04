using System;
using System.Collections.Generic;

namespace Tracio.Data.Entities;

public partial class RouteCheckpoint
{
    public int PointId { get; set; }

    public int? SegmentId { get; set; }

    public int? PointNumber { get; set; }

    public string? PointName { get; set; }

    public int? SequenceNumber { get; set; }

    public string? Description { get; set; }

    public double? Lng { get; set; }

    public virtual Route? Segment { get; set; }
}
