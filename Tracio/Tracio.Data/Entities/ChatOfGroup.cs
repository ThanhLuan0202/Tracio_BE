﻿using System;
using System.Collections.Generic;

namespace Tracio.Data.Models;

public partial class ChatOfGroup
{
    public int GroupChatId { get; set; }

    public int? GroupId { get; set; }

    public int? UserId { get; set; }

    public string? Content { get; set; }

    public DateTime? CreatedTime { get; set; }

    public virtual Group? Group { get; set; }

    public virtual User? User { get; set; }
}
