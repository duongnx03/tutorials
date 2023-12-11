using System;
using System.ComponentModel.DataAnnotations;

namespace ProductOrder.Models
{
	public class Order
	{
		[RegularExpression(@"^O[0-9]{4}$")]
		public string Id { get; set; }
		[MaxLength(30, ErrorMessage ="Max length is 30")]
		public string Name { get; set; }
        [MaxLength(30)]
        public string Phone { get; set; }
        [MaxLength(30)]
        public string Address { get; set; }

		public List<OrderDetail>? OrderDetails { get; set; }
    }
}

