using System;
using System.ComponentModel.DataAnnotations;

namespace Homework1.Models
{
	public class tbNews
	{
		[Key]
		public int NewID { get; set; }
		public string HeadLines { get; set; }
		public string ContentOfNews { get; set; }
    }
}

