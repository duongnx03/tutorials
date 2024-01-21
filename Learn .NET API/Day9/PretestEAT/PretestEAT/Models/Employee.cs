using System;
using System.ComponentModel.DataAnnotations;

namespace PretestEAT.Models
{
	public class Employee
	{
        [Key]
		public string EmpID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public float Salary { get; set; }

    }
}

