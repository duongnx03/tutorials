using System;
using System.Collections.Generic;

namespace WDA2.Models;

public partial class Position
{
    public int Id { get; set; }

    public string Position1 { get; set; } = null!;

    public double? SalaryPerHour { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
