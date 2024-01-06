using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day2_Demo3Table.IRepository;
using Day2_Demo3Table.Models;
using Microsoft.AspNetCore.Mvc;


namespace Day2_Demo3Table.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepo orderRepo;

        public OrderController(IOrderRepo orderRepo)
        {
            this.orderRepo = orderRepo;
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult> GetOrderByUser(int userId)
        {
            try
            {
                var listOrder = await orderRepo.GetAllOrders(userId);
                return Ok(listOrder);
            }
            catch(Exception e)
            {
               return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> PostOrder(Order order)
        {
            try
            {
                var result = await orderRepo.AddOrder(order);
                return Ok("Add Order success: "+ result);
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpGet("Details/{orderId}")]
        public async Task<ActionResult> GetOrderDetail(int orderId)
        {
            try
            {
                var order = await orderRepo.GetOrderDetails(orderId);
                return Ok(order);
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
    }
}

