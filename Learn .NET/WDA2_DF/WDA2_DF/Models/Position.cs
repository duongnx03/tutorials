using System;
using System.Collections.Generic;

namespace WDA2_DF.Models;

public partial class Position
{
    public int Id { get; set; }

    public string? Position1 { get; set; }

    public double? SalaryPerHour { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
