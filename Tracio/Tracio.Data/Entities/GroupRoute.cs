using System;
using System.Collections.Generic;

namespace Tracio.Data.Entities;

public partial class GroupRoute
{
    public int GroupRouteId { get; set; }

    public int? GroupId { get; set; }

    public int? RouteId { get; set; }

    public string? Content { get; set; }

    public DateTime? SharedTime { get; set; }

    public virtual Group? Group { get; set; }

    public virtual Route? Route { get; set; }
}
