﻿namespace Messenger.Domain.Models;

public class User
{
    public int Id { get; set; }
    public string Email { get; set; } = null!;
    public string Username { get; set; } = null!;
}