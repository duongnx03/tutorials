using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Authorize.Models;

public partial class Account
{
    public int Id { get; set; }

    [Display(Name = "Tài Khoản")]
    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Fullname { get; set; }

    public bool? Enable { get; set; }

    public virtual ICollection<AccountRole> AccountRoles { get; set; } = new List<AccountRole>();
}
