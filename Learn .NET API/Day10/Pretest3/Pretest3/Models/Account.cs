	using System;
	using System.ComponentModel.DataAnnotations;

	namespace Pretest3.Models
	{
		public class Account
		{
			[Key]
			public string Username { get; set; }
			public string Password { get; set; }
			public int Balance { get; set; }
		}
	}

