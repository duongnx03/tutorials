using System;
using System.ComponentModel.DataAnnotations;

namespace Student1427717.Models
{
	public class Employee
	{
		[Key]
		public string EmployeeId { get; set; }
		
		public string Password { get; set; }
		public string EmployeeName { get; set; }
		public int Age { get; set; }
		public bool Role { get; set; }
    }
}

