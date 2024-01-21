using System;
using System.ComponentModel.DataAnnotations;

namespace Pretest2.Models
{
	public class tbNews
	{
		[Key]
		public string NewsId { get; set; }
        public string NewsContent { get; set; }
        public string DateOfPublish { get; set; }

    }
}

