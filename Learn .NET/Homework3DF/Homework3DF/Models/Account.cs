using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Homework3DF.Models;

public partial class Account
{
    [Key]
    public string Username { get; set; } = null!;

    [Required]
    public string? Password { get; set; }
}
