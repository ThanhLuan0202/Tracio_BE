using System;
using System.Collections.Generic;

namespace Tracio.Data.Entities;

public partial class Group
{
    public int GroupId { get; set; }

    public string? GroupName { get; set; }

    public string? Description { get; set; }

    public int? CreatorId { get; set; }

    public int? MemberCount { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public virtual ICollection<ChatOfGroup> ChatOfGroups { get; set; } = new List<ChatOfGroup>();

    public virtual User? Creator { get; set; }

    public virtual ICollection<GroupMember> GroupMembers { get; set; } = new List<GroupMember>();

    public virtual ICollection<GroupRoute> GroupRoutes { get; set; } = new List<GroupRoute>();
}
