using System;
using System.ComponentModel.DataAnnotations;

namespace ExaminationWDACF.Models
{
	public class Account
	{
	 [Key]
    public string AccountNo { get; set; }

    [Required]
    [MaxLength(20)]
    public string AccountName { get; set; }

    [Required]
    public string PinCode { get; set; }

    [Required]
    public decimal Balance { get; set; }

    public bool Role { get; set; }
    }
}

