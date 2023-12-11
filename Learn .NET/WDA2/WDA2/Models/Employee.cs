using System;
using System.Collections.Generic;

namespace WDA2.Models;

public partial class Employee
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int? PositionId { get; set; }

    public virtual Position? Position { get; set; }
}
