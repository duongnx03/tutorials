using System;
using System.ComponentModel.DataAnnotations;

namespace Exercise.Models
{
	public class User
	{
		[Key]
		public string Username { get; set; }
		public string Password { get; set; }
		public string Name { get; set; }
		public int Yob { get; set; }
    }
}

