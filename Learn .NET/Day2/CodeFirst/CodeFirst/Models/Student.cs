using System;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models
{
	public class Student
	{
        public int Id { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Min is 2")]
        public String Name { get; set; }

        [Required]
        public String Email { get; set; }

        [Required]
        public String Phone { get; set; }
    }
}
