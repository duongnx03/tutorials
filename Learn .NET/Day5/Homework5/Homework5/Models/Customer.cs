using System;
using System.Collections.Generic;

namespace Homework5.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime Birthday { get; set; }

    public bool Gender { get; set; }

    public string Email { get; set; } = null!;
}
