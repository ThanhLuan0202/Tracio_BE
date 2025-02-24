﻿using System;
using System.Collections.Generic;

namespace Tracio.Data.Models;

public partial class Role
{
    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public string? Permissions { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
