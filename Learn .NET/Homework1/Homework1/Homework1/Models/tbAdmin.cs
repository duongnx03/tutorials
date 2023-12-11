using System;
using System.ComponentModel.DataAnnotations;

namespace Homework1.Models
{
	public class tbAdmin
	{
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
    }
}

