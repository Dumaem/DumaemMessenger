﻿using System;
using System.Collections.Generic;

namespace Messenger.Database.Models;

public partial class DeletedMessageDb
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public long MessageId { get; set; }
}
