using System.ComponentModel.DataAnnotations;

namespace HW3.Models
{
    public class Account
    {
        [Key]
        public string Username { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
