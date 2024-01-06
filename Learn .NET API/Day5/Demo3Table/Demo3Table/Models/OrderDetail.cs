﻿using System;
namespace Demo3Table.Models
{
	public class OrderDetail
	{
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }


        public Order? Order { get; set; }
        public Product? Product { get; set; }
    }
}

