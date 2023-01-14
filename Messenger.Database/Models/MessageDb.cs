﻿using System;
using System.Collections.Generic;

namespace Messenger.Database.Models;

public partial class MessageDb
{
    public long Id { get; set; }

    public DateTime DateOfDispatch { get; set; }

    public bool IsEdited { get; set; }

    public bool IsDeleted { get; set; }

    public int SenderId { get; set; }

    public int ChatId { get; set; }

    public long? RepliedMessageId { get; set; }

    public long? ForwardedMessageId { get; set; }
}
