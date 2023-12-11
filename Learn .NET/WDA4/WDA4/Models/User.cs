using System;
using System.Collections.Generic;

namespace WDA4.Models;

public partial class User
{
    public string Username { get; set; } = null!;

    public string? Password { get; set; }
}
