using System;
using System.Collections.Generic;

namespace Tracio.Data.Entities;

public partial class RouteReference
{
    public int ReferenceId { get; set; }

    public int? BlogId { get; set; }

    public int? RouteId { get; set; }

    public string? Description { get; set; }

    public virtual Blog? Blog { get; set; }

    public virtual Route? Route { get; set; }
}
