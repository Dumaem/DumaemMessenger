﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Database.Read.Queries
{
    internal static class MessageRepositoryQueries
    {
        internal const string GetMessage = "SELECT * FROM public.message WHERE id = @id;
        internal const string GetUserById = "SELECT * FROM public.user WHERE id = @id";
        internal const string GetUserEncryptedPassword = "SELECT password FROM public.user WHERE id = @id";
    }
}
