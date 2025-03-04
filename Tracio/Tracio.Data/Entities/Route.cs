using System;
using System.Collections.Generic;

namespace Tracio.Data.Entities;

public partial class Route
{
    public int RouteId { get; set; }

    public int? CreatorId { get; set; }

    public string? StartLocation { get; set; }

    public string? EndLocation { get; set; }

    public double? Distance { get; set; }

    public double? EstimatedTime { get; set; }

    public string? RouteDescription { get; set; }

    public bool? SharedWithPublic { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? RoutePath { get; set; }

    public string? SegmentPolyline { get; set; }

    public string? StreetList { get; set; }

    public string? Status { get; set; }

    public virtual User? Creator { get; set; }

    public virtual ICollection<GroupRoute> GroupRoutes { get; set; } = new List<GroupRoute>();

    public virtual ICollection<RouteCheckpoint> RouteCheckpoints { get; set; } = new List<RouteCheckpoint>();

    public virtual ICollection<RouteReference> RouteReferences { get; set; } = new List<RouteReference>();
}
