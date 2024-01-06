using System;
using System.ComponentModel.DataAnnotations;

namespace Client.Models
{
	public class tbNews
	{
		[Key]
		public string NewsId { get; set; }
        public string NewsContent { get; set; }
        public string DateOfPublish { get; set; }

    }
}

