using System;
using System.Collections.Generic;

namespace Tracio.Data.Entities;

public partial class GroupMember
{
    public int MemberShipId { get; set; }

    public int? GroupId { get; set; }

    public int? UserId { get; set; }

    public string? Status { get; set; }

    public DateTime? JoinedTime { get; set; }

    public virtual Group? Group { get; set; }

    public virtual User? User { get; set; }
}
