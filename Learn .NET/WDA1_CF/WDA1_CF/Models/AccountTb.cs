using System;
using System.ComponentModel.DataAnnotations;

namespace WDA1_CF.Models
{
	public class AccountTb
	{
        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }

        [MaxLength(30)]
        public string Password { get; set; }

        [RegularExpression(@"Admin|User", ErrorMessage = "Only accept Admin or User")]
        public string Role { get; set; }

    }
}

